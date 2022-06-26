using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cammov.Windows
{
    public partial class CameraForm : Form
    {
        public CameraForm()
        {
            InitializeComponent();
        }

        private void CameraForm_Load(object sender, EventArgs e)
        {
            Task.Run(StartStreaming);
        }

        private Task StartStreaming()
        {
            while (Enabled)
            {
                cameraPictureBox.Image = App.Scanner.TakeImage();
            }

            return Task.CompletedTask;
        }
    }
}
