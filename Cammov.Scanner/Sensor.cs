using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace Cammov.Scanner
{
    public class Sensor
    {
        public byte ZeroOffset { get; set; } = 0x00;

        public byte FillOffset { get; set; } = 0xFF;

        public byte Sensitivity { get; set; } = 128;

        public int Calibration { get; set; } = 10;

        private readonly VideoCapture capture;

        public Sensor()
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

        public long[] TakeMonoLeftRightSummary()
        {
            return GetMonoLeftRightSummary(capture.QueryFrame().ToImage<Bgr, byte>().ToBitmap());
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

        private long[] GetMonoLeftRightSummary(Bitmap bitmap)
        {
            long[] summary = new long[2];

            summary[0] = GetMonoSummary(bitmap, 0, 0, bitmap.Width / 2, bitmap.Height / 2);
            summary[1] = GetMonoSummary(bitmap, bitmap.Width / 2, bitmap.Height / 2, bitmap.Width, bitmap.Height);

            return summary;
        }

        private long GetMonoSummary(Bitmap bitmap, int indexX, int indexY, int endX, int endY)
        {
            Color pixel;
            long summary = 0;

            for(indexX = 0; indexX < endX; indexX++)
            {
                for(indexY = 0; indexY < endY; indexY++)
                {
                    pixel = bitmap.GetPixel(indexX, indexY);
                    
                    if(pixel.R > Sensitivity || pixel.G > Sensitivity || pixel.B > Sensitivity)
                    {
                        summary++;
                    }
                }
            }

            return summary / Calibration;
        }
    }
}