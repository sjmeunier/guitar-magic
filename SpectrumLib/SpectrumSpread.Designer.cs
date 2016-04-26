namespace SpectrumLib
{
    partial class SpectrumSpread
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picSpectrum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSpectrum)).BeginInit();
            this.SuspendLayout();
            // 
            // picSpectrum
            // 
            this.picSpectrum.BackColor = System.Drawing.Color.White;
            this.picSpectrum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSpectrum.Location = new System.Drawing.Point(0, 0);
            this.picSpectrum.Name = "picSpectrum";
            this.picSpectrum.Size = new System.Drawing.Size(604, 204);
            this.picSpectrum.TabIndex = 1;
            this.picSpectrum.TabStop = false;
            // 
            // SpectrumSpread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picSpectrum);
            this.Name = "SpectrumSpread";
            this.Size = new System.Drawing.Size(604, 204);
            this.Load += new System.EventHandler(this.SpectrumSpread_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSpectrum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSpectrum;
    }
}
