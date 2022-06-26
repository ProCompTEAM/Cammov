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
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraPictureBox
            // 
            this.cameraPictureBox.Location = new System.Drawing.Point(12, 12);
            this.cameraPictureBox.Name = "cameraPictureBox";
            this.cameraPictureBox.Size = new System.Drawing.Size(253, 186);
            this.cameraPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraPictureBox.TabIndex = 1;
            this.cameraPictureBox.TabStop = false;
            // 
            // cameraCheckBox
            // 
            this.cameraCheckBox.AutoSize = true;
            this.cameraCheckBox.Location = new System.Drawing.Point(279, 179);
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
            this.cameraButton.Size = new System.Drawing.Size(132, 30);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 210);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cameraPictureBox;
        private System.Windows.Forms.CheckBox cameraCheckBox;
        private System.Windows.Forms.Button cameraButton;
        private System.Windows.Forms.TrackBar sensitivityTrackBar;
        private System.Windows.Forms.Label sensitivityLabel;
    }
}