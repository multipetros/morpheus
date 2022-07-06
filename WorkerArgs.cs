/* Morpheus: WorkerArgs Class
 * (c) 2022, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/> 
 */
 
using System ;
using System.Windows.Forms ;

namespace Morpheus{
	/// <summary>
	/// Service worker arguments
	/// </summary>
	public class WorkerArgs{		
		protected string outputFormat ;
		protected string outputFilter ;
		protected string[] files ;
		
		public WorkerArgs(){}
		
		public WorkerArgs(string[] files, string ouputFormat, string outputFilter){
			Files = files ;
			OutputFormat = ouputFormat ;
			OutputFilter = outputFilter ;
		}
		
		public WorkerArgs(System.Windows.Forms.ListView.ListViewItemCollection listViewItems, string outputFormat, string outputFilter){
			OutputFormat = outputFormat ;
			OutputFilter = outputFilter ;
			this.files = new string[listViewItems.Count] ;
			int i = 0 ;
			foreach(System.Windows.Forms.ListViewItem lvi in listViewItems){
				this.files[i++] = lvi.SubItems[0].Text ;
			}
		}
		
		public string OutputFormat{
			get{ return this.outputFormat ; }
			set{ this.outputFormat = value ; }
		}
		
		public string OutputFilter{
			get{ return this.outputFilter ; }
			set{ this.outputFilter = value ; }
		}
		
		public string[] Files{
			get{ return this.files ; }
			set{ this.files = value ; }
		}
	}
}
