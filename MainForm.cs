/* Morpheus: Main form
 * (c) 2022, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/> 
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Noesis.Drawing.Imaging.WebP;
using Multipetros.Config;

namespace Morpheus{
	public partial class MainForm : Form{
		public const string INI_WND_TOP 		= "wintop" ;
		public const string INI_WND_LEFT 		= "winleft" ;
		public const string INI_OUT_FLDR 		= "outfolder" ;
		public const string INI_OUT_FRMT 		= "outformat" ;
		public const string INI_OUT_FLTR		= "outfilter" ;
		public const string INI_OUT_OVRWR		= "outoverwrite" ;
		public const string INI_RESIZE 			= "resize" ;
		public const string INI_RESIZE_TYPE 	= "resizetype" ;
		public const string INI_RESIZE_W 		= "resizewidth" ;
		public const string INI_RESIZE_H 		= "resizeheight" ;
		public const string INI_RESIZE_LRGV 	= "resizelargeval" ;
		public const string INI_RESIZE_BYPASS 	= "resizebypass" ;
		public const string INI_RESIZE_BP_TYPE	= "resizebptype" ;
		public const string INI_SAVE_SETTINGS	= "savesonexit" ;
		protected const string STR_DONE 		= "√" ;
		protected const string STR_WORKING 		= "●" ;
		
		
		protected string[] outputFormats ;
		protected string[] outputFilters ;
		protected List<string> inputExts ;
		protected string inputFilter ;
		protected Ini ini ;
		protected bool stop ;
		protected Stopwatch swatch ;
		protected Form frmAbout ;
		
		public MainForm(){
			InitializeComponent();
			outputFormats = new string[] {"JPEG", "PNG", "GIF", "EMF", "WMF", "TIFF", "BMP", "WEBP"} ;
			outputFilters = new string[] {"None", "Grayscale", "Sepia", "Monochrome", "Negative"} ;
			inputExts = new List<string>(new string[] {".JPG", ".JPEG", ".PNG", ".GIF", ".EMF", ".WMF", ".TIFF", ".TIF", ".BMP", ".WEBP"}) ;
			inputFilter = "All Supported Formats (*.jpg, *.jpeg, *.png, *.gif, *.emf, *.wmf, *.tiff, *.tif, *.bmp, *.webp)|*.JPG;*.JPEG;*.PNG;*.GIF;*.EMF;*.WMF;*.TIFF;*.TIF;*.BMP;*.WEBP|Joint Photographic Experts Group (*.jpg, *.jpeg)|*.JPG;*.JPEG|Portable Network Graphics (*.png)|*.PNG|Graphics Interchange Format (*.gif)|*.GIF|Enhanced Metafile Format (*.emf)|*.EMF|Windows Metafile Format (*.wmf)|*.WMF|Tag Image File Format (*.tiff, *.tif)|*.TIFF;*.TIF|Bitmap (*.bmp)|*.BMP|WebP (*.webp)|*.WEBP" ;
			ini = new Ini(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName + ".ini")) ;
			stop = false ;
			swatch = new Stopwatch() ;
			frmAbout = new AboutForm() ;
		}
		
		void MainFormLoad(object sender, EventArgs e){
			LoadUi() ;
		}
		
		protected void LoadUi(){
			comboBoxOutputFormats.Items.AddRange(outputFormats) ;
			comboBoxOutputFilters.Items.AddRange(outputFilters) ;
			openFileDialogIn.Filter = inputFilter ;
			LoadSettings() ;
			ResizeControlsEnableState() ;
			BypassControlsEnableState() ;
		}
		
		protected void LoadSettings(){
			int intV ;
			string strV ;
			bool blV ;
			
			int.TryParse(ini[INI_WND_TOP], out intV) ;
			if(intV < 0) intV = 50 ;
			this.Top = intV ;
			
			int.TryParse(ini[INI_WND_LEFT], out intV) ;
			if(intV < 0) intV = 50 ;
			this.Left = intV ;
			
			int.TryParse(ini[INI_OUT_FLTR], out intV) ;
			if(intV < 0 || intV > comboBoxOutputFilters.Items.Count - 1) intV = 0 ;
			comboBoxOutputFilters.SelectedIndex = intV ;
			
			int.TryParse(ini[INI_OUT_FRMT], out intV) ;
			if(intV < 0 || intV > comboBoxOutputFormats.Items.Count - 1) intV = 0 ;
			comboBoxOutputFormats.SelectedIndex = intV ;
			
			int.TryParse(ini[INI_RESIZE_H], out intV) ;
			numericUpDownHeight.Value = intV < 1 ? 1 : intV ;
			
			int.TryParse(ini[INI_RESIZE_W], out intV) ;
			numericUpDownWidth.Value = intV < 1 ? 1 : intV ;
			
			int.TryParse(ini[INI_RESIZE_LRGV], out intV) ;
			numericUpDownLargeDim.Value = intV < 1 ? 1 : intV ;
			
			strV = ini[INI_RESIZE_TYPE] ;
			switch (strV) {
				case "w" :
					radioButtonAutow.Checked = true ;
					break ;
				case "h" :
					radioButtonAutoh.Checked = true ;
					break ;
				case "l" :
					radioButtonByLargeDim.Checked = true ;
					break ;
				default:
					radioButtonFreesize.Checked = true ;
					break ;
			}
			
			strV = ini[INI_RESIZE_BP_TYPE] ;
			switch (strV) {
				case "l":
					radioButtonBypassL.Checked = true ;
					break;
				default:
					radioButtonBypassS.Checked = true ;
					break ;
			}
			
			strV = ini[INI_OUT_FLDR] ;
			if(Directory.Exists(strV)) textBoxOutput.Text = ini[INI_OUT_FLDR] ;
						
			bool.TryParse(ini[INI_RESIZE], out blV) ;
			checkBoxResize.Checked = blV ;
			
			bool.TryParse(ini[INI_RESIZE_BYPASS], out blV) ;
			checkBoxBypass.Checked = blV ;
			
			bool.TryParse(ini[INI_OUT_OVRWR], out blV) ;
			checkBoxOverwrite.Checked = blV ;
			
			bool.TryParse(ini[INI_SAVE_SETTINGS], out blV) ;
			saveonexitToolStripMenuItem.Checked = blV ;
		}
		
		protected void SaveSettings(){
			if(saveonexitToolStripMenuItem.Checked){
				ini[INI_WND_TOP] = this.Top.ToString() ;
				ini[INI_WND_LEFT] = this.Left.ToString() ;
				ini[INI_OUT_FLDR] = textBoxOutput.Text ;
				ini[INI_OUT_FRMT] = comboBoxOutputFormats.SelectedIndex.ToString() ;
				ini[INI_OUT_FLTR] = comboBoxOutputFilters.SelectedIndex.ToString() ;
				ini[INI_OUT_OVRWR] = checkBoxOverwrite.Checked.ToString() ;
				ini[INI_RESIZE] = checkBoxResize.Checked.ToString() ;
				ini[INI_RESIZE_TYPE] = radioButtonAutow.Checked ? "w" : radioButtonAutoh.Checked ? "h" : radioButtonByLargeDim.Checked ? "l"  : "f" ;
				ini[INI_RESIZE_BP_TYPE] = radioButtonBypassL.Checked ? "l" : "s" ;
				ini[INI_RESIZE_BYPASS] = checkBoxBypass.Checked.ToString() ;
				ini[INI_RESIZE_H] = numericUpDownHeight.Value.ToString() ;
				ini[INI_RESIZE_W] = numericUpDownWidth.Value.ToString() ;
				ini[INI_RESIZE_LRGV] = numericUpDownLargeDim.Value.ToString() ;
			}
			ini[INI_SAVE_SETTINGS] = saveonexitToolStripMenuItem.Checked.ToString() ;
			ini.Save() ;
		}
		
		protected void DelInputs(){
			if(listViewInputs.Items.Count > 0){
				if(listViewInputs.SelectedItems.Count > 0){
					for(int i=listViewInputs.SelectedItems.Count-1; i>=0 ; i--){
						listViewInputs.Items.Remove(listViewInputs.SelectedItems[i]) ;
					}
				}else{
					MessageBox.Show("There is no file selected to remove!\nPlease select some file(s) first.", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;
				}
			}else{
				MessageBox.Show("There is no files in the list!", "Nothing to remove", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;
			}
		}
		
		protected void ResizeControlsEnableState(){
			foreach(Control c in groupBoxResize.Controls){
				if(c.Name != checkBoxResize.Name)
					c.Enabled = checkBoxResize.Checked ;
			}
			if(checkBoxResize.Checked){
				ResizeValuesEnabledState() ;
				groupBoxBypass.Enabled = !radioButtonFreesize.Checked ;
			}
		}
		
		protected void BypassControlsEnableState(){
			foreach(Control c in groupBoxBypass.Controls){
				if(c.Name != checkBoxBypass.Name)
					c.Enabled = checkBoxBypass.Checked ;
			}
		}
		
		protected void ResizeValuesEnabledState(){
			if(radioButtonFreesize.Checked){
				numericUpDownHeight.Enabled = true ;
				numericUpDownWidth.Enabled = true ;
				numericUpDownLargeDim.Enabled = false ;
			}else if(radioButtonAutoh.Checked){
				numericUpDownHeight.Enabled = false ;
				numericUpDownWidth.Enabled = true ;
				numericUpDownLargeDim.Enabled = false ;
			}else if(radioButtonAutow.Checked){
				numericUpDownHeight.Enabled = true ;
				numericUpDownWidth.Enabled = false ;
				numericUpDownLargeDim.Enabled = false ;
			}else{
				numericUpDownHeight.Enabled = false ;
				numericUpDownWidth.Enabled = false ;
				numericUpDownLargeDim.Enabled = true ;
			}
			groupBoxBypass.Enabled = !radioButtonFreesize.Checked ;
		}
		
		protected bool SelectOutput(){
			if(folderBrowserDialogOut.ShowDialog() == DialogResult.OK){
				textBoxOutput.Text = folderBrowserDialogOut.SelectedPath ;
				return true ;
			}
			return false ;
		}
		
		protected void AddFiles(string[] files){
			foreach(string file in files){
				FileInfo fi = new FileInfo(file) ;
				ListViewItem lvi = new ListViewItem(new string[]{fi.FullName, MathUtils.BytesToString(fi.Length), "", ""}) ;
				lvi.Name = fi.Name ;
				if(!listViewInputs.Items.ContainsKey(lvi.Name) && inputExts.Contains(fi.Extension.ToUpper()))
					listViewInputs.Items.Add(lvi) ;
			}
		}
		
		void ButtonAddInputsClick(object sender, EventArgs e){
			if(openFileDialogIn.ShowDialog() == DialogResult.OK)
				AddFiles(openFileDialogIn.FileNames) ;
		}
		
		void ButtonDelInputsClick(object sender, EventArgs e){
			DelInputs() ;
		}
				
		void TextBoxOutputDragDrop(object sender, DragEventArgs e){
			if(e.Data.GetDataPresent(DataFormats.FileDrop)){
				string[] folder = (string[])e.Data.GetData(DataFormats.FileDrop);
				if(folder.Length > 0 && Directory.Exists(folder[0])){
					textBoxOutput.Text = folder[0] ;
				}
			}
		}
		
		void TextBoxOutputDragEnter(object sender, DragEventArgs e){
			if(e.Data.GetDataPresent(DataFormats.FileDrop)){
				e.Effect = DragDropEffects.Copy ;
			}
		}
		
		void ListBoxInputsKeyDown(object sender, KeyEventArgs e){
			if(e.KeyCode == Keys.Delete){
				DelInputs() ;
			}
		}
		
		void ButtonOutputSelectClick(object sender, EventArgs e){
			SelectOutput() ;
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e){
			SaveSettings() ;
		}
		
		void CheckBoxResizeCheckedChanged(object sender, EventArgs e){
			ResizeControlsEnableState() ;
		}
		
		void ControlsResizeCheckedChanged(object sender, EventArgs e){
			ResizeValuesEnabledState() ;
		}
		
		void CheckBoxBypassCheckedChanged(object sender, EventArgs e){
			BypassControlsEnableState() ;
		}
		
		protected void Start(){
			if(listViewInputs.Items.Count < 1){
				if(MessageBox.Show("No images selected for encoding!\nDo you want to select some now?", "No images to encode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
					if(openFileDialogIn.ShowDialog() == DialogResult.OK){
						AddFiles(openFileDialogIn.FileNames) ;
						Start() ;
					}
				}
				return ;
			}
			
			if(textBoxOutput.Text.Length < 3 || !Directory.Exists(textBoxOutput.Text)){
				if(MessageBox.Show(textBoxOutput.Text.Length < 3 ? "No output folder selected!\nDo you want to use the program's folder as output?" : "The entered output folder not found!\nDo you want to select an existed output folder now?", "Folder not found", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes){
					if(SelectOutput()){
						Start() ;
					}
				}
				return ;
			}
			
			if(!this.stop){
				for(int i=0; i<listViewInputs.Items.Count; i++){
					listViewInputs.Items[i].SubItems[2].Text = string.Empty ;
					listViewInputs.Items[i].SubItems[3].Text = string.Empty ;
					listViewInputs.Items[i].SubItems[3].Tag = null ;
				}
			}
			
			buttonStart.Enabled = false ;
			this.stop = false ;
			toolStripProgressBarWork.Maximum = listViewInputs.Items.Count ;
			toolStripStatusLabelMsg.Text = "Working, please wait..." ;
			backgroundWorkerConvert.RunWorkerAsync(
				new WorkerArgs(
					listViewInputs.Items, 
					comboBoxOutputFormats.SelectedItem.ToString(),
					comboBoxOutputFilters.SelectedItem.ToString()
				)
			) ;
		}
		
		protected void Stop(){
			this.stop = true ;
			buttonStart.Enabled = true ;
		}
		
		void BackgroundWorkerConvertDoWork(object sender, System.ComponentModel.DoWorkEventArgs e){
			swatch.Start() ;
			int percentage = toolStripProgressBarWork.Value + 1 ;
			WorkerArgs warg = (WorkerArgs)e.Argument ;
			string[] files = warg.Files ;
			for(int i=toolStripProgressBarWork.Value; i<files.Length && !this.stop; i++){
				string curFilePath = files[i] ;
				string curFileName = Path.GetFileNameWithoutExtension(curFilePath) ;
				string curExt = Path.GetExtension(curFilePath).ToUpper() ;
				string outFormat = warg.OutputFormat ;
				string outFilter = warg.OutputFilter ;
				string outFilePath = Path.Combine(textBoxOutput.Text, curFileName + "." + outFormat.ToLower());
				Bitmap curBmp ;
				if(File.Exists(curFilePath) && !(!checkBoxOverwrite.Checked && File.Exists(outFilePath))){
					try {
						curBmp = (curExt == "WEBP") ? WebPFormat.LoadFromFile(curFilePath) : new Bitmap(Image.FromFile(curFilePath)) ;
						
						if(checkBoxResize.Checked){
							if(radioButtonFreesize.Checked){
								curBmp = BitmapUtils.Resize(curBmp, (int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value) ;
							}else{
								BitmapUtils.ResizeBypass bypass = BitmapUtils.ResizeBypass.NoBypass ;
								if(checkBoxBypass.Checked){
									if(radioButtonBypassS.Checked){
										bypass = BitmapUtils.ResizeBypass.InSmallerOrigin ;
									}else{
										bypass = BitmapUtils.ResizeBypass.InBiggerOrigin ;
									}
								}
								
								if(radioButtonAutoh.Checked){
									curBmp = BitmapUtils.ResizeByWidth(curBmp, (int)numericUpDownWidth.Value, bypass) ;
								}else if(radioButtonAutow.Checked){
									curBmp = BitmapUtils.ResizeByHeight(curBmp, (int)numericUpDownHeight.Value, bypass) ;
								}else{
									curBmp = BitmapUtils.ResizeByLargerDimension(curBmp, (int)numericUpDownLargeDim.Value, bypass) ;
								}
							}
						}
						
						switch (outFilter) {
							case "Grayscale" :
								curBmp = BitmapUtils.ToGrayscale(curBmp) ;
								break;
							case "Sepia" :
								curBmp = BitmapUtils.ToSepia(curBmp) ;
								break;
							case "Monochrome" :
								curBmp = BitmapUtils.ToMonochrome(curBmp) ;
								break;
							case "Negative" :
								curBmp = BitmapUtils.ToNegative(curBmp) ;
								break;
						}
						
						switch(outFormat){
							case "JPEG":
								curBmp.Save(outFilePath, ImageFormat.Jpeg) ;
								break;
							case "PNG":
								curBmp.Save(outFilePath, ImageFormat.Png) ;
								break;
							case "GIF":
								curBmp.Save(outFilePath, ImageFormat.Gif) ;
								break;
							case "EMF":
								curBmp.Save(outFilePath, ImageFormat.Emf) ;
								break;
							case "WMF":
								curBmp.Save(outFilePath, ImageFormat.Wmf) ;
								break;
							case "TIFF":
								curBmp.Save(outFilePath, ImageFormat.Tiff) ;
								break;
							case "BMP":
								curBmp.Save(outFilePath, ImageFormat.Bmp) ;
								break;
							case "WEBP":
								WebPFormat.SaveToFile(outFilePath, curBmp) ;
								break;
						}
					}catch(Exception err){
						MessageBox.Show(err.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
					}
				}
				backgroundWorkerConvert.ReportProgress(percentage++, outFilePath) ;
			}
		}
		
		void BackgroundWorkerConvertProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e){
			toolStripProgressBarWork.Value = e.ProgressPercentage ;
			
			FileInfo fi = new FileInfo((string)e.UserState) ;
			if(fi.Exists){
				listViewInputs.Items[e.ProgressPercentage-1].SubItems[3].Text = MathUtils.BytesToString(fi.Length) ;
				listViewInputs.Items[e.ProgressPercentage-1].SubItems[3].Tag = fi.FullName ;
			}
			
			listViewInputs.Items[e.ProgressPercentage-1].SubItems[2].Text = STR_DONE ;
			if(e.ProgressPercentage < listViewInputs.Items.Count){
				listViewInputs.Items[e.ProgressPercentage].EnsureVisible() ;
				listViewInputs.Items[e.ProgressPercentage].SubItems[2].Text = STR_WORKING ;
			}
			

		}
		
		void BackgroundWorkerConvertRunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e){
			swatch.Stop() ;
			buttonStart.Enabled = true ;
			if(!stop){
				TimeSpan elpasedMs = swatch.Elapsed ;
				string time = elpasedMs.Hours.ToString("00") + ":" + elpasedMs.Minutes.ToString("00") + ":" + elpasedMs.Seconds.ToString("00") + "." + elpasedMs.Milliseconds.ToString("000") ;
				toolStripStatusLabelMsg.Text = string.Format("Done! Morphed {0} images in {1} | Ready", listViewInputs.Items.Count.ToString(), time) ;
				toolStripProgressBarWork.Value = toolStripProgressBarWork.Minimum ;
				swatch.Reset() ;
			}else{
				toolStripStatusLabelMsg.Text = "Stopped" ;
			}
		}
		
		void ButtonStartClick(object sender, EventArgs e){
			Start() ;
		}
		
		void ButtonStopClick(object sender, EventArgs e){
			Stop() ;
		}
		
		void ListViewInputsDoubleClick(object sender, EventArgs e){
		    ListViewHitTestInfo hitInf = listViewInputs.HitTest(listViewInputs.PointToClient(Control.MousePosition));
		    int col = hitInf.Item.SubItems.IndexOf(hitInf.SubItem);
		    if(col < 2){
		    	try{
		    		System.Diagnostics.Process.Start(Path.GetFullPath(listViewInputs.Items[listViewInputs.SelectedIndices[0]].SubItems[0].Text)) ;
		    	}catch(Exception err){
		    		MessageBox.Show(err.Message, "Error opening source image", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
		    	}
		    }else{
		    	if(listViewInputs.Items[listViewInputs.SelectedIndices[0]].SubItems[2].Text == "√"){
			    	try{
			    		System.Diagnostics.Process.Start(Path.GetFullPath((string)listViewInputs.Items[listViewInputs.SelectedIndices[0]].SubItems[3].Tag)) ;
			    	}catch(Exception err){
			    		MessageBox.Show(err.Message, "Error opening destination image", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
			    	}
		    	}
		    }
		}
		
		protected void OpenOutputsDir(){
			if(Directory.Exists(textBoxOutput.Text)){
				try{
					System.Diagnostics.Process.Start(Path.GetFullPath(textBoxOutput.Text)) ;
				}catch(Exception err){
					MessageBox.Show(err.Message, "Error opening output directory", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				}
			}
		}
		
		void ButtonOutputOpenClick(object sender, EventArgs e){
			OpenOutputsDir();
		}
		
		protected void ClearInputs(){
			listViewInputs.Items.Clear() ;
			toolStripStatusLabelMsg.Text = "Ready" ;
			toolStripProgressBarWork.Value = toolStripProgressBarWork.Minimum ;
		}
		
		void ButtonClearInputsClick(object sender, EventArgs e){
			ClearInputs() ;
		}
		
		void ButtonStartEnabledChanged(object sender, EventArgs e){
			buttonClearInputs.Enabled = buttonStart.Enabled ;
			buttonAddInputs.Enabled = buttonStart.Enabled ;
			buttonDelInputs.Enabled = buttonStart.Enabled ;
			buttonOutputSelect.Enabled = buttonStart.Enabled ;
			buttonOutputOpen.Enabled = buttonStart.Enabled ;
			checkBoxOverwrite.Enabled = buttonStart.Enabled ;
			comboBoxOutputFilters.Enabled = buttonStart.Enabled ;
			comboBoxOutputFormats.Enabled = buttonStart.Enabled ;
			groupBoxResize.Enabled = buttonStart.Enabled ;
			buttonStop.Enabled = !buttonStart.Enabled ;
		}
		
		void ListViewInputsDragDrop(object sender, DragEventArgs e){
			if(e.Data.GetDataPresent(DataFormats.FileDrop)){
				AddFiles((string[])e.Data.GetData(DataFormats.FileDrop));
			}
		}
		
		void ListViewInputsDragEnter(object sender, DragEventArgs e){
			if(e.Data.GetDataPresent(DataFormats.FileDrop)){
				e.Effect = DragDropEffects.Copy ;
			}
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit() ;
		}
		
		void AddToolStripMenuItemClick(object sender, EventArgs e){
			if(openFileDialogIn.ShowDialog() == DialogResult.OK)
				AddFiles(openFileDialogIn.FileNames) ;
		}
		
		void DelToolStripMenuItemClick(object sender, EventArgs e){
			DelInputs() ;
		}
		
		void ClearToolStripMenuItemClick(object sender, EventArgs e){
			ClearInputs() ;
		}
		
		void FldselectToolStripMenuItemClick(object sender, EventArgs e){
			SelectOutput() ;
		}
		
		void FldopenToolStripMenuItemClick(object sender, EventArgs e){
			OpenOutputsDir() ;
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e){
			new AboutForm().ShowDialog() ;
		}
		
		void SaveonexitToolStripMenuItemClick(object sender, EventArgs e){
			saveonexitToolStripMenuItem.Checked = !saveonexitToolStripMenuItem.Checked ;
		}
	}
}
