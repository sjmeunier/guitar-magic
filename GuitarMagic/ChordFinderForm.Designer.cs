namespace GuitarMagic
{
    partial class ChordFinderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChordFinderForm));
            this.label4 = new System.Windows.Forms.Label();
            this.cmdFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNote11 = new System.Windows.Forms.ComboBox();
            this.cboNote1 = new System.Windows.Forms.ComboBox();
            this.cboNote2 = new System.Windows.Forms.ComboBox();
            this.cboNote3 = new System.Windows.Forms.ComboBox();
            this.cboNote4 = new System.Windows.Forms.ComboBox();
            this.cboNote5 = new System.Windows.Forms.ComboBox();
            this.cboNote6 = new System.Windows.Forms.ComboBox();
            this.cboNote7 = new System.Windows.Forms.ComboBox();
            this.cboNote8 = new System.Windows.Forms.ComboBox();
            this.cboNote9 = new System.Windows.Forms.ComboBox();
            this.cboNote10 = new System.Windows.Forms.ComboBox();
            this.cboNote0 = new System.Windows.Forms.ComboBox();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.txtIntervals = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.txtChord = new System.Windows.Forms.TextBox();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Chord:";
            // 
            // cmdFind
            // 
            this.cmdFind.Location = new System.Drawing.Point(714, 21);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(69, 28);
            this.cmdFind.TabIndex = 12;
            this.cmdFind.Text = "&Find";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Notes:";
            // 
            // cboNote11
            // 
            this.cboNote11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote11.FormattingEnabled = true;
            this.cboNote11.Location = new System.Drawing.Point(476, 48);
            this.cboNote11.Name = "cboNote11";
            this.cboNote11.Size = new System.Drawing.Size(76, 21);
            this.cboNote11.TabIndex = 11;
            // 
            // cboNote1
            // 
            this.cboNote1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote1.FormattingEnabled = true;
            this.cboNote1.Location = new System.Drawing.Point(148, 21);
            this.cboNote1.Name = "cboNote1";
            this.cboNote1.Size = new System.Drawing.Size(76, 21);
            this.cboNote1.TabIndex = 1;
            // 
            // cboNote2
            // 
            this.cboNote2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote2.FormattingEnabled = true;
            this.cboNote2.Location = new System.Drawing.Point(230, 21);
            this.cboNote2.Name = "cboNote2";
            this.cboNote2.Size = new System.Drawing.Size(76, 21);
            this.cboNote2.TabIndex = 2;
            // 
            // cboNote3
            // 
            this.cboNote3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote3.FormattingEnabled = true;
            this.cboNote3.Location = new System.Drawing.Point(312, 21);
            this.cboNote3.Name = "cboNote3";
            this.cboNote3.Size = new System.Drawing.Size(76, 21);
            this.cboNote3.TabIndex = 3;
            // 
            // cboNote4
            // 
            this.cboNote4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote4.FormattingEnabled = true;
            this.cboNote4.Location = new System.Drawing.Point(394, 21);
            this.cboNote4.Name = "cboNote4";
            this.cboNote4.Size = new System.Drawing.Size(76, 21);
            this.cboNote4.TabIndex = 4;
            // 
            // cboNote5
            // 
            this.cboNote5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote5.FormattingEnabled = true;
            this.cboNote5.Location = new System.Drawing.Point(476, 21);
            this.cboNote5.Name = "cboNote5";
            this.cboNote5.Size = new System.Drawing.Size(76, 21);
            this.cboNote5.TabIndex = 5;
            // 
            // cboNote6
            // 
            this.cboNote6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote6.FormattingEnabled = true;
            this.cboNote6.Location = new System.Drawing.Point(66, 48);
            this.cboNote6.Name = "cboNote6";
            this.cboNote6.Size = new System.Drawing.Size(76, 21);
            this.cboNote6.TabIndex = 6;
            // 
            // cboNote7
            // 
            this.cboNote7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote7.FormattingEnabled = true;
            this.cboNote7.Location = new System.Drawing.Point(148, 48);
            this.cboNote7.Name = "cboNote7";
            this.cboNote7.Size = new System.Drawing.Size(76, 21);
            this.cboNote7.TabIndex = 7;
            // 
            // cboNote8
            // 
            this.cboNote8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote8.FormattingEnabled = true;
            this.cboNote8.Location = new System.Drawing.Point(230, 48);
            this.cboNote8.Name = "cboNote8";
            this.cboNote8.Size = new System.Drawing.Size(76, 21);
            this.cboNote8.TabIndex = 8;
            // 
            // cboNote9
            // 
            this.cboNote9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote9.FormattingEnabled = true;
            this.cboNote9.Location = new System.Drawing.Point(312, 48);
            this.cboNote9.Name = "cboNote9";
            this.cboNote9.Size = new System.Drawing.Size(76, 21);
            this.cboNote9.TabIndex = 9;
            // 
            // cboNote10
            // 
            this.cboNote10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote10.FormattingEnabled = true;
            this.cboNote10.Location = new System.Drawing.Point(394, 48);
            this.cboNote10.Name = "cboNote10";
            this.cboNote10.Size = new System.Drawing.Size(76, 21);
            this.cboNote10.TabIndex = 10;
            // 
            // cboNote0
            // 
            this.cboNote0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote0.FormattingEnabled = true;
            this.cboNote0.Location = new System.Drawing.Point(66, 21);
            this.cboNote0.Name = "cboNote0";
            this.cboNote0.Size = new System.Drawing.Size(76, 21);
            this.cboNote0.TabIndex = 0;
            // 
            // cmdPlay
            // 
            this.cmdPlay.Enabled = false;
            this.cmdPlay.Image = ((System.Drawing.Image)(resources.GetObject("cmdPlay.Image")));
            this.cmdPlay.Location = new System.Drawing.Point(758, 143);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(25, 25);
            this.cmdPlay.TabIndex = 13;
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // txtIntervals
            // 
            this.txtIntervals.Location = new System.Drawing.Point(66, 167);
            this.txtIntervals.Name = "txtIntervals";
            this.txtIntervals.ReadOnly = true;
            this.txtIntervals.Size = new System.Drawing.Size(685, 20);
            this.txtIntervals.TabIndex = 70;
            this.txtIntervals.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(66, 140);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(685, 20);
            this.txtNotes.TabIndex = 69;
            this.txtNotes.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Intervals:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Notes:";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(714, 204);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(69, 28);
            this.cmdClose.TabIndex = 14;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // txtChord
            // 
            this.txtChord.Location = new System.Drawing.Point(66, 114);
            this.txtChord.Name = "txtChord";
            this.txtChord.ReadOnly = true;
            this.txtChord.Size = new System.Drawing.Size(259, 20);
            this.txtChord.TabIndex = 88;
            this.txtChord.TabStop = false;
            // 
            // timerPlay
            // 
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // ChordFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 244);
            this.Controls.Add(this.txtChord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNote11);
            this.Controls.Add(this.cboNote1);
            this.Controls.Add(this.cboNote2);
            this.Controls.Add(this.cboNote3);
            this.Controls.Add(this.cboNote4);
            this.Controls.Add(this.cboNote5);
            this.Controls.Add(this.cboNote6);
            this.Controls.Add(this.cboNote7);
            this.Controls.Add(this.cboNote8);
            this.Controls.Add(this.cboNote9);
            this.Controls.Add(this.cboNote10);
            this.Controls.Add(this.cboNote0);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.txtIntervals);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChordFinderForm";
            this.Text = "ChordFinderForm";
            this.Load += new System.EventHandler(this.ChordFinderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNote11;
        private System.Windows.Forms.ComboBox cboNote1;
        private System.Windows.Forms.ComboBox cboNote2;
        private System.Windows.Forms.ComboBox cboNote3;
        private System.Windows.Forms.ComboBox cboNote4;
        private System.Windows.Forms.ComboBox cboNote5;
        private System.Windows.Forms.ComboBox cboNote6;
        private System.Windows.Forms.ComboBox cboNote7;
        private System.Windows.Forms.ComboBox cboNote8;
        private System.Windows.Forms.ComboBox cboNote9;
        private System.Windows.Forms.ComboBox cboNote10;
        private System.Windows.Forms.ComboBox cboNote0;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.TextBox txtIntervals;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.TextBox txtChord;
        private System.Windows.Forms.Timer timerPlay;
    }
}