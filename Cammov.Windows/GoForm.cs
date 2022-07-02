using Cammov.Scanner.Controllers;
using Cammov.Scanner.Enums;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Cammov.Windows
{
    public partial class GoForm : Form
    {
        private bool InScanning;

        private MovementController movementController;

        private InputSimulator inputSimulator = new InputSimulator();

        public GoForm()
        {
            InitializeComponent();
        }

        private void GoForm_Load(object sender, EventArgs e)
        {
            movementController = new MovementController(App.Scanner);

            movementController.OnInaction = OnInaction;
            movementController.OnMovement = OnMovement;
            movementController.OnJump = OnJump;

            StartScanning();
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

        private void OnInaction()
        {
            inputSimulator.Keyboard.KeyUp(VirtualKeyCode.ACCEPT);
        }

        private void OnMovement()
        {
            InputKey(VirtualKeyCode.VK_W);
        }

        private void OnJump()
        {
            InputKey(VirtualKeyCode.SPACE);
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

        private void InputKey(VirtualKeyCode keyCode)
        {
            Task.Run(() =>
                inputSimulator.Keyboard
                    .KeyDown(keyCode)
                    .Sleep(300)
                    .KeyUp(keyCode));
        }

        private void movementStatusLabel_Click(object sender, EventArgs e)
        {
            TopMost = true;

            Text += "-> Locked";
        }
    }
}
