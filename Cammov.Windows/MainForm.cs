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
                cameraPictureBox.Image = App.Scanner.TakeMonoImage();
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

        private void cameraButton_Click(object sender, System.EventArgs e)
        {
            cameraCheckBox.Checked = false;

            new CameraForm().ShowDialog();
        }

        private void sensitivityTrackBar_Scroll(object sender, System.EventArgs e)
        {
            UpdateSensitivity(sensitivityTrackBar.Value);
        }

        private void sensitivityLabel_Click(object sender, System.EventArgs e)
        {
            sensitivityTrackBar.Value = sensitivityTrackBar.Maximum / 2;
            UpdateSensitivity(sensitivityTrackBar.Value);
        }

        private void UpdateSensitivity(int sensitivity)
        {
            App.Scanner.Sensitivity = (byte)(256 - sensitivity);
        }

        private void separationPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cameraPictureBox_Click(object sender, System.EventArgs e)
        {
        }
    }
}