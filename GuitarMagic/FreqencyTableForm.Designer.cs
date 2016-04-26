namespace GuitarMagic
{
    partial class FreqencyTableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreqencyTableForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Octave1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Octave2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Octave3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Octave4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Octave5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Octave6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Octave7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Octave8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Octave9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Octave10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panNote = new System.Windows.Forms.ToolStripStatusLabel();
            this.panFreq = new System.Windows.Forms.ToolStripStatusLabel();
            this.panWavelength = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Octave1,
            this.Octave2,
            this.Octave3,
            this.Octave4,
            this.Octave5,
            this.Octave6,
            this.Octave7,
            this.Octave8,
            this.Octave9,
            this.Octave10});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 80;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(883, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Octave1
            // 
            this.Octave1.Frozen = true;
            this.Octave1.HeaderText = "Octave 1";
            this.Octave1.Name = "Octave1";
            this.Octave1.ReadOnly = true;
            this.Octave1.Width = 80;
            // 
            // Octave2
            // 
            this.Octave2.Frozen = true;
            this.Octave2.HeaderText = "Octave 2";
            this.Octave2.Name = "Octave2";
            this.Octave2.ReadOnly = true;
            this.Octave2.Width = 80;
            // 
            // Octave3
            // 
            this.Octave3.Frozen = true;
            this.Octave3.HeaderText = "Octave 3";
            this.Octave3.Name = "Octave3";
            this.Octave3.ReadOnly = true;
            this.Octave3.Width = 80;
            // 
            // Octave4
            // 
            this.Octave4.Frozen = true;
            this.Octave4.HeaderText = "Octave 4";
            this.Octave4.Name = "Octave4";
            this.Octave4.ReadOnly = true;
            this.Octave4.Width = 80;
            // 
            // Octave5
            // 
            this.Octave5.Frozen = true;
            this.Octave5.HeaderText = "Octave 5";
            this.Octave5.Name = "Octave5";
            this.Octave5.ReadOnly = true;
            this.Octave5.Width = 80;
            // 
            // Octave6
            // 
            this.Octave6.Frozen = true;
            this.Octave6.HeaderText = "Octave 6";
            this.Octave6.Name = "Octave6";
            this.Octave6.ReadOnly = true;
            this.Octave6.Width = 80;
            // 
            // Octave7
            // 
            this.Octave7.Frozen = true;
            this.Octave7.HeaderText = "Octave 7";
            this.Octave7.Name = "Octave7";
            this.Octave7.ReadOnly = true;
            this.Octave7.Width = 80;
            // 
            // Octave8
            // 
            this.Octave8.Frozen = true;
            this.Octave8.HeaderText = "Octave 8";
            this.Octave8.Name = "Octave8";
            this.Octave8.ReadOnly = true;
            this.Octave8.Width = 80;
            // 
            // Octave9
            // 
            this.Octave9.Frozen = true;
            this.Octave9.HeaderText = "Octave 9";
            this.Octave9.Name = "Octave9";
            this.Octave9.ReadOnly = true;
            this.Octave9.Width = 80;
            // 
            // Octave10
            // 
            this.Octave10.Frozen = true;
            this.Octave10.HeaderText = "Octave 10";
            this.Octave10.Name = "Octave10";
            this.Octave10.ReadOnly = true;
            this.Octave10.Width = 80;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(817, 304);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(69, 28);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panNote,
            this.panFreq,
            this.panWavelength});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(898, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panNote
            // 
            this.panNote.AutoSize = false;
            this.panNote.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.panNote.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.panNote.Name = "panNote";
            this.panNote.Size = new System.Drawing.Size(135, 20);
            this.panNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panFreq
            // 
            this.panFreq.AutoSize = false;
            this.panFreq.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.panFreq.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.panFreq.Name = "panFreq";
            this.panFreq.Size = new System.Drawing.Size(135, 20);
            this.panFreq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panWavelength
            // 
            this.panWavelength.AutoSize = false;
            this.panWavelength.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.panWavelength.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.panWavelength.Name = "panWavelength";
            this.panWavelength.Size = new System.Drawing.Size(135, 20);
            this.panWavelength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FreqencyTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 365);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FreqencyTableForm";
            this.Text = "Freqency Table";
            this.Load += new System.EventHandler(this.FreqencyTableForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FreqencyTableForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Octave1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Octave2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Octave3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Octave4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Octave5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Octave6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Octave7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Octave8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Octave9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Octave10;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel panNote;
        private System.Windows.Forms.ToolStripStatusLabel panFreq;
        private System.Windows.Forms.ToolStripStatusLabel panWavelength;

    }
}