using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace Cammov.Scanner
{
    public class Scanner
    {
        private readonly VideoCapture capture;

        public Scanner()
        {
            capture = new VideoCapture();
        }

        public Image TakeImage()
        {
             return capture.QueryFrame().ToImage<Bgr, byte>().ToBitmap();
        }
    }
}