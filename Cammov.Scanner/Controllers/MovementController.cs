using Cammov.Scanner.Enums;
using System;
using System.Threading.Tasks;

namespace Cammov.Scanner.Controllers
{
    public class MovementController
    {
        public bool Enabled { get; set; }

        public long Tolerance { get; set; } = 10;

        public Action OnMovement { get; set; }

        public Action OnJump { get; set; }

        public ScannedMovementAction ScannedAction { get; private set; } = ScannedMovementAction.Inaction;

        public long LastLeftSummary { get; private set; } = 0;

        public long LastRightSummary { get; private set; } = 0;

        private Sensor scanner;

        public MovementController(Sensor scanner)
        {
            this.scanner = scanner;
        }

        public Task TryToScan()
        {
            while(Enabled)
            {
                var summaryResult = scanner.TakeMonoLeftRightSummary();

                ScanActivity(summaryResult[0] / Tolerance, summaryResult[1] / Tolerance);
            }

            return Task.CompletedTask;
        }

        private void ScanActivity(long leftSummary, long rightSummary)
        {
            if (rightSummary != LastRightSummary)
            {
                if (leftSummary != LastLeftSummary)
                {
                    Complete(OnJump);

                    ScannedAction = ScannedMovementAction.Jump;
                }
                else
                {
                    Complete(OnMovement);

                    ScannedAction = ScannedMovementAction.Movement;
                }
            }
            else
            {
                ScannedAction = ScannedMovementAction.Inaction;
            }

            LastLeftSummary = leftSummary;
            LastRightSummary = rightSummary;
        }

        private void Complete(Action action)
        {
            if(action != null)
            {
                action();
            }
        }
    }
}
