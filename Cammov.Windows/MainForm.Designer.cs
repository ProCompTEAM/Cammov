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
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).BeginInit();
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
            this.cameraCheckBox.Size = new System.Drawing.Size(129, 19);
            this.cameraCheckBox.TabIndex = 3;
            this.cameraCheckBox.Text = "Camera Hot Reload";
            this.cameraCheckBox.UseVisualStyleBackColor = true;
            this.cameraCheckBox.CheckedChanged += new System.EventHandler(this.cameraCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 210);
            this.Controls.Add(this.cameraCheckBox);
            this.Controls.Add(this.cameraPictureBox);
            this.Name = "MainForm";
            this.Text = "Cammov - Movement scanner for Windows";
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cameraPictureBox;
        private System.Windows.Forms.CheckBox cameraCheckBox;
    }
}