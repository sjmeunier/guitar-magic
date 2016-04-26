namespace GuitarMagic
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frequencyTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervalFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chordChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metronomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transposerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chordFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tunerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spectralAnalyzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chordChartToolStripMenuItem,
            this.chordFinderToolStripMenuItem,
            this.intervalFinderToolStripMenuItem,
            this.frequencyTableToolStripMenuItem,
            this.metronomeToolStripMenuItem,
            this.noteToolStripMenuItem,
            this.scaleFinderToolStripMenuItem,
            this.spectralAnalyzerToolStripMenuItem,
            this.transposerToolStripMenuItem,
            this.tunerToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // frequencyTableToolStripMenuItem
            // 
            this.frequencyTableToolStripMenuItem.Name = "frequencyTableToolStripMenuItem";
            this.frequencyTableToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.frequencyTableToolStripMenuItem.Text = "&Frequency Table";
            this.frequencyTableToolStripMenuItem.Click += new System.EventHandler(this.frequencyTableToolStripMenuItem_Click_1);
            // 
            // intervalFinderToolStripMenuItem
            // 
            this.intervalFinderToolStripMenuItem.Name = "intervalFinderToolStripMenuItem";
            this.intervalFinderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.intervalFinderToolStripMenuItem.Text = "&Interval Finder";
            this.intervalFinderToolStripMenuItem.Click += new System.EventHandler(this.intervalFinderToolStripMenuItem_Click);
            // 
            // chordChartToolStripMenuItem
            // 
            this.chordChartToolStripMenuItem.Name = "chordChartToolStripMenuItem";
            this.chordChartToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.chordChartToolStripMenuItem.Text = "&Chord Chart";
            this.chordChartToolStripMenuItem.Click += new System.EventHandler(this.chordChartToolStripMenuItem_Click);
            // 
            // metronomeToolStripMenuItem
            // 
            this.metronomeToolStripMenuItem.Name = "metronomeToolStripMenuItem";
            this.metronomeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.metronomeToolStripMenuItem.Text = "&Metronome";
            this.metronomeToolStripMenuItem.Click += new System.EventHandler(this.metronomeToolStripMenuItem_Click);
            // 
            // scaleFinderToolStripMenuItem
            // 
            this.scaleFinderToolStripMenuItem.Name = "scaleFinderToolStripMenuItem";
            this.scaleFinderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.scaleFinderToolStripMenuItem.Text = "&Scale Finder";
            this.scaleFinderToolStripMenuItem.Click += new System.EventHandler(this.scaleFinderToolStripMenuItem_Click);
            // 
            // transposerToolStripMenuItem
            // 
            this.transposerToolStripMenuItem.Name = "transposerToolStripMenuItem";
            this.transposerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.transposerToolStripMenuItem.Text = "&Transposer";
            this.transposerToolStripMenuItem.Click += new System.EventHandler(this.transposerToolStripMenuItem_Click);
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.noteToolStripMenuItem.Text = "&Note Finder";
            this.noteToolStripMenuItem.Click += new System.EventHandler(this.noteToolStripMenuItem_Click);
            // 
            // chordFinderToolStripMenuItem
            // 
            this.chordFinderToolStripMenuItem.Name = "chordFinderToolStripMenuItem";
            this.chordFinderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.chordFinderToolStripMenuItem.Text = "C&hord Finder";
            this.chordFinderToolStripMenuItem.Click += new System.EventHandler(this.chordFinderToolStripMenuItem_Click);
            // 
            // tunerToolStripMenuItem
            // 
            this.tunerToolStripMenuItem.Name = "tunerToolStripMenuItem";
            this.tunerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tunerToolStripMenuItem.Text = "&Tuner";
            this.tunerToolStripMenuItem.Click += new System.EventHandler(this.tunerToolStripMenuItem_Click);
            // 
            // spectralAnalyzerToolStripMenuItem
            // 
            this.spectralAnalyzerToolStripMenuItem.Name = "spectralAnalyzerToolStripMenuItem";
            this.spectralAnalyzerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.spectralAnalyzerToolStripMenuItem.Text = "&Spectral Analyzer";
            this.spectralAnalyzerToolStripMenuItem.Click += new System.EventHandler(this.spectralAnalyzerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 626);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Guitar Magic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frequencyTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervalFinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chordChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metronomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleFinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transposerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chordFinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tunerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spectralAnalyzerToolStripMenuItem;
    }
}

