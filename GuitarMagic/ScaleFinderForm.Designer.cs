namespace GuitarMagic
{
    partial class ScaleFinderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleFinderForm));
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.txtIntervals = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNote0 = new System.Windows.Forms.ComboBox();
            this.cboNote10 = new System.Windows.Forms.ComboBox();
            this.cboNote9 = new System.Windows.Forms.ComboBox();
            this.cboNote8 = new System.Windows.Forms.ComboBox();
            this.cboNote7 = new System.Windows.Forms.ComboBox();
            this.cboNote6 = new System.Windows.Forms.ComboBox();
            this.cboNote5 = new System.Windows.Forms.ComboBox();
            this.cboNote4 = new System.Windows.Forms.ComboBox();
            this.cboNote3 = new System.Windows.Forms.ComboBox();
            this.cboNote2 = new System.Windows.Forms.ComboBox();
            this.cboNote1 = new System.Windows.Forms.ComboBox();
            this.cboNote11 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFind = new System.Windows.Forms.Button();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.lstScales = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(712, 261);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(69, 28);
            this.cmdClose.TabIndex = 14;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.Enabled = false;
            this.cmdPlay.Image = ((System.Drawing.Image)(resources.GetObject("cmdPlay.Image")));
            this.cmdPlay.Location = new System.Drawing.Point(756, 126);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(25, 25);
            this.cmdPlay.TabIndex = 13;
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // txtIntervals
            // 
            this.txtIntervals.Location = new System.Drawing.Point(64, 150);
            this.txtIntervals.Name = "txtIntervals";
            this.txtIntervals.ReadOnly = true;
            this.txtIntervals.Size = new System.Drawing.Size(685, 20);
            this.txtIntervals.TabIndex = 48;
            this.txtIntervals.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(64, 123);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(685, 20);
            this.txtNotes.TabIndex = 47;
            this.txtNotes.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Intervals:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Notes:";
            // 
            // cboNote0
            // 
            this.cboNote0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote0.FormattingEnabled = true;
            this.cboNote0.Location = new System.Drawing.Point(64, 28);
            this.cboNote0.Name = "cboNote0";
            this.cboNote0.Size = new System.Drawing.Size(76, 21);
            this.cboNote0.TabIndex = 0;
            // 
            // cboNote10
            // 
            this.cboNote10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote10.FormattingEnabled = true;
            this.cboNote10.Location = new System.Drawing.Point(392, 55);
            this.cboNote10.Name = "cboNote10";
            this.cboNote10.Size = new System.Drawing.Size(76, 21);
            this.cboNote10.TabIndex = 10;
            // 
            // cboNote9
            // 
            this.cboNote9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote9.FormattingEnabled = true;
            this.cboNote9.Location = new System.Drawing.Point(310, 55);
            this.cboNote9.Name = "cboNote9";
            this.cboNote9.Size = new System.Drawing.Size(76, 21);
            this.cboNote9.TabIndex = 9;
            // 
            // cboNote8
            // 
            this.cboNote8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote8.FormattingEnabled = true;
            this.cboNote8.Location = new System.Drawing.Point(228, 55);
            this.cboNote8.Name = "cboNote8";
            this.cboNote8.Size = new System.Drawing.Size(76, 21);
            this.cboNote8.TabIndex = 8;
            // 
            // cboNote7
            // 
            this.cboNote7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote7.FormattingEnabled = true;
            this.cboNote7.Location = new System.Drawing.Point(146, 55);
            this.cboNote7.Name = "cboNote7";
            this.cboNote7.Size = new System.Drawing.Size(76, 21);
            this.cboNote7.TabIndex = 7;
            // 
            // cboNote6
            // 
            this.cboNote6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote6.FormattingEnabled = true;
            this.cboNote6.Location = new System.Drawing.Point(64, 55);
            this.cboNote6.Name = "cboNote6";
            this.cboNote6.Size = new System.Drawing.Size(76, 21);
            this.cboNote6.TabIndex = 6;
            // 
            // cboNote5
            // 
            this.cboNote5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote5.FormattingEnabled = true;
            this.cboNote5.Location = new System.Drawing.Point(474, 28);
            this.cboNote5.Name = "cboNote5";
            this.cboNote5.Size = new System.Drawing.Size(76, 21);
            this.cboNote5.TabIndex = 5;
            // 
            // cboNote4
            // 
            this.cboNote4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote4.FormattingEnabled = true;
            this.cboNote4.Location = new System.Drawing.Point(392, 28);
            this.cboNote4.Name = "cboNote4";
            this.cboNote4.Size = new System.Drawing.Size(76, 21);
            this.cboNote4.TabIndex = 4;
            // 
            // cboNote3
            // 
            this.cboNote3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote3.FormattingEnabled = true;
            this.cboNote3.Location = new System.Drawing.Point(310, 28);
            this.cboNote3.Name = "cboNote3";
            this.cboNote3.Size = new System.Drawing.Size(76, 21);
            this.cboNote3.TabIndex = 3;
            // 
            // cboNote2
            // 
            this.cboNote2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote2.FormattingEnabled = true;
            this.cboNote2.Location = new System.Drawing.Point(228, 28);
            this.cboNote2.Name = "cboNote2";
            this.cboNote2.Size = new System.Drawing.Size(76, 21);
            this.cboNote2.TabIndex = 2;
            // 
            // cboNote1
            // 
            this.cboNote1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote1.FormattingEnabled = true;
            this.cboNote1.Location = new System.Drawing.Point(146, 28);
            this.cboNote1.Name = "cboNote1";
            this.cboNote1.Size = new System.Drawing.Size(76, 21);
            this.cboNote1.TabIndex = 1;
            // 
            // cboNote11
            // 
            this.cboNote11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNote11.FormattingEnabled = true;
            this.cboNote11.Location = new System.Drawing.Point(474, 55);
            this.cboNote11.Name = "cboNote11";
            this.cboNote11.Size = new System.Drawing.Size(76, 21);
            this.cboNote11.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Notes:";
            // 
            // cmdFind
            // 
            this.cmdFind.Location = new System.Drawing.Point(712, 28);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(69, 28);
            this.cmdFind.TabIndex = 12;
            this.cmdFind.Text = "&Find";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // timerPlay
            // 
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // lstScales
            // 
            this.lstScales.BackColor = System.Drawing.SystemColors.Control;
            this.lstScales.FormattingEnabled = true;
            this.lstScales.Location = new System.Drawing.Point(64, 176);
            this.lstScales.Name = "lstScales";
            this.lstScales.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstScales.Size = new System.Drawing.Size(448, 56);
            this.lstScales.TabIndex = 64;
            this.lstScales.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Scales:";
            // 
            // ScaleFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 301);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstScales);
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
            this.Name = "ScaleFinderForm";
            this.Text = "Scale Finder";
            this.Load += new System.EventHandler(this.ScaleFinderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.TextBox txtIntervals;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNote0;
        private System.Windows.Forms.ComboBox cboNote10;
        private System.Windows.Forms.ComboBox cboNote9;
        private System.Windows.Forms.ComboBox cboNote8;
        private System.Windows.Forms.ComboBox cboNote7;
        private System.Windows.Forms.ComboBox cboNote6;
        private System.Windows.Forms.ComboBox cboNote5;
        private System.Windows.Forms.ComboBox cboNote4;
        private System.Windows.Forms.ComboBox cboNote3;
        private System.Windows.Forms.ComboBox cboNote2;
        private System.Windows.Forms.ComboBox cboNote1;
        private System.Windows.Forms.ComboBox cboNote11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.ListBox lstScales;
        private System.Windows.Forms.Label label4;
    }
}