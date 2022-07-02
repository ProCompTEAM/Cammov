using Cammov.Scanner.Controllers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cammov.Windows
{
    public partial class GoForm : Form
    {
        private bool InScanning;

        private MovementController movementController;

        public GoForm()
        {
            InitializeComponent();
        }

        private void GoForm_Load(object sender, EventArgs e)
        {
            movementController = new MovementController(App.Scanner);

            movementController.OnMovement = OnMovement;
            movementController.OnJump = OnJump;
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            if(InScanning || movementController.Enabled)
            {
                StopScanning();
            }
            else
            {
                StartScanning();
            }
        }

        private Task SetupOnScreen()
        {
            while (InScanning)
            {
                movementStatusLabel.Invoke(
                    () => movementStatusLabel.Text = $"{movementController.ScannedAction} - {movementController.LastLeftSummary} : {movementController.LastRightSummary}");
            }

            return Task.CompletedTask;
        }

        private void OnMovement()
        {
        }

        private void OnJump()
        {
            Console.Beep();
        }

        private void GoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopScanning();
        }

        private void StartScanning()
        {
            InScanning = true;
            movementController.Enabled = true;

            Task.Run(movementController.TryToScan);
            Task.Run(SetupOnScreen);
        }

        private void StopScanning()
        {
            InScanning = false;
            movementController.Enabled = false;
        }
    }
}
