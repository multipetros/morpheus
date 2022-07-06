/* Morpheus: Main form
 * (c) 2022, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/> 
 */
namespace Morpheus
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.statusStripBottom = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBarWork = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabelMsg = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStripTop = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.fldselectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fldopenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.saveonexitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.buttonOutputSelect = new System.Windows.Forms.Button();
			this.buttonOutputOpen = new System.Windows.Forms.Button();
			this.groupBoxResize = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxBypass = new System.Windows.Forms.GroupBox();
			this.radioButtonBypassL = new System.Windows.Forms.RadioButton();
			this.radioButtonBypassS = new System.Windows.Forms.RadioButton();
			this.checkBoxBypass = new System.Windows.Forms.CheckBox();
			this.radioButtonByLargeDim = new System.Windows.Forms.RadioButton();
			this.radioButtonAutoh = new System.Windows.Forms.RadioButton();
			this.radioButtonAutow = new System.Windows.Forms.RadioButton();
			this.radioButtonFreesize = new System.Windows.Forms.RadioButton();
			this.numericUpDownLargeDim = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
			this.checkBoxResize = new System.Windows.Forms.CheckBox();
			this.labelOutputFormat = new System.Windows.Forms.Label();
			this.comboBoxOutputFormats = new System.Windows.Forms.ComboBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonAddInputs = new System.Windows.Forms.Button();
			this.buttonDelInputs = new System.Windows.Forms.Button();
			this.labelInputs = new System.Windows.Forms.Label();
			this.labelOutput = new System.Windows.Forms.Label();
			this.buttonStop = new System.Windows.Forms.Button();
			this.folderBrowserDialogOut = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialogIn = new System.Windows.Forms.OpenFileDialog();
			this.backgroundWorkerConvert = new System.ComponentModel.BackgroundWorker();
			this.listViewInputs = new System.Windows.Forms.ListView();
			this.columnHeaderPath = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderSize = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderDone = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderNewSize = new System.Windows.Forms.ColumnHeader();
			this.buttonClearInputs = new System.Windows.Forms.Button();
			this.comboBoxOutputFilters = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
			this.statusStripBottom.SuspendLayout();
			this.menuStripTop.SuspendLayout();
			this.groupBoxResize.SuspendLayout();
			this.groupBoxBypass.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLargeDim)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStripBottom
			// 
			this.statusStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripProgressBarWork,
									this.toolStripStatusLabelMsg});
			this.statusStripBottom.Location = new System.Drawing.Point(0, 542);
			this.statusStripBottom.Name = "statusStripBottom";
			this.statusStripBottom.Size = new System.Drawing.Size(580, 22);
			this.statusStripBottom.SizingGrip = false;
			this.statusStripBottom.TabIndex = 0;
			this.statusStripBottom.Text = "statusStrip1";
			// 
			// toolStripProgressBarWork
			// 
			this.toolStripProgressBarWork.Name = "toolStripProgressBarWork";
			this.toolStripProgressBarWork.Size = new System.Drawing.Size(250, 16);
			// 
			// toolStripStatusLabelMsg
			// 
			this.toolStripStatusLabelMsg.Name = "toolStripStatusLabelMsg";
			this.toolStripStatusLabelMsg.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabelMsg.Text = "Ready";
			// 
			// menuStripTop
			// 
			this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStripTop.Location = new System.Drawing.Point(0, 0);
			this.menuStripTop.Name = "menuStripTop";
			this.menuStripTop.Size = new System.Drawing.Size(580, 24);
			this.menuStripTop.TabIndex = 1;
			this.menuStripTop.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.addToolStripMenuItem,
									this.delToolStripMenuItem,
									this.clearToolStripMenuItem,
									this.toolStripSeparator2,
									this.fldselectToolStripMenuItem,
									this.fldopenToolStripMenuItem,
									this.toolStripSeparator1,
									this.saveonexitToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.addToolStripMenuItem.Text = "&Add...";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItemClick);
			// 
			// delToolStripMenuItem
			// 
			this.delToolStripMenuItem.Name = "delToolStripMenuItem";
			this.delToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.delToolStripMenuItem.Text = "&Remove";
			this.delToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItemClick);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.clearToolStripMenuItem.Text = "&Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
			// 
			// fldselectToolStripMenuItem
			// 
			this.fldselectToolStripMenuItem.Name = "fldselectToolStripMenuItem";
			this.fldselectToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.fldselectToolStripMenuItem.Text = "Output Se&lect";
			this.fldselectToolStripMenuItem.Click += new System.EventHandler(this.FldselectToolStripMenuItemClick);
			// 
			// fldopenToolStripMenuItem
			// 
			this.fldopenToolStripMenuItem.Name = "fldopenToolStripMenuItem";
			this.fldopenToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.fldopenToolStripMenuItem.Text = "Output O&pen";
			this.fldopenToolStripMenuItem.Click += new System.EventHandler(this.FldopenToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
			// 
			// saveonexitToolStripMenuItem
			// 
			this.saveonexitToolStripMenuItem.Checked = true;
			this.saveonexitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.saveonexitToolStripMenuItem.Name = "saveonexitToolStripMenuItem";
			this.saveonexitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.saveonexitToolStripMenuItem.Text = "Save Setting&s on Exit";
			this.saveonexitToolStripMenuItem.Click += new System.EventHandler(this.SaveonexitToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "A&bout";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.AllowDrop = true;
			this.textBoxOutput.Location = new System.Drawing.Point(12, 311);
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.Size = new System.Drawing.Size(408, 20);
			this.textBoxOutput.TabIndex = 3;
			this.textBoxOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxOutputDragDrop);
			this.textBoxOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxOutputDragEnter);
			// 
			// buttonOutputSelect
			// 
			this.buttonOutputSelect.Location = new System.Drawing.Point(426, 308);
			this.buttonOutputSelect.Name = "buttonOutputSelect";
			this.buttonOutputSelect.Size = new System.Drawing.Size(68, 23);
			this.buttonOutputSelect.TabIndex = 4;
			this.buttonOutputSelect.Text = "Select...";
			this.buttonOutputSelect.UseVisualStyleBackColor = true;
			this.buttonOutputSelect.Click += new System.EventHandler(this.ButtonOutputSelectClick);
			// 
			// buttonOutputOpen
			// 
			this.buttonOutputOpen.Location = new System.Drawing.Point(500, 308);
			this.buttonOutputOpen.Name = "buttonOutputOpen";
			this.buttonOutputOpen.Size = new System.Drawing.Size(68, 23);
			this.buttonOutputOpen.TabIndex = 5;
			this.buttonOutputOpen.Text = "Open";
			this.buttonOutputOpen.UseVisualStyleBackColor = true;
			this.buttonOutputOpen.Click += new System.EventHandler(this.ButtonOutputOpenClick);
			// 
			// groupBoxResize
			// 
			this.groupBoxResize.Controls.Add(this.label3);
			this.groupBoxResize.Controls.Add(this.label2);
			this.groupBoxResize.Controls.Add(this.label1);
			this.groupBoxResize.Controls.Add(this.groupBoxBypass);
			this.groupBoxResize.Controls.Add(this.radioButtonByLargeDim);
			this.groupBoxResize.Controls.Add(this.radioButtonAutoh);
			this.groupBoxResize.Controls.Add(this.radioButtonAutow);
			this.groupBoxResize.Controls.Add(this.radioButtonFreesize);
			this.groupBoxResize.Controls.Add(this.numericUpDownLargeDim);
			this.groupBoxResize.Controls.Add(this.numericUpDownHeight);
			this.groupBoxResize.Controls.Add(this.numericUpDownWidth);
			this.groupBoxResize.Controls.Add(this.checkBoxResize);
			this.groupBoxResize.Location = new System.Drawing.Point(16, 340);
			this.groupBoxResize.Name = "groupBoxResize";
			this.groupBoxResize.Size = new System.Drawing.Size(552, 131);
			this.groupBoxResize.TabIndex = 6;
			this.groupBoxResize.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(337, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 18);
			this.label3.TabIndex = 17;
			this.label3.Text = "px";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(337, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "px Height";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(337, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "px Width";
			// 
			// groupBoxBypass
			// 
			this.groupBoxBypass.Controls.Add(this.radioButtonBypassL);
			this.groupBoxBypass.Controls.Add(this.radioButtonBypassS);
			this.groupBoxBypass.Controls.Add(this.checkBoxBypass);
			this.groupBoxBypass.Location = new System.Drawing.Point(410, 49);
			this.groupBoxBypass.Name = "groupBoxBypass";
			this.groupBoxBypass.Size = new System.Drawing.Size(136, 76);
			this.groupBoxBypass.TabIndex = 14;
			this.groupBoxBypass.TabStop = false;
			// 
			// radioButtonBypassL
			// 
			this.radioButtonBypassL.Location = new System.Drawing.Point(15, 46);
			this.radioButtonBypassL.Name = "radioButtonBypassL";
			this.radioButtonBypassL.Size = new System.Drawing.Size(104, 24);
			this.radioButtonBypassL.TabIndex = 14;
			this.radioButtonBypassL.TabStop = true;
			this.radioButtonBypassL.Text = "image is Larger";
			this.radioButtonBypassL.UseVisualStyleBackColor = true;
			// 
			// radioButtonBypassS
			// 
			this.radioButtonBypassS.Location = new System.Drawing.Point(15, 19);
			this.radioButtonBypassS.Name = "radioButtonBypassS";
			this.radioButtonBypassS.Size = new System.Drawing.Size(104, 24);
			this.radioButtonBypassS.TabIndex = 13;
			this.radioButtonBypassS.TabStop = true;
			this.radioButtonBypassS.Text = "image is Smaller";
			this.radioButtonBypassS.UseVisualStyleBackColor = true;
			// 
			// checkBoxBypass
			// 
			this.checkBoxBypass.Location = new System.Drawing.Point(15, -5);
			this.checkBoxBypass.Name = "checkBoxBypass";
			this.checkBoxBypass.Size = new System.Drawing.Size(99, 24);
			this.checkBoxBypass.TabIndex = 12;
			this.checkBoxBypass.Text = "Bypass resize if";
			this.checkBoxBypass.UseVisualStyleBackColor = true;
			this.checkBoxBypass.CheckedChanged += new System.EventHandler(this.CheckBoxBypassCheckedChanged);
			// 
			// radioButtonByLargeDim
			// 
			this.radioButtonByLargeDim.Location = new System.Drawing.Point(15, 101);
			this.radioButtonByLargeDim.Name = "radioButtonByLargeDim";
			this.radioButtonByLargeDim.Size = new System.Drawing.Size(225, 24);
			this.radioButtonByLargeDim.TabIndex = 13;
			this.radioButtonByLargeDim.TabStop = true;
			this.radioButtonByLargeDim.Text = "Resize by set the larger dimension";
			this.radioButtonByLargeDim.UseVisualStyleBackColor = true;
			this.radioButtonByLargeDim.CheckedChanged += new System.EventHandler(this.ControlsResizeCheckedChanged);
			// 
			// radioButtonAutoh
			// 
			this.radioButtonAutoh.Location = new System.Drawing.Point(15, 49);
			this.radioButtonAutoh.Name = "radioButtonAutoh";
			this.radioButtonAutoh.Size = new System.Drawing.Size(225, 24);
			this.radioButtonAutoh.TabIndex = 11;
			this.radioButtonAutoh.TabStop = true;
			this.radioButtonAutoh.Text = "Auto height, to keep aspect ratio to Width";
			this.radioButtonAutoh.UseVisualStyleBackColor = true;
			this.radioButtonAutoh.CheckedChanged += new System.EventHandler(this.ControlsResizeCheckedChanged);
			// 
			// radioButtonAutow
			// 
			this.radioButtonAutow.Location = new System.Drawing.Point(15, 75);
			this.radioButtonAutow.Name = "radioButtonAutow";
			this.radioButtonAutow.Size = new System.Drawing.Size(225, 24);
			this.radioButtonAutow.TabIndex = 10;
			this.radioButtonAutow.TabStop = true;
			this.radioButtonAutow.Text = "Auto width, to keep aspect ratio to Height";
			this.radioButtonAutow.UseVisualStyleBackColor = true;
			this.radioButtonAutow.CheckedChanged += new System.EventHandler(this.ControlsResizeCheckedChanged);
			// 
			// radioButtonFreesize
			// 
			this.radioButtonFreesize.Location = new System.Drawing.Point(15, 25);
			this.radioButtonFreesize.Name = "radioButtonFreesize";
			this.radioButtonFreesize.Size = new System.Drawing.Size(239, 24);
			this.radioButtonFreesize.TabIndex = 9;
			this.radioButtonFreesize.TabStop = true;
			this.radioButtonFreesize.Text = "Free resize";
			this.radioButtonFreesize.UseVisualStyleBackColor = true;
			this.radioButtonFreesize.CheckedChanged += new System.EventHandler(this.ControlsResizeCheckedChanged);
			// 
			// numericUpDownLargeDim
			// 
			this.numericUpDownLargeDim.Location = new System.Drawing.Point(246, 105);
			this.numericUpDownLargeDim.Maximum = new decimal(new int[] {
									65535,
									0,
									0,
									0});
			this.numericUpDownLargeDim.Name = "numericUpDownLargeDim";
			this.numericUpDownLargeDim.Size = new System.Drawing.Size(85, 20);
			this.numericUpDownLargeDim.TabIndex = 6;
			// 
			// numericUpDownHeight
			// 
			this.numericUpDownHeight.Location = new System.Drawing.Point(246, 79);
			this.numericUpDownHeight.Maximum = new decimal(new int[] {
									65535,
									0,
									0,
									0});
			this.numericUpDownHeight.Name = "numericUpDownHeight";
			this.numericUpDownHeight.Size = new System.Drawing.Size(85, 20);
			this.numericUpDownHeight.TabIndex = 2;
			// 
			// numericUpDownWidth
			// 
			this.numericUpDownWidth.Location = new System.Drawing.Point(246, 53);
			this.numericUpDownWidth.Maximum = new decimal(new int[] {
									65535,
									0,
									0,
									0});
			this.numericUpDownWidth.Name = "numericUpDownWidth";
			this.numericUpDownWidth.Size = new System.Drawing.Size(85, 20);
			this.numericUpDownWidth.TabIndex = 1;
			// 
			// checkBoxResize
			// 
			this.checkBoxResize.AutoSize = true;
			this.checkBoxResize.Location = new System.Drawing.Point(15, 0);
			this.checkBoxResize.Name = "checkBoxResize";
			this.checkBoxResize.Size = new System.Drawing.Size(58, 17);
			this.checkBoxResize.TabIndex = 0;
			this.checkBoxResize.Text = "Resize";
			this.checkBoxResize.UseVisualStyleBackColor = true;
			this.checkBoxResize.CheckedChanged += new System.EventHandler(this.CheckBoxResizeCheckedChanged);
			// 
			// labelOutputFormat
			// 
			this.labelOutputFormat.Location = new System.Drawing.Point(16, 515);
			this.labelOutputFormat.Name = "labelOutputFormat";
			this.labelOutputFormat.Size = new System.Drawing.Size(116, 23);
			this.labelOutputFormat.TabIndex = 7;
			this.labelOutputFormat.Text = "Output image format";
			// 
			// comboBoxOutputFormats
			// 
			this.comboBoxOutputFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOutputFormats.FormattingEnabled = true;
			this.comboBoxOutputFormats.Location = new System.Drawing.Point(135, 512);
			this.comboBoxOutputFormats.Name = "comboBoxOutputFormats";
			this.comboBoxOutputFormats.Size = new System.Drawing.Size(121, 21);
			this.comboBoxOutputFormats.TabIndex = 8;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(500, 510);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(68, 23);
			this.buttonStart.TabIndex = 9;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
			this.buttonStart.EnabledChanged += new System.EventHandler(this.ButtonStartEnabledChanged);
			// 
			// buttonAddInputs
			// 
			this.buttonAddInputs.Location = new System.Drawing.Point(352, 32);
			this.buttonAddInputs.Name = "buttonAddInputs";
			this.buttonAddInputs.Size = new System.Drawing.Size(68, 23);
			this.buttonAddInputs.TabIndex = 10;
			this.buttonAddInputs.Text = "Add...";
			this.buttonAddInputs.UseVisualStyleBackColor = true;
			this.buttonAddInputs.Click += new System.EventHandler(this.ButtonAddInputsClick);
			// 
			// buttonDelInputs
			// 
			this.buttonDelInputs.Location = new System.Drawing.Point(426, 32);
			this.buttonDelInputs.Name = "buttonDelInputs";
			this.buttonDelInputs.Size = new System.Drawing.Size(68, 23);
			this.buttonDelInputs.TabIndex = 11;
			this.buttonDelInputs.Text = "Remove";
			this.buttonDelInputs.UseVisualStyleBackColor = true;
			this.buttonDelInputs.Click += new System.EventHandler(this.ButtonDelInputsClick);
			// 
			// labelInputs
			// 
			this.labelInputs.AutoSize = true;
			this.labelInputs.Location = new System.Drawing.Point(12, 37);
			this.labelInputs.Name = "labelInputs";
			this.labelInputs.Size = new System.Drawing.Size(57, 13);
			this.labelInputs.TabIndex = 12;
			this.labelInputs.Text = "Image files";
			// 
			// labelOutput
			// 
			this.labelOutput.AutoSize = true;
			this.labelOutput.Location = new System.Drawing.Point(12, 285);
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.Size = new System.Drawing.Size(82, 13);
			this.labelOutput.TabIndex = 13;
			this.labelOutput.Text = "Output directory";
			// 
			// buttonStop
			// 
			this.buttonStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonStop.Enabled = false;
			this.buttonStop.Location = new System.Drawing.Point(426, 510);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(68, 23);
			this.buttonStop.TabIndex = 14;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.ButtonStopClick);
			// 
			// openFileDialogIn
			// 
			this.openFileDialogIn.FileName = "openFileDialog1";
			this.openFileDialogIn.Multiselect = true;
			// 
			// backgroundWorkerConvert
			// 
			this.backgroundWorkerConvert.WorkerReportsProgress = true;
			this.backgroundWorkerConvert.WorkerSupportsCancellation = true;
			this.backgroundWorkerConvert.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerConvertDoWork);
			this.backgroundWorkerConvert.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerConvertRunWorkerCompleted);
			this.backgroundWorkerConvert.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerConvertProgressChanged);
			// 
			// listViewInputs
			// 
			this.listViewInputs.AllowDrop = true;
			this.listViewInputs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeaderPath,
									this.columnHeaderSize,
									this.columnHeaderDone,
									this.columnHeaderNewSize});
			this.listViewInputs.FullRowSelect = true;
			this.listViewInputs.GridLines = true;
			this.listViewInputs.Location = new System.Drawing.Point(12, 61);
			this.listViewInputs.Name = "listViewInputs";
			this.listViewInputs.Size = new System.Drawing.Size(556, 212);
			this.listViewInputs.TabIndex = 15;
			this.listViewInputs.UseCompatibleStateImageBehavior = false;
			this.listViewInputs.View = System.Windows.Forms.View.Details;
			this.listViewInputs.DoubleClick += new System.EventHandler(this.ListViewInputsDoubleClick);
			this.listViewInputs.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListViewInputsDragDrop);
			this.listViewInputs.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListViewInputsDragEnter);
			// 
			// columnHeaderPath
			// 
			this.columnHeaderPath.Text = "Path";
			this.columnHeaderPath.Width = 370;
			// 
			// columnHeaderSize
			// 
			this.columnHeaderSize.Text = "Size";
			this.columnHeaderSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeaderSize.Width = 65;
			// 
			// columnHeaderDone
			// 
			this.columnHeaderDone.Text = "";
			this.columnHeaderDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderDone.Width = 25;
			// 
			// columnHeaderNewSize
			// 
			this.columnHeaderNewSize.Text = "New Size";
			this.columnHeaderNewSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeaderNewSize.Width = 65;
			// 
			// buttonClearInputs
			// 
			this.buttonClearInputs.Location = new System.Drawing.Point(500, 32);
			this.buttonClearInputs.Name = "buttonClearInputs";
			this.buttonClearInputs.Size = new System.Drawing.Size(68, 23);
			this.buttonClearInputs.TabIndex = 18;
			this.buttonClearInputs.Text = "Clear";
			this.buttonClearInputs.UseVisualStyleBackColor = true;
			this.buttonClearInputs.Click += new System.EventHandler(this.ButtonClearInputsClick);
			// 
			// comboBoxOutputFilters
			// 
			this.comboBoxOutputFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOutputFilters.FormattingEnabled = true;
			this.comboBoxOutputFilters.Location = new System.Drawing.Point(135, 480);
			this.comboBoxOutputFilters.Name = "comboBoxOutputFilters";
			this.comboBoxOutputFilters.Size = new System.Drawing.Size(121, 21);
			this.comboBoxOutputFilters.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 483);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 23);
			this.label4.TabIndex = 19;
			this.label4.Text = "Output image filter";
			// 
			// checkBoxOverwrite
			// 
			this.checkBoxOverwrite.Location = new System.Drawing.Point(353, 478);
			this.checkBoxOverwrite.Name = "checkBoxOverwrite";
			this.checkBoxOverwrite.Size = new System.Drawing.Size(214, 24);
			this.checkBoxOverwrite.TabIndex = 21;
			this.checkBoxOverwrite.Text = "Ovewrite same files to the output";
			this.checkBoxOverwrite.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonStop;
			this.ClientSize = new System.Drawing.Size(580, 564);
			this.Controls.Add(this.checkBoxOverwrite);
			this.Controls.Add(this.comboBoxOutputFilters);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonClearInputs);
			this.Controls.Add(this.listViewInputs);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.labelOutput);
			this.Controls.Add(this.labelInputs);
			this.Controls.Add(this.buttonDelInputs);
			this.Controls.Add(this.buttonAddInputs);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.comboBoxOutputFormats);
			this.Controls.Add(this.labelOutputFormat);
			this.Controls.Add(this.groupBoxResize);
			this.Controls.Add(this.buttonOutputOpen);
			this.Controls.Add(this.buttonOutputSelect);
			this.Controls.Add(this.textBoxOutput);
			this.Controls.Add(this.statusStripBottom);
			this.Controls.Add(this.menuStripTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = global::Morpheus.Morpheus.icon;
			this.MainMenuStrip = this.menuStripTop;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Morpheus";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.statusStripBottom.ResumeLayout(false);
			this.statusStripBottom.PerformLayout();
			this.menuStripTop.ResumeLayout(false);
			this.menuStripTop.PerformLayout();
			this.groupBoxResize.ResumeLayout(false);
			this.groupBoxResize.PerformLayout();
			this.groupBoxBypass.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLargeDim)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem saveonexitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem fldopenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fldselectToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.CheckBox checkBoxOverwrite;
		private System.Windows.Forms.ComboBox comboBoxOutputFilters;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonClearInputs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ColumnHeader columnHeaderNewSize;
		private System.Windows.Forms.ColumnHeader columnHeaderDone;
		private System.Windows.Forms.ColumnHeader columnHeaderSize;
		private System.Windows.Forms.ColumnHeader columnHeaderPath;
		private System.Windows.Forms.ListView listViewInputs;
		private System.Windows.Forms.CheckBox checkBoxBypass;
		private System.Windows.Forms.RadioButton radioButtonBypassS;
		private System.Windows.Forms.RadioButton radioButtonBypassL;
		private System.Windows.Forms.GroupBox groupBoxBypass;
		private System.Windows.Forms.RadioButton radioButtonByLargeDim;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOut;
		private System.Windows.Forms.OpenFileDialog openFileDialogIn;
		private System.ComponentModel.BackgroundWorker backgroundWorkerConvert;
		private System.Windows.Forms.StatusStrip statusStripBottom;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarWork;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMsg;
		private System.Windows.Forms.MenuStrip menuStripTop;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.Button buttonOutputSelect;
		private System.Windows.Forms.Button buttonOutputOpen;
		private System.Windows.Forms.GroupBox groupBoxResize;
		private System.Windows.Forms.RadioButton radioButtonAutoh;
		private System.Windows.Forms.RadioButton radioButtonAutow;
		private System.Windows.Forms.RadioButton radioButtonFreesize;
		private System.Windows.Forms.NumericUpDown numericUpDownLargeDim;
		private System.Windows.Forms.NumericUpDown numericUpDownHeight;
		private System.Windows.Forms.NumericUpDown numericUpDownWidth;
		private System.Windows.Forms.CheckBox checkBoxResize;
		private System.Windows.Forms.Label labelOutputFormat;
		private System.Windows.Forms.ComboBox comboBoxOutputFormats;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label labelOutput;
		private System.Windows.Forms.Button buttonAddInputs;
		private System.Windows.Forms.Button buttonDelInputs;
		private System.Windows.Forms.Label labelInputs;
	}
}
