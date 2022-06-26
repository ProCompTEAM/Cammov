using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace Cammov.Scanner
{
    public class Scanner
    {
        private const byte ZeroOffset = 0x00;
        private const byte FillOffset = 0xFF;

        public byte Sensitivity { get; set; } = 128;

        public byte Calibration { get; set; } = 10;

        private readonly VideoCapture capture;

        public Scanner()
        {
            capture = new VideoCapture();
        }

        public Image TakeImage()
        {
             return capture.QueryFrame().ToImage<Bgr, byte>().ToBitmap();
        }

        public Image TakeMonoImage()
        {
            return GetMonoImage(capture.QueryFrame().ToImage<Bgr, byte>().ToBitmap());
        }

        private Bitmap GetMonoImage(Bitmap bitmap)
        {
            int indexX, indexY;
            Color pixel;

            for(indexX = 0; indexX < bitmap.Width; indexX++)
            {
                for(indexY = 0; indexY < bitmap.Height; indexY++)
                {
                    pixel = bitmap.GetPixel(indexX, indexY);
                    
                    if(pixel.R > Sensitivity || pixel.G > Sensitivity || pixel.B > Sensitivity)
                    {
                        bitmap.SetPixel(indexX, indexY, Color.FromArgb(FillOffset, FillOffset, FillOffset));
                    }
                    else
                    {
                        bitmap.SetPixel(indexX, indexY, Color.FromArgb(ZeroOffset, ZeroOffset, ZeroOffset));
                    }
                }
            }

            return bitmap;
        }
    }
}