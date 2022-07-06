/* Morpheus: BitmapUtils Class
 * (c) 2022, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/> 
 */
 
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Morpheus{
	/// <summary>
	/// Image manipulation functions
	/// </summary>
	public static class BitmapUtils{
		public enum ResizeBypass{
			NoBypass,
			InSmallerOrigin,
			InBiggerOrigin
		}
		
		public static Bitmap Resize(Bitmap originBmp, int destWidth, int destHeight){
		    Rectangle rect = new Rectangle(0, 0, destWidth, destHeight);
		    
		    Bitmap resizedBmp = new Bitmap(destWidth, destHeight);
		    resizedBmp.SetResolution(originBmp.HorizontalResolution, originBmp.VerticalResolution);
		
		    Graphics grfx = Graphics.FromImage(resizedBmp) ;
	        grfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
	        grfx.SmoothingMode = SmoothingMode.HighQuality;
	        grfx.CompositingQuality = CompositingQuality.HighQuality;
	        grfx.CompositingMode = CompositingMode.SourceCopy;
	        grfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

		    ImageAttributes wrapMode = new ImageAttributes() ;
		    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
		    
		    grfx.DrawImage(originBmp, new Rectangle(0, 0, destWidth, destHeight), 0, 0, originBmp.Width, originBmp.Height, GraphicsUnit.Pixel, wrapMode);
		    originBmp.Dispose() ;
		    grfx.Dispose() ;
		    return resizedBmp;
		}
		
		public static Bitmap ResizeByHeight(Bitmap originBmp, int destHeight, ResizeBypass bypass){
			if((bypass == ResizeBypass.InSmallerOrigin && originBmp.Width <= destHeight) || (bypass == ResizeBypass.InBiggerOrigin && originBmp.Width >= destHeight)){
				return originBmp ;
			}
			
			double destWidth = ((double)destHeight / (double)originBmp.Height) * (double)originBmp.Width ;
			return Resize(originBmp, (int)destWidth, destHeight) ;
		}
		
		public static Bitmap ResizeByHeight(Bitmap originBmp, int destHeight){
			return ResizeByHeight(originBmp, destHeight, ResizeBypass.NoBypass) ;
		}
		
		public static Bitmap ResizeByWidth(Bitmap originBmp, int destWidth, ResizeBypass bypass){
			if((bypass == ResizeBypass.InSmallerOrigin && originBmp.Height <= destWidth) || (bypass == ResizeBypass.InBiggerOrigin && originBmp.Height >= destWidth)){
				return originBmp ;
			}
			
			double destHeight = ((double)destWidth / (double)originBmp.Width) * (double)originBmp.Height ;
			return Resize(originBmp, destWidth, (int)destHeight) ;
		}
		
		public static Bitmap ResizeByWidth(Bitmap originBmp, int destWidth){
			return ResizeByWidth(originBmp, destWidth, ResizeBypass.NoBypass) ;
		}
		
		public static Bitmap ResizeByLargerDimension(Bitmap originBmp, int maxDimension, ResizeBypass bypass){
			if(originBmp.Width > originBmp.Height)
				return ResizeByWidth(originBmp, maxDimension, bypass) ;
			else
				return ResizeByHeight(originBmp, maxDimension, bypass) ;
		}
		
		public static Bitmap ResizeByLargerDimension(Bitmap originBmp, int maxDimension){
			return ResizeByLargerDimension(originBmp, maxDimension, ResizeBypass.NoBypass) ;
		}
		
		 public static Bitmap ToGrayscale(Bitmap originBmp){
			Bitmap bmp = new Bitmap(originBmp) ;
            Color c;
            for (int i = 0; i < bmp.Width; i++){
                for (int j = 0; j < bmp.Height; j++){
                    c = bmp.GetPixel(i, j);
                    byte g = (byte)((0.299 * c.R) + (0.587 * c.G) + (0.114 * c.B));
                    bmp.SetPixel(i, j, Color.FromArgb(g, g, g));
                }
            }
            return bmp ;
		}
		
		public static Bitmap ToMonochrome(Bitmap originBmp){
			Bitmap bmp = new Bitmap(originBmp) ;
            Color c;
            for (int i = 0; i < bmp.Width; i++){
                for (int j = 0; j < bmp.Height; j++){
                    c = bmp.GetPixel(i, j);
                    byte avg = (byte)((c.R + c.G + c.B)/3);
                    avg = avg > 150 ? (byte)255 : (byte)0 ;
                   	bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp ;     
		}
		
		public static Bitmap ToSepia(Bitmap originBmp){
			Bitmap bmp = new Bitmap(originBmp) ;
            Color c;
            
            for (int i = 0; i < bmp.Width; i++){
                for (int j = 0; j < bmp.Height; j++){
                    c = bmp.GetPixel(i, j);
                    byte r = MathUtils.CByte((int)(0.393 * c.R + 0.769 * c.G + 0.189 * c.B));
                    byte g = MathUtils.CByte((int)(0.349 * c.R + 0.686 * c.G + 0.168 * c.B));
                    byte b = MathUtils.CByte((int)(0.272 * c.R + 0.534 * c.G + 0.131 * c.B));
                    bmp.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
		    return bmp ;
		}
		
		public static Bitmap ToNegative(Bitmap originBmp){
			Bitmap bmp = new Bitmap(originBmp) ;
            Color c;
            
            for (int i = 0; i < bmp.Width; i++){
                for (int j = 0; j < bmp.Height; j++){
                    c = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j, Color.FromArgb(255-c.R, 255-c.G, 255-c.B));
                }
            }
		    return bmp ;
		}
	}
}
