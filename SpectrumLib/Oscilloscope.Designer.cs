namespace SpectrumLib
{
    partial class Oscilloscope
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
            this.picScope = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picScope)).BeginInit();
            this.SuspendLayout();
            // 
            // picScope
            // 
            this.picScope.BackColor = System.Drawing.Color.White;
            this.picScope.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picScope.Location = new System.Drawing.Point(0, 0);
            this.picScope.Name = "picScope";
            this.picScope.Size = new System.Drawing.Size(605, 204);
            this.picScope.TabIndex = 0;
            this.picScope.TabStop = false;
            // 
            // Oscilloscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picScope);
            this.Name = "Oscilloscope";
            this.Size = new System.Drawing.Size(605, 204);
            this.Load += new System.EventHandler(this.Oscilloscope_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picScope)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picScope;
    }
}
