using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cammov.Windows
{
    public partial class MainForm : Form
    {
        private bool AutoReloadImageEnabled = false;

        public MainForm()
        {
            InitializeComponent();

            cameraCheckBox.Checked = true;
        }

        private Task StartAutoReloadImage()
        {
            while (AutoReloadImageEnabled)
            {
                cameraPictureBox.Image = App.Scanner.TakeImage();
            }

            return Task.CompletedTask;
        }

        private void cameraCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            AutoReloadImageEnabled = !AutoReloadImageEnabled;

            if (AutoReloadImageEnabled)
            {
                Task.Run(StartAutoReloadImage);
            }
        }
    }
}