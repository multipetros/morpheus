/* Morpheus: About form
 * (c) 2022, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/> 
 */
 
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Morpheus{
	public partial class AboutForm : Form{
		protected const string MSG_TITLE_ERROR = "Ooops!" ;
		protected const string MSG_FILENOTFOUND = "License file not found!\nDo you want to read the license from the GNU website?" ;
		protected const string FILE_LIC = "license.txt" ;
		protected const string FILE_VIEWER = "notepad.exe" ;
		protected const string URL_LIC = "http://www.gnu.org/licenses/gpl-3.0.html" ;
		protected const string URL_ME = "http://www.multipetros.gr/" ;
			
		protected Version ver ;
		
		public AboutForm(){
			InitializeComponent();
			
			ver = new Version(Application.ProductVersion) ;
			labelDescription.Text = string.Format("{0} - v {1}.{2}\nImage format converter and bulk resizer\nCopytight (c) 2022, {3}",
	  		                                      Application.ProductName, 
	  		                                      ver.Major.ToString(),
	  		                                      ver.Minor.ToString(),
	  		                                      Application.CompanyName) ;
						
			LinkLabel.Link mySite = new LinkLabel.Link();
	  	 	mySite.LinkData = URL_ME;
	  		linkLabel1.Links.Add(mySite);
		}		
				
		void ButtonOkClick(object sender, EventArgs e){
			this.DialogResult = DialogResult.OK ;
			this.Close() ;
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
			Process.Start(e.Link.LinkData as string);
		}
		
		void ButtonShowLicClick(object sender, EventArgs e){
			if(System.IO.File.Exists(FILE_LIC) || System.IO.Directory.Exists(FILE_LIC)){
				ProcessStartInfo info = new ProcessStartInfo() ;
				info.FileName = FILE_VIEWER ;
				info.Arguments = FILE_LIC ;
				try{
					Process.Start(info) ;
				}catch(Exception exc){
					MessageBox.Show(exc.Message, MSG_TITLE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error) ;				
				}
			}else{
				if(MessageBox.Show(MSG_FILENOTFOUND, MSG_TITLE_ERROR, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes){
					try{
						Process.Start(URL_LIC) ;
					}catch(Exception exc){
						MessageBox.Show(exc.Message, MSG_TITLE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error) ;				
					}
				}
			}
		}
	}
}
