namespace GuitarMagic
{
    partial class TransposerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransposerForm));
            this.cmdClose = new System.Windows.Forms.Button();
            this.txtOriginalScale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransposedScale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOriginalKey = new System.Windows.Forms.ComboBox();
            this.cboScale = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTransposedKey = new System.Windows.Forms.ComboBox();
            this.cmdTranspose = new System.Windows.Forms.Button();
            this.txtIntervals = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(658, 221);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(69, 28);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // txtOriginalScale
            // 
            this.txtOriginalScale.Location = new System.Drawing.Point(105, 165);
            this.txtOriginalScale.Name = "txtOriginalScale";
            this.txtOriginalScale.ReadOnly = true;
            this.txtOriginalScale.Size = new System.Drawing.Size(622, 20);
            this.txtOriginalScale.TabIndex = 41;
            this.txtOriginalScale.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Original Scale:";
            // 
            // txtTransposedScale
            // 
            this.txtTransposedScale.Location = new System.Drawing.Point(105, 195);
            this.txtTransposedScale.Name = "txtTransposedScale";
            this.txtTransposedScale.ReadOnly = true;
            this.txtTransposedScale.Size = new System.Drawing.Size(622, 20);
            this.txtTransposedScale.TabIndex = 43;
            this.txtTransposedScale.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Transposed Scale:";
            // 
            // cboOriginalKey
            // 
            this.cboOriginalKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOriginalKey.FormattingEnabled = true;
            this.cboOriginalKey.Location = new System.Drawing.Point(105, 12);
            this.cboOriginalKey.Name = "cboOriginalKey";
            this.cboOriginalKey.Size = new System.Drawing.Size(84, 21);
            this.cboOriginalKey.TabIndex = 0;
            // 
            // cboScale
            // 
            this.cboScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScale.FormattingEnabled = true;
            this.cboScale.Location = new System.Drawing.Point(305, 12);
            this.cboScale.Name = "cboScale";
            this.cboScale.Size = new System.Drawing.Size(193, 21);
            this.cboScale.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Scale:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Original Key:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Transposed Key:";
            // 
            // cboTransposedKey
            // 
            this.cboTransposedKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransposedKey.FormattingEnabled = true;
            this.cboTransposedKey.Location = new System.Drawing.Point(105, 41);
            this.cboTransposedKey.Name = "cboTransposedKey";
            this.cboTransposedKey.Size = new System.Drawing.Size(84, 21);
            this.cboTransposedKey.TabIndex = 2;
            // 
            // cmdTranspose
            // 
            this.cmdTranspose.Location = new System.Drawing.Point(658, 15);
            this.cmdTranspose.Name = "cmdTranspose";
            this.cmdTranspose.Size = new System.Drawing.Size(69, 28);
            this.cmdTranspose.TabIndex = 4;
            this.cmdTranspose.Text = "&Transpose";
            this.cmdTranspose.UseVisualStyleBackColor = true;
            this.cmdTranspose.Click += new System.EventHandler(this.cmdTranspose_Click);
            // 
            // txtIntervals
            // 
            this.txtIntervals.Location = new System.Drawing.Point(105, 136);
            this.txtIntervals.Name = "txtIntervals";
            this.txtIntervals.ReadOnly = true;
            this.txtIntervals.Size = new System.Drawing.Size(622, 20);
            this.txtIntervals.TabIndex = 52;
            this.txtIntervals.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Intervals:";
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(105, 110);
            this.txtScale.Name = "txtScale";
            this.txtScale.ReadOnly = true;
            this.txtScale.Size = new System.Drawing.Size(341, 20);
            this.txtScale.TabIndex = 54;
            this.txtScale.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Scale:";
            // 
            // TransposerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 259);
            this.Controls.Add(this.txtScale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIntervals);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdTranspose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTransposedKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboOriginalKey);
            this.Controls.Add(this.cboScale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTransposedScale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOriginalScale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransposerForm";
            this.Text = "Transposer";
            this.Load += new System.EventHandler(this.TransposerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.TextBox txtOriginalScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransposedScale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOriginalKey;
        private System.Windows.Forms.ComboBox cboScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTransposedKey;
        private System.Windows.Forms.Button cmdTranspose;
        private System.Windows.Forms.TextBox txtIntervals;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Label label9;
    }
}