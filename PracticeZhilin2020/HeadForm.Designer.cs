namespace PracticeZhilin2020
{
    partial class HeadForm
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
            this.AutorizatePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AutorizatePanel
            // 
            this.AutorizatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutorizatePanel.Location = new System.Drawing.Point(0, 0);
            this.AutorizatePanel.Name = "AutorizatePanel";
            this.AutorizatePanel.Size = new System.Drawing.Size(800, 100);
            this.AutorizatePanel.TabIndex = 0;
            // 
            // HeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AutorizatePanel);
            this.Name = "HeadForm";
            this.Text = "HeadForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AutorizatePanel;
    }
}