namespace Cammov.Windows
{
    partial class GoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.movementPanel = new System.Windows.Forms.Panel();
            this.movementStatusLabel = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.movementPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // movementPanel
            // 
            this.movementPanel.BackColor = System.Drawing.Color.White;
            this.movementPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movementPanel.Controls.Add(this.movementStatusLabel);
            this.movementPanel.Location = new System.Drawing.Point(12, 59);
            this.movementPanel.Name = "movementPanel";
            this.movementPanel.Size = new System.Drawing.Size(380, 85);
            this.movementPanel.TabIndex = 1;
            // 
            // movementStatusLabel
            // 
            this.movementStatusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movementStatusLabel.Location = new System.Drawing.Point(3, 10);
            this.movementStatusLabel.Name = "movementStatusLabel";
            this.movementStatusLabel.Size = new System.Drawing.Size(370, 61);
            this.movementStatusLabel.TabIndex = 1;
            this.movementStatusLabel.Text = "...";
            this.movementStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(12, 12);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(380, 35);
            this.scanButton.TabIndex = 3;
            this.scanButton.Text = "Try to scan / Stop scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // GoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 333);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.movementPanel);
            this.Name = "GoForm";
            this.Text = "GO - Try to scan your movement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoForm_FormClosing);
            this.Load += new System.EventHandler(this.GoForm_Load);
            this.movementPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel movementPanel;
        private System.Windows.Forms.Label movementStatusLabel;
        private System.Windows.Forms.Button scanButton;
    }
}