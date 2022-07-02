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

        private void calibrationTrackBar_Scroll(object sender, System.EventArgs e)
        {
            UpdateCalibration(calibrationTrackBar.Value);
        }

        private void calibrationLabel_Click(object sender, System.EventArgs e)
        {
            calibrationTrackBar.Value = calibrationTrackBar.Maximum / 2;
            UpdateCalibration(calibrationTrackBar.Value);
        }

        private void UpdateCalibration(int calibration)
        {
            App.Scanner.Calibration = calibration;
        }

        private void separationPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cameraPictureBox_Click(object sender, System.EventArgs e)
        {
            ReverseCameraColors();
        }

        private void ReverseCameraColors()
        {
            var fillOffset = App.Scanner.ZeroOffset;
            var zeroOffset = App.Scanner.FillOffset;

            App.Scanner.ZeroOffset = zeroOffset;
            App.Scanner.FillOffset = fillOffset;
        }

        private void goButton_Click(object sender, System.EventArgs e)
        {
            StartGoMode();
        }

        private void StartGoMode()
        {
            new GoForm().ShowDialog();
        }
    }
}