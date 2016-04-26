namespace GuitarMagic
{
    partial class ChordChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChordChartForm));
            this.cmdClose = new System.Windows.Forms.Button();
            this.cboRoot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboChordType = new System.Windows.Forms.ComboBox();
            this.cmdFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtIntervals = new System.Windows.Forms.TextBox();
            this.cboTuning = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.Label();
            this.txtS2 = new System.Windows.Forms.Label();
            this.txtS6 = new System.Windows.Forms.Label();
            this.txtS5 = new System.Windows.Forms.Label();
            this.txtS4 = new System.Windows.Forms.Label();
            this.txtS3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFromFret = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboToFret = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboFingerStretch = new System.Windows.Forms.ComboBox();
            this.cmdNext = new System.Windows.Forms.Button();
            this.cmdPrev = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmdLast = new System.Windows.Forms.Button();
            this.cmdFirst = new System.Windows.Forms.Button();
            this.cboGoto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChord = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.fretBoard1 = new GuitarMagic.FretBoard();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(703, 313);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(69, 28);
            this.cmdClose.TabIndex = 13;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cboRoot
            // 
            this.cboRoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoot.FormattingEnabled = true;
            this.cboRoot.Location = new System.Drawing.Point(66, 6);
            this.cboRoot.Name = "cboRoot";
            this.cboRoot.Size = new System.Drawing.Size(84, 21);
            this.cboRoot.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chord:";
            // 
            // cboChordType
            // 
            this.cboChordType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChordType.FormattingEnabled = true;
            this.cboChordType.Location = new System.Drawing.Point(156, 6);
            this.cboChordType.Name = "cboChordType";
            this.cboChordType.Size = new System.Drawing.Size(111, 21);
            this.cboChordType.TabIndex = 1;
            // 
            // cmdFind
            // 
            this.cmdFind.Location = new System.Drawing.Point(703, 6);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(69, 28);
            this.cmdFind.TabIndex = 6;
            this.cmdFind.Text = "&Find";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Notes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Intervals:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(66, 130);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(341, 20);
            this.txtNotes.TabIndex = 9;
            this.txtNotes.TabStop = false;
            // 
            // txtIntervals
            // 
            this.txtIntervals.Location = new System.Drawing.Point(66, 157);
            this.txtIntervals.Name = "txtIntervals";
            this.txtIntervals.ReadOnly = true;
            this.txtIntervals.Size = new System.Drawing.Size(341, 20);
            this.txtIntervals.TabIndex = 10;
            this.txtIntervals.TabStop = false;
            // 
            // cboTuning
            // 
            this.cboTuning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuning.FormattingEnabled = true;
            this.cboTuning.Location = new System.Drawing.Point(333, 6);
            this.cboTuning.Name = "cboTuning";
            this.cboTuning.Size = new System.Drawing.Size(139, 21);
            this.cboTuning.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tuning:";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(7, 201);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(20, 13);
            this.txtS1.TabIndex = 14;
            this.txtS1.Text = "E";
            this.txtS1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(7, 220);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(20, 13);
            this.txtS2.TabIndex = 15;
            this.txtS2.Text = "E";
            this.txtS2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtS6
            // 
            this.txtS6.Location = new System.Drawing.Point(7, 289);
            this.txtS6.Name = "txtS6";
            this.txtS6.Size = new System.Drawing.Size(20, 13);
            this.txtS6.TabIndex = 16;
            this.txtS6.Text = "E";
            this.txtS6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtS5
            // 
            this.txtS5.Location = new System.Drawing.Point(7, 271);
            this.txtS5.Name = "txtS5";
            this.txtS5.Size = new System.Drawing.Size(20, 13);
            this.txtS5.TabIndex = 17;
            this.txtS5.Text = "E";
            this.txtS5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtS4
            // 
            this.txtS4.Location = new System.Drawing.Point(7, 255);
            this.txtS4.Name = "txtS4";
            this.txtS4.Size = new System.Drawing.Size(20, 13);
            this.txtS4.TabIndex = 18;
            this.txtS4.Text = "E";
            this.txtS4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtS3
            // 
            this.txtS3.Location = new System.Drawing.Point(7, 238);
            this.txtS3.Name = "txtS3";
            this.txtS3.Size = new System.Drawing.Size(20, 13);
            this.txtS3.TabIndex = 19;
            this.txtS3.Text = "E";
            this.txtS3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "From Fret:";
            // 
            // cboFromFret
            // 
            this.cboFromFret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFromFret.FormattingEnabled = true;
            this.cboFromFret.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.cboFromFret.Location = new System.Drawing.Point(66, 39);
            this.cboFromFret.Name = "cboFromFret";
            this.cboFromFret.Size = new System.Drawing.Size(42, 21);
            this.cboFromFret.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "To Fret:";
            // 
            // cboToFret
            // 
            this.cboToFret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToFret.FormattingEnabled = true;
            this.cboToFret.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.cboToFret.Location = new System.Drawing.Point(179, 39);
            this.cboToFret.Name = "cboToFret";
            this.cboToFret.Size = new System.Drawing.Size(46, 21);
            this.cboToFret.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Finger Strech:";
            // 
            // cboFingerStretch
            // 
            this.cboFingerStretch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFingerStretch.FormattingEnabled = true;
            this.cboFingerStretch.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboFingerStretch.Location = new System.Drawing.Point(428, 39);
            this.cboFingerStretch.Name = "cboFingerStretch";
            this.cboFingerStretch.Size = new System.Drawing.Size(44, 21);
            this.cboFingerStretch.TabIndex = 5;
            // 
            // cmdNext
            // 
            this.cmdNext.Enabled = false;
            this.cmdNext.Location = new System.Drawing.Point(530, 313);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(69, 28);
            this.cmdNext.TabIndex = 11;
            this.cmdNext.Text = ">>";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // cmdPrev
            // 
            this.cmdPrev.Enabled = false;
            this.cmdPrev.Location = new System.Drawing.Point(455, 313);
            this.cmdPrev.Name = "cmdPrev";
            this.cmdPrev.Size = new System.Drawing.Size(69, 28);
            this.cmdPrev.TabIndex = 10;
            this.cmdPrev.Text = "<<";
            this.cmdPrev.UseVisualStyleBackColor = true;
            this.cmdPrev.Click += new System.EventHandler(this.cmdPrev_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(26, 321);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(162, 13);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "0 records";
            // 
            // cmdLast
            // 
            this.cmdLast.Enabled = false;
            this.cmdLast.Location = new System.Drawing.Point(605, 313);
            this.cmdLast.Name = "cmdLast";
            this.cmdLast.Size = new System.Drawing.Size(69, 28);
            this.cmdLast.TabIndex = 12;
            this.cmdLast.Text = ">|";
            this.cmdLast.UseVisualStyleBackColor = true;
            this.cmdLast.Click += new System.EventHandler(this.cmdLast_Click);
            // 
            // cmdFirst
            // 
            this.cmdFirst.Enabled = false;
            this.cmdFirst.Location = new System.Drawing.Point(380, 313);
            this.cmdFirst.Name = "cmdFirst";
            this.cmdFirst.Size = new System.Drawing.Size(69, 28);
            this.cmdFirst.TabIndex = 9;
            this.cmdFirst.Text = "|<";
            this.cmdFirst.UseVisualStyleBackColor = true;
            this.cmdFirst.Click += new System.EventHandler(this.cmdFirst_Click);
            // 
            // cboGoto
            // 
            this.cboGoto.Enabled = false;
            this.cboGoto.FormattingEnabled = true;
            this.cboGoto.Location = new System.Drawing.Point(292, 318);
            this.cboGoto.Name = "cboGoto";
            this.cboGoto.Size = new System.Drawing.Size(80, 21);
            this.cboGoto.TabIndex = 8;
            this.cboGoto.SelectedIndexChanged += new System.EventHandler(this.cboGoto_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Go To:";
            // 
            // txtChord
            // 
            this.txtChord.Location = new System.Drawing.Point(66, 99);
            this.txtChord.Name = "txtChord";
            this.txtChord.ReadOnly = true;
            this.txtChord.Size = new System.Drawing.Size(341, 20);
            this.txtChord.TabIndex = 36;
            this.txtChord.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Chord:";
            // 
            // cmdPlay
            // 
            this.cmdPlay.Enabled = false;
            this.cmdPlay.Image = ((System.Drawing.Image)(resources.GetObject("cmdPlay.Image")));
            this.cmdPlay.Location = new System.Drawing.Point(413, 133);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(25, 25);
            this.cmdPlay.TabIndex = 7;
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // timerPlay
            // 
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // fretBoard1
            // 
            this.fretBoard1.Location = new System.Drawing.Point(29, 201);
            this.fretBoard1.Name = "fretBoard1";
            this.fretBoard1.Size = new System.Drawing.Size(743, 105);
            this.fretBoard1.TabIndex = 11;
            // 
            // ChordChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 357);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.txtChord);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboGoto);
            this.Controls.Add(this.cmdFirst);
            this.Controls.Add(this.cmdLast);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmdPrev);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboFingerStretch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboToFret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboFromFret);
            this.Controls.Add(this.txtS3);
            this.Controls.Add(this.txtS4);
            this.Controls.Add(this.txtS5);
            this.Controls.Add(this.txtS6);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.cboTuning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fretBoard1);
            this.Controls.Add(this.txtIntervals);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdFind);
            this.Controls.Add(this.cboChordType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRoot);
            this.Controls.Add(this.cmdClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChordChartForm";
            this.Text = "Chord Chart";
            this.Load += new System.EventHandler(this.ChordChartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.ComboBox cboRoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChordType;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtIntervals;
        private FretBoard fretBoard1;
        private System.Windows.Forms.ComboBox cboTuning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtS1;
        private System.Windows.Forms.Label txtS2;
        private System.Windows.Forms.Label txtS6;
        private System.Windows.Forms.Label txtS5;
        private System.Windows.Forms.Label txtS4;
        private System.Windows.Forms.Label txtS3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFromFret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboToFret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboFingerStretch;
        private System.Windows.Forms.Button cmdNext;
        private System.Windows.Forms.Button cmdPrev;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button cmdLast;
        private System.Windows.Forms.Button cmdFirst;
        private System.Windows.Forms.ComboBox cboGoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.Timer timerPlay;
    }
}