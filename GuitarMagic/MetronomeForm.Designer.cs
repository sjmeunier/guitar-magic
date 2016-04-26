namespace GuitarMagic
{
    partial class MetronomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetronomeForm));
            this.cmdClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeControl1 = new ShapeControl.ShapeControl();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdChange = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.shapeControl2 = new ShapeControl.ShapeControl();
            this.txtTempo = new FractalDraw.NumericTextbox();
            this.txtBottomNum = new FractalDraw.NumericTextbox();
            this.txtTopNum = new FractalDraw.NumericTextbox();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(211, 231);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(69, 28);
            this.cmdClose.TabIndex = 6;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time Signature:";
            // 
            // shapeControl1
            // 
            this.shapeControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shapeControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shapeControl1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shapeControl1.BorderWidth = 5;
            this.shapeControl1.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shapeControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shapeControl1.Location = new System.Drawing.Point(100, 36);
            this.shapeControl1.Name = "shapeControl1";
            this.shapeControl1.Shape = ShapeControl.ShapeType.Rectangle;
            this.shapeControl1.Size = new System.Drawing.Size(27, 6);
            this.shapeControl1.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shapeControl1.TabIndex = 7;
            this.shapeControl1.TabStop = false;
            this.shapeControl1.UseGradient = false;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(211, 12);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(69, 28);
            this.cmdStart.TabIndex = 3;
            this.cmdStart.Text = "&Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdChange
            // 
            this.cmdChange.Enabled = false;
            this.cmdChange.Location = new System.Drawing.Point(211, 80);
            this.cmdChange.Name = "cmdChange";
            this.cmdChange.Size = new System.Drawing.Size(69, 28);
            this.cmdChange.TabIndex = 5;
            this.cmdChange.Text = "&Change";
            this.cmdChange.UseVisualStyleBackColor = true;
            this.cmdChange.Click += new System.EventHandler(this.cmdChange_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Enabled = false;
            this.cmdStop.Location = new System.Drawing.Point(211, 46);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(69, 28);
            this.cmdStop.TabIndex = 4;
            this.cmdStop.Text = "S&top";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tempo:";
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(122, 141);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(40, 38);
            this.lblTop.TabIndex = 13;
            this.lblTop.Text = "1";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBottom
            // 
            this.lblBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottom.Location = new System.Drawing.Point(122, 188);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(40, 38);
            this.lblBottom.TabIndex = 14;
            this.lblBottom.Text = "4";
            this.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeControl2
            // 
            this.shapeControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shapeControl2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shapeControl2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shapeControl2.BorderWidth = 5;
            this.shapeControl2.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shapeControl2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shapeControl2.Location = new System.Drawing.Point(128, 179);
            this.shapeControl2.Name = "shapeControl2";
            this.shapeControl2.Shape = ShapeControl.ShapeType.Rectangle;
            this.shapeControl2.Size = new System.Drawing.Size(27, 6);
            this.shapeControl2.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shapeControl2.TabIndex = 15;
            this.shapeControl2.TabStop = false;
            this.shapeControl2.UseGradient = false;
            // 
            // txtTempo
            // 
            this.txtTempo.CommaFormat = false;
            this.txtTempo.CurrencyFormat = false;
            this.txtTempo.DecimalPrecision = 0;
            this.txtTempo.DisableFormat = false;
            this.txtTempo.Location = new System.Drawing.Point(100, 80);
            this.txtTempo.MaxValue = 1000;
            this.txtTempo.MinValue = 1;
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.PercentFormat = false;
            this.txtTempo.ReadOnly = false;
            this.txtTempo.Size = new System.Drawing.Size(41, 20);
            this.txtTempo.TabIndex = 2;
            this.txtTempo.UseMaxMin = true;
            // 
            // txtBottomNum
            // 
            this.txtBottomNum.CommaFormat = false;
            this.txtBottomNum.CurrencyFormat = false;
            this.txtBottomNum.DecimalPrecision = 0;
            this.txtBottomNum.DisableFormat = false;
            this.txtBottomNum.Location = new System.Drawing.Point(100, 48);
            this.txtBottomNum.MaxValue = 16;
            this.txtBottomNum.MinValue = 1;
            this.txtBottomNum.Name = "txtBottomNum";
            this.txtBottomNum.PercentFormat = false;
            this.txtBottomNum.ReadOnly = false;
            this.txtBottomNum.Size = new System.Drawing.Size(27, 20);
            this.txtBottomNum.TabIndex = 1;
            this.txtBottomNum.UseMaxMin = true;
            // 
            // txtTopNum
            // 
            this.txtTopNum.CommaFormat = false;
            this.txtTopNum.CurrencyFormat = false;
            this.txtTopNum.DecimalPrecision = 0;
            this.txtTopNum.DisableFormat = false;
            this.txtTopNum.Location = new System.Drawing.Point(100, 12);
            this.txtTopNum.MaxValue = 16;
            this.txtTopNum.MinValue = 1;
            this.txtTopNum.Name = "txtTopNum";
            this.txtTopNum.PercentFormat = false;
            this.txtTopNum.ReadOnly = false;
            this.txtTopNum.Size = new System.Drawing.Size(27, 20);
            this.txtTopNum.TabIndex = 0;
            this.txtTopNum.UseMaxMin = true;
            // 
            // MetronomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 271);
            this.Controls.Add(this.shapeControl2);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdChange);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.shapeControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBottomNum);
            this.Controls.Add(this.txtTopNum);
            this.Controls.Add(this.cmdClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MetronomeForm";
            this.Text = "MetronomeForm";
            this.Load += new System.EventHandler(this.MetronomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private FractalDraw.NumericTextbox txtTopNum;
        private FractalDraw.NumericTextbox txtBottomNum;
        private System.Windows.Forms.Label label1;
        private ShapeControl.ShapeControl shapeControl1;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdChange;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Timer timer1;
        private FractalDraw.NumericTextbox txtTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblBottom;
        private ShapeControl.ShapeControl shapeControl2;
    }
}