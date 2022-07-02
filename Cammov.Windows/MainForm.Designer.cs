namespace Cammov.Windows
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cameraPictureBox = new System.Windows.Forms.PictureBox();
            this.cameraCheckBox = new System.Windows.Forms.CheckBox();
            this.cameraButton = new System.Windows.Forms.Button();
            this.sensitivityTrackBar = new System.Windows.Forms.TrackBar();
            this.sensitivityLabel = new System.Windows.Forms.Label();
            this.separationPanel = new System.Windows.Forms.Panel();
            this.goButton = new System.Windows.Forms.Button();
            this.calibrationLabel = new System.Windows.Forms.Label();
            this.calibrationTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibrationTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraPictureBox
            // 
            this.cameraPictureBox.Location = new System.Drawing.Point(12, 12);
            this.cameraPictureBox.Name = "cameraPictureBox";
            this.cameraPictureBox.Size = new System.Drawing.Size(252, 186);
            this.cameraPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraPictureBox.TabIndex = 1;
            this.cameraPictureBox.TabStop = false;
            this.cameraPictureBox.Click += new System.EventHandler(this.cameraPictureBox_Click);
            // 
            // cameraCheckBox
            // 
            this.cameraCheckBox.AutoSize = true;
            this.cameraCheckBox.Location = new System.Drawing.Point(279, 183);
            this.cameraCheckBox.Name = "cameraCheckBox";
            this.cameraCheckBox.Size = new System.Drawing.Size(123, 19);
            this.cameraCheckBox.TabIndex = 3;
            this.cameraCheckBox.Text = "Camera streaming";
            this.cameraCheckBox.UseVisualStyleBackColor = true;
            this.cameraCheckBox.CheckedChanged += new System.EventHandler(this.cameraCheckBox_CheckedChanged);
            // 
            // cameraButton
            // 
            this.cameraButton.Location = new System.Drawing.Point(271, 12);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(85, 30);
            this.cameraButton.TabIndex = 5;
            this.cameraButton.Text = "Camera View";
            this.cameraButton.UseVisualStyleBackColor = true;
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            // 
            // sensitivityTrackBar
            // 
            this.sensitivityTrackBar.LargeChange = 16;
            this.sensitivityTrackBar.Location = new System.Drawing.Point(271, 73);
            this.sensitivityTrackBar.Maximum = 256;
            this.sensitivityTrackBar.Minimum = 1;
            this.sensitivityTrackBar.Name = "sensitivityTrackBar";
            this.sensitivityTrackBar.Size = new System.Drawing.Size(131, 45);
            this.sensitivityTrackBar.TabIndex = 7;
            this.sensitivityTrackBar.Value = 128;
            this.sensitivityTrackBar.Scroll += new System.EventHandler(this.sensitivityTrackBar_Scroll);
            // 
            // sensitivityLabel
            // 
            this.sensitivityLabel.AutoSize = true;
            this.sensitivityLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sensitivityLabel.Location = new System.Drawing.Point(271, 55);
            this.sensitivityLabel.Name = "sensitivityLabel";
            this.sensitivityLabel.Size = new System.Drawing.Size(109, 15);
            this.sensitivityLabel.TabIndex = 9;
            this.sensitivityLabel.Text = "Sensitivity (1 - 256):";
            this.sensitivityLabel.Click += new System.EventHandler(this.sensitivityLabel_Click);
            // 
            // separationPanel
            // 
            this.separationPanel.BackColor = System.Drawing.Color.Red;
            this.separationPanel.ForeColor = System.Drawing.Color.Red;
            this.separationPanel.Location = new System.Drawing.Point(136, 12);
            this.separationPanel.Name = "separationPanel";
            this.separationPanel.Size = new System.Drawing.Size(1, 186);
            this.separationPanel.TabIndex = 11;
            this.separationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.separationPanel_Paint);
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goButton.ForeColor = System.Drawing.Color.Blue;
            this.goButton.Location = new System.Drawing.Point(362, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(41, 30);
            this.goButton.TabIndex = 12;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // calibrationLabel
            // 
            this.calibrationLabel.AutoSize = true;
            this.calibrationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calibrationLabel.Location = new System.Drawing.Point(271, 117);
            this.calibrationLabel.Name = "calibrationLabel";
            this.calibrationLabel.Size = new System.Drawing.Size(108, 15);
            this.calibrationLabel.TabIndex = 13;
            this.calibrationLabel.Text = "Calibration (1 - 2048):";
            this.calibrationLabel.Click += new System.EventHandler(this.calibrationLabel_Click);
            // 
            // calibrationTrackBar
            // 
            this.calibrationTrackBar.Location = new System.Drawing.Point(270, 135);
            this.calibrationTrackBar.Maximum = 2048;
            this.calibrationTrackBar.Minimum = 1;
            this.calibrationTrackBar.Name = "calibrationTrackBar";
            this.calibrationTrackBar.Size = new System.Drawing.Size(131, 45);
            this.calibrationTrackBar.TabIndex = 14;
            this.calibrationTrackBar.Value = 1024;
            this.calibrationTrackBar.Scroll += new System.EventHandler(this.calibrationTrackBar_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 210);
            this.Controls.Add(this.calibrationTrackBar);
            this.Controls.Add(this.calibrationLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.separationPanel);
            this.Controls.Add(this.sensitivityLabel);
            this.Controls.Add(this.sensitivityTrackBar);
            this.Controls.Add(this.cameraButton);
            this.Controls.Add(this.cameraCheckBox);
            this.Controls.Add(this.cameraPictureBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Cammov - Movement scanner for Windows";
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibrationTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cameraPictureBox;
        private System.Windows.Forms.CheckBox cameraCheckBox;
        private System.Windows.Forms.Button cameraButton;
        private System.Windows.Forms.TrackBar sensitivityTrackBar;
        private System.Windows.Forms.Label sensitivityLabel;
        private System.Windows.Forms.Panel separationPanel;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label calibrationLabel;
        private System.Windows.Forms.TrackBar calibrationTrackBar;
    }
}