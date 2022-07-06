/* Morpheus: MathUtils Class
 * (c) 2022, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/> 
 */
 
using System;

namespace Morpheus{
	/// <summary>
	/// Math based functions
	/// </summary>
	public static class MathUtils{		
		public static string BytesToString(long bytes){
			string[] suffixes = {"B", "KB", "MB", "GB", "TB", "PB", "EB"};
			int pos = 0;
			double size = bytes ;
			while (size >= 1024 && pos < suffixes.Length - 1) {
			    pos++;
			    size/=1024;
			}
			return String.Format("{0:0.##} {1}", size, suffixes[pos]);
		}
		
		public static byte CByte(int num){
			return (num > byte.MaxValue) ? byte.MaxValue : ((num < byte.MinValue) ? byte.MinValue : (byte)num) ;
		}
		
	}
}
