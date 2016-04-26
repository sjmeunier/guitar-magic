namespace GuitarMagic
{
    partial class SpectralAnalyzerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpectralAnalyzerForm));
            this.cmdClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oscilloscope1 = new SpectrumLib.Oscilloscope();
            this.spectrumSpread1 = new SpectrumLib.SpectrumSpread();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(612, 480);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(69, 28);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Oscilloscope";
            // 
            // oscilloscope1
            // 
            this.oscilloscope1.Location = new System.Drawing.Point(16, 25);
            this.oscilloscope1.Name = "oscilloscope1";
            this.oscilloscope1.Size = new System.Drawing.Size(665, 195);
            this.oscilloscope1.TabIndex = 16;
            this.oscilloscope1.TabStop = false;
            // 
            // spectrumSpread1
            // 
            this.spectrumSpread1.Location = new System.Drawing.Point(17, 246);
            this.spectrumSpread1.Name = "spectrumSpread1";
            this.spectrumSpread1.Size = new System.Drawing.Size(664, 216);
            this.spectrumSpread1.TabIndex = 17;
            this.spectrumSpread1.TabStop = false;
            this.spectrumSpread1.Load += new System.EventHandler(this.spectrumSpread1_Load);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(462, 480);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(69, 28);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "&Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(537, 480);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(69, 28);
            this.cmdStop.TabIndex = 1;
            this.cmdStop.Text = "S&top";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // SpectralAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 520);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.spectrumSpread1);
            this.Controls.Add(this.oscilloscope1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpectralAnalyzerForm";
            this.Text = "Spectral Analyser";
            this.Load += new System.EventHandler(this.SpectralAnalyserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label label1;
        private SpectrumLib.Oscilloscope oscilloscope1;
        private SpectrumLib.SpectrumSpread spectrumSpread1;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdStop;
    }
}