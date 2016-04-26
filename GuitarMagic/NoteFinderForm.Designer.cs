namespace GuitarMagic
{
    partial class NoteFinderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteFinderForm));
            this.cmdClose = new System.Windows.Forms.Button();
            this.txtS3 = new System.Windows.Forms.Label();
            this.txtS4 = new System.Windows.Forms.Label();
            this.txtS5 = new System.Windows.Forms.Label();
            this.txtS6 = new System.Windows.Forms.Label();
            this.txtS2 = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.Label();
            this.cboTuning = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdFind = new System.Windows.Forms.Button();
            this.cboScale = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIntervals = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRoot = new System.Windows.Forms.ComboBox();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.fretBoard1 = new GuitarMagic.FretBoard();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(722, 290);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(69, 28);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // txtS3
            // 
            this.txtS3.Location = new System.Drawing.Point(26, 201);
            this.txtS3.Name = "txtS3";
            this.txtS3.Size = new System.Drawing.Size(20, 13);
            this.txtS3.TabIndex = 26;
            this.txtS3.Text = "E";
            this.txtS3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtS4
            // 
            this.txtS4.Location = new System.Drawing.Point(26, 218);
            this.txtS4.Name = "txtS4";
            this.txtS4.Size = new System.Drawing.Size(20, 13);
            this.txtS4.TabIndex = 25;
            this.txtS4.Text = "E";
            this.txtS4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtS5
            // 
            this.txtS5.Location = new System.Drawing.Point(26, 234);
            this.txtS5.Name = "txtS5";
            this.txtS5.Size = new System.Drawing.Size(20, 13);
            this.txtS5.TabIndex = 24;
            this.txtS5.Text = "E";
            this.txtS5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtS6
            // 
            this.txtS6.Location = new System.Drawing.Point(26, 252);
            this.txtS6.Name = "txtS6";
            this.txtS6.Size = new System.Drawing.Size(20, 13);
            this.txtS6.TabIndex = 23;
            this.txtS6.Text = "E";
            this.txtS6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(26, 183);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(20, 13);
            this.txtS2.TabIndex = 22;
            this.txtS2.Text = "E";
            this.txtS2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(26, 164);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(20, 13);
            this.txtS1.TabIndex = 21;
            this.txtS1.Text = "E";
            this.txtS1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboTuning
            // 
            this.cboTuning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuning.FormattingEnabled = true;
            this.cboTuning.Location = new System.Drawing.Point(429, 9);
            this.cboTuning.Name = "cboTuning";
            this.cboTuning.Size = new System.Drawing.Size(139, 21);
            this.cboTuning.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tuning:";
            // 
            // cmdFind
            // 
            this.cmdFind.Location = new System.Drawing.Point(722, 9);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(69, 28);
            this.cmdFind.TabIndex = 3;
            this.cmdFind.Text = "&Find";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // cboScale
            // 
            this.cboScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScale.FormattingEnabled = true;
            this.cboScale.Location = new System.Drawing.Point(170, 9);
            this.cboScale.Name = "cboScale";
            this.cboScale.Size = new System.Drawing.Size(193, 21);
            this.cboScale.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Scale:";
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(74, 64);
            this.txtScale.Name = "txtScale";
            this.txtScale.ReadOnly = true;
            this.txtScale.Size = new System.Drawing.Size(341, 20);
            this.txtScale.TabIndex = 42;
            this.txtScale.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Scale:";
            // 
            // txtIntervals
            // 
            this.txtIntervals.Location = new System.Drawing.Point(74, 122);
            this.txtIntervals.Name = "txtIntervals";
            this.txtIntervals.ReadOnly = true;
            this.txtIntervals.Size = new System.Drawing.Size(685, 20);
            this.txtIntervals.TabIndex = 40;
            this.txtIntervals.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(74, 95);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(685, 20);
            this.txtNotes.TabIndex = 39;
            this.txtNotes.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Intervals:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Notes:";
            // 
            // cboRoot
            // 
            this.cboRoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoot.FormattingEnabled = true;
            this.cboRoot.Location = new System.Drawing.Point(74, 9);
            this.cboRoot.Name = "cboRoot";
            this.cboRoot.Size = new System.Drawing.Size(84, 21);
            this.cboRoot.TabIndex = 0;
            // 
            // cmdPlay
            // 
            this.cmdPlay.Enabled = false;
            this.cmdPlay.Image = ((System.Drawing.Image)(resources.GetObject("cmdPlay.Image")));
            this.cmdPlay.Location = new System.Drawing.Point(766, 98);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(25, 25);
            this.cmdPlay.TabIndex = 4;
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // timerPlay
            // 
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // fretBoard1
            // 
            this.fretBoard1.Location = new System.Drawing.Point(48, 164);
            this.fretBoard1.Name = "fretBoard1";
            this.fretBoard1.Size = new System.Drawing.Size(743, 105);
            this.fretBoard1.TabIndex = 20;
            this.fretBoard1.TabStop = false;
            // 
            // NoteFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 329);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.cboRoot);
            this.Controls.Add(this.txtScale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIntervals);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTuning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdFind);
            this.Controls.Add(this.cboScale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtS3);
            this.Controls.Add(this.txtS4);
            this.Controls.Add(this.txtS5);
            this.Controls.Add(this.txtS6);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.fretBoard1);
            this.Controls.Add(this.cmdClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteFinderForm";
            this.Text = "Note Finder";
            this.Load += new System.EventHandler(this.ScaleFinderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label txtS3;
        private System.Windows.Forms.Label txtS4;
        private System.Windows.Forms.Label txtS5;
        private System.Windows.Forms.Label txtS6;
        private System.Windows.Forms.Label txtS2;
        private System.Windows.Forms.Label txtS1;
        private FretBoard fretBoard1;
        private System.Windows.Forms.ComboBox cboTuning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.ComboBox cboScale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIntervals;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboRoot;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.Timer timerPlay;
    }
}