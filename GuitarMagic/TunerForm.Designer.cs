namespace GuitarMagic
{
    partial class TunerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TunerForm));
            this.cmdClose = new System.Windows.Forms.Button();
            this.lblFundamental = new System.Windows.Forms.Label();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shpCenterOn = new ShapeControl.ShapeControl();
            this.shpCenterOff = new ShapeControl.ShapeControl();
            this.shpLeftOn1 = new ShapeControl.ShapeControl();
            this.shpLeftOn2 = new ShapeControl.ShapeControl();
            this.shpLeftOn3 = new ShapeControl.ShapeControl();
            this.shpLeftOn4 = new ShapeControl.ShapeControl();
            this.shpRightOn1 = new ShapeControl.ShapeControl();
            this.shpRightOn2 = new ShapeControl.ShapeControl();
            this.shpRightOn3 = new ShapeControl.ShapeControl();
            this.shpRightOn4 = new ShapeControl.ShapeControl();
            this.shpLeftOff1 = new ShapeControl.ShapeControl();
            this.shpLeftOff4 = new ShapeControl.ShapeControl();
            this.shpLeftOff3 = new ShapeControl.ShapeControl();
            this.shpLeftOff2 = new ShapeControl.ShapeControl();
            this.shpRightOff4 = new ShapeControl.ShapeControl();
            this.shpRightOff3 = new ShapeControl.ShapeControl();
            this.shpRightOff2 = new ShapeControl.ShapeControl();
            this.shpRightOff1 = new ShapeControl.ShapeControl();
            this.lblNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(161, 92);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(69, 28);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // lblFundamental
            // 
            this.lblFundamental.Location = new System.Drawing.Point(12, 9);
            this.lblFundamental.Name = "lblFundamental";
            this.lblFundamental.Size = new System.Drawing.Size(218, 23);
            this.lblFundamental.TabIndex = 14;
            this.lblFundamental.Text = "Input Stopped";
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(86, 92);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(69, 28);
            this.cmdStop.TabIndex = 1;
            this.cmdStop.Text = "S&top";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(11, 92);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(69, 28);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "&Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shpCenterOn
            // 
            this.shpCenterOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpCenterOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpCenterOn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpCenterOn.BorderWidth = 1;
            this.shpCenterOn.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.shpCenterOn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpCenterOn.Location = new System.Drawing.Point(111, 58);
            this.shpCenterOn.Name = "shpCenterOn";
            this.shpCenterOn.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpCenterOn.Size = new System.Drawing.Size(15, 15);
            this.shpCenterOn.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.shpCenterOn.TabIndex = 22;
            this.shpCenterOn.TabStop = false;
            this.shpCenterOn.UseGradient = true;
            // 
            // shpCenterOff
            // 
            this.shpCenterOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpCenterOff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpCenterOff.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpCenterOff.BorderWidth = 1;
            this.shpCenterOff.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.shpCenterOff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpCenterOff.Location = new System.Drawing.Point(111, 58);
            this.shpCenterOff.Name = "shpCenterOff";
            this.shpCenterOff.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpCenterOff.Size = new System.Drawing.Size(15, 15);
            this.shpCenterOff.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.shpCenterOff.TabIndex = 23;
            this.shpCenterOff.TabStop = false;
            this.shpCenterOff.UseGradient = true;
            // 
            // shpLeftOn1
            // 
            this.shpLeftOn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpLeftOn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOn1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpLeftOn1.BorderWidth = 1;
            this.shpLeftOn1.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOn1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpLeftOn1.Location = new System.Drawing.Point(90, 58);
            this.shpLeftOn1.Name = "shpLeftOn1";
            this.shpLeftOn1.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpLeftOn1.Size = new System.Drawing.Size(15, 15);
            this.shpLeftOn1.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOn1.TabIndex = 24;
            this.shpLeftOn1.TabStop = false;
            this.shpLeftOn1.UseGradient = true;
            // 
            // shpLeftOn2
            // 
            this.shpLeftOn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpLeftOn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOn2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpLeftOn2.BorderWidth = 1;
            this.shpLeftOn2.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOn2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpLeftOn2.Location = new System.Drawing.Point(69, 58);
            this.shpLeftOn2.Name = "shpLeftOn2";
            this.shpLeftOn2.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpLeftOn2.Size = new System.Drawing.Size(15, 15);
            this.shpLeftOn2.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOn2.TabIndex = 25;
            this.shpLeftOn2.TabStop = false;
            this.shpLeftOn2.UseGradient = true;
            // 
            // shpLeftOn3
            // 
            this.shpLeftOn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpLeftOn3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOn3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpLeftOn3.BorderWidth = 1;
            this.shpLeftOn3.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOn3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpLeftOn3.Location = new System.Drawing.Point(48, 58);
            this.shpLeftOn3.Name = "shpLeftOn3";
            this.shpLeftOn3.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpLeftOn3.Size = new System.Drawing.Size(15, 15);
            this.shpLeftOn3.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOn3.TabIndex = 26;
            this.shpLeftOn3.TabStop = false;
            this.shpLeftOn3.UseGradient = true;
            // 
            // shpLeftOn4
            // 
            this.shpLeftOn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpLeftOn4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOn4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpLeftOn4.BorderWidth = 1;
            this.shpLeftOn4.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOn4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpLeftOn4.Location = new System.Drawing.Point(27, 58);
            this.shpLeftOn4.Name = "shpLeftOn4";
            this.shpLeftOn4.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpLeftOn4.Size = new System.Drawing.Size(15, 15);
            this.shpLeftOn4.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOn4.TabIndex = 27;
            this.shpLeftOn4.TabStop = false;
            this.shpLeftOn4.UseGradient = true;
            // 
            // shpRightOn1
            // 
            this.shpRightOn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpRightOn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOn1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpRightOn1.BorderWidth = 1;
            this.shpRightOn1.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOn1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpRightOn1.Location = new System.Drawing.Point(132, 58);
            this.shpRightOn1.Name = "shpRightOn1";
            this.shpRightOn1.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpRightOn1.Size = new System.Drawing.Size(15, 15);
            this.shpRightOn1.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOn1.TabIndex = 28;
            this.shpRightOn1.TabStop = false;
            this.shpRightOn1.UseGradient = true;
            // 
            // shpRightOn2
            // 
            this.shpRightOn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpRightOn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOn2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpRightOn2.BorderWidth = 1;
            this.shpRightOn2.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOn2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpRightOn2.Location = new System.Drawing.Point(153, 58);
            this.shpRightOn2.Name = "shpRightOn2";
            this.shpRightOn2.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpRightOn2.Size = new System.Drawing.Size(15, 15);
            this.shpRightOn2.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOn2.TabIndex = 29;
            this.shpRightOn2.TabStop = false;
            this.shpRightOn2.UseGradient = true;
            // 
            // shpRightOn3
            // 
            this.shpRightOn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpRightOn3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOn3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpRightOn3.BorderWidth = 1;
            this.shpRightOn3.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOn3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpRightOn3.Location = new System.Drawing.Point(174, 58);
            this.shpRightOn3.Name = "shpRightOn3";
            this.shpRightOn3.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpRightOn3.Size = new System.Drawing.Size(15, 15);
            this.shpRightOn3.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOn3.TabIndex = 30;
            this.shpRightOn3.TabStop = false;
            this.shpRightOn3.UseGradient = true;
            // 
            // shpRightOn4
            // 
            this.shpRightOn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpRightOn4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOn4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpRightOn4.BorderWidth = 1;
            this.shpRightOn4.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOn4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpRightOn4.Location = new System.Drawing.Point(195, 58);
            this.shpRightOn4.Name = "shpRightOn4";
            this.shpRightOn4.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpRightOn4.Size = new System.Drawing.Size(15, 15);
            this.shpRightOn4.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOn4.TabIndex = 31;
            this.shpRightOn4.TabStop = false;
            this.shpRightOn4.UseGradient = true;
            // 
            // shpLeftOff1
            // 
            this.shpLeftOff1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpLeftOff1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOff1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpLeftOff1.BorderWidth = 1;
            this.shpLeftOff1.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOff1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpLeftOff1.Location = new System.Drawing.Point(90, 58);
            this.shpLeftOff1.Name = "shpLeftOff1";
            this.shpLeftOff1.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpLeftOff1.Size = new System.Drawing.Size(15, 15);
            this.shpLeftOff1.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOff1.TabIndex = 32;
            this.shpLeftOff1.TabStop = false;
            this.shpLeftOff1.UseGradient = true;
            // 
            // shpLeftOff4
            // 
            this.shpLeftOff4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpLeftOff4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOff4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpLeftOff4.BorderWidth = 1;
            this.shpLeftOff4.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOff4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpLeftOff4.Location = new System.Drawing.Point(27, 58);
            this.shpLeftOff4.Name = "shpLeftOff4";
            this.shpLeftOff4.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpLeftOff4.Size = new System.Drawing.Size(15, 15);
            this.shpLeftOff4.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOff4.TabIndex = 33;
            this.shpLeftOff4.TabStop = false;
            this.shpLeftOff4.UseGradient = true;
            // 
            // shpLeftOff3
            // 
            this.shpLeftOff3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpLeftOff3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOff3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpLeftOff3.BorderWidth = 1;
            this.shpLeftOff3.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOff3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpLeftOff3.Location = new System.Drawing.Point(48, 58);
            this.shpLeftOff3.Name = "shpLeftOff3";
            this.shpLeftOff3.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpLeftOff3.Size = new System.Drawing.Size(15, 15);
            this.shpLeftOff3.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOff3.TabIndex = 34;
            this.shpLeftOff3.TabStop = false;
            this.shpLeftOff3.UseGradient = true;
            // 
            // shpLeftOff2
            // 
            this.shpLeftOff2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpLeftOff2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOff2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpLeftOff2.BorderWidth = 1;
            this.shpLeftOff2.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOff2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpLeftOff2.Location = new System.Drawing.Point(69, 58);
            this.shpLeftOff2.Name = "shpLeftOff2";
            this.shpLeftOff2.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpLeftOff2.Size = new System.Drawing.Size(15, 15);
            this.shpLeftOff2.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpLeftOff2.TabIndex = 35;
            this.shpLeftOff2.TabStop = false;
            this.shpLeftOff2.UseGradient = true;
            // 
            // shpRightOff4
            // 
            this.shpRightOff4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpRightOff4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOff4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpRightOff4.BorderWidth = 1;
            this.shpRightOff4.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOff4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpRightOff4.Location = new System.Drawing.Point(195, 58);
            this.shpRightOff4.Name = "shpRightOff4";
            this.shpRightOff4.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpRightOff4.Size = new System.Drawing.Size(15, 15);
            this.shpRightOff4.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOff4.TabIndex = 36;
            this.shpRightOff4.TabStop = false;
            this.shpRightOff4.UseGradient = true;
            // 
            // shpRightOff3
            // 
            this.shpRightOff3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpRightOff3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOff3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpRightOff3.BorderWidth = 1;
            this.shpRightOff3.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOff3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpRightOff3.Location = new System.Drawing.Point(174, 58);
            this.shpRightOff3.Name = "shpRightOff3";
            this.shpRightOff3.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpRightOff3.Size = new System.Drawing.Size(15, 15);
            this.shpRightOff3.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOff3.TabIndex = 37;
            this.shpRightOff3.TabStop = false;
            this.shpRightOff3.UseGradient = true;
            // 
            // shpRightOff2
            // 
            this.shpRightOff2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpRightOff2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOff2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpRightOff2.BorderWidth = 1;
            this.shpRightOff2.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOff2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpRightOff2.Location = new System.Drawing.Point(153, 58);
            this.shpRightOff2.Name = "shpRightOff2";
            this.shpRightOff2.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpRightOff2.Size = new System.Drawing.Size(15, 15);
            this.shpRightOff2.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOff2.TabIndex = 38;
            this.shpRightOff2.TabStop = false;
            this.shpRightOff2.UseGradient = true;
            // 
            // shpRightOff1
            // 
            this.shpRightOff1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shpRightOff1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOff1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.shpRightOff1.BorderWidth = 1;
            this.shpRightOff1.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOff1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shpRightOff1.Location = new System.Drawing.Point(132, 58);
            this.shpRightOff1.Name = "shpRightOff1";
            this.shpRightOff1.Shape = ShapeControl.ShapeType.Ellipse;
            this.shpRightOff1.Size = new System.Drawing.Size(15, 15);
            this.shpRightOff1.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shpRightOff1.TabIndex = 39;
            this.shpRightOff1.TabStop = false;
            this.shpRightOff1.UseGradient = true;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(12, 32);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(0, 13);
            this.lblNote.TabIndex = 40;
            // 
            // TunerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 132);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.shpRightOff1);
            this.Controls.Add(this.shpRightOff2);
            this.Controls.Add(this.shpRightOff3);
            this.Controls.Add(this.shpRightOff4);
            this.Controls.Add(this.shpLeftOff2);
            this.Controls.Add(this.shpLeftOff3);
            this.Controls.Add(this.shpLeftOff4);
            this.Controls.Add(this.shpLeftOff1);
            this.Controls.Add(this.shpRightOn4);
            this.Controls.Add(this.shpRightOn3);
            this.Controls.Add(this.shpRightOn2);
            this.Controls.Add(this.shpRightOn1);
            this.Controls.Add(this.shpLeftOn4);
            this.Controls.Add(this.shpLeftOn3);
            this.Controls.Add(this.shpLeftOn2);
            this.Controls.Add(this.shpLeftOn1);
            this.Controls.Add(this.shpCenterOff);
            this.Controls.Add(this.shpCenterOn);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.lblFundamental);
            this.Controls.Add(this.cmdClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TunerForm";
            this.Text = "Tuner";
            this.Load += new System.EventHandler(this.TunerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label lblFundamental;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Timer timer1;
        private ShapeControl.ShapeControl shpCenterOn;
        private ShapeControl.ShapeControl shpCenterOff;
        private ShapeControl.ShapeControl shpLeftOn1;
        private ShapeControl.ShapeControl shpLeftOn2;
        private ShapeControl.ShapeControl shpLeftOn3;
        private ShapeControl.ShapeControl shpLeftOn4;
        private ShapeControl.ShapeControl shpRightOn1;
        private ShapeControl.ShapeControl shpRightOn2;
        private ShapeControl.ShapeControl shpRightOn3;
        private ShapeControl.ShapeControl shpRightOn4;
        private ShapeControl.ShapeControl shpLeftOff1;
        private ShapeControl.ShapeControl shpLeftOff4;
        private ShapeControl.ShapeControl shpLeftOff3;
        private ShapeControl.ShapeControl shpLeftOff2;
        private ShapeControl.ShapeControl shpRightOff4;
        private ShapeControl.ShapeControl shpRightOff3;
        private ShapeControl.ShapeControl shpRightOff2;
        private ShapeControl.ShapeControl shpRightOff1;
        private System.Windows.Forms.Label lblNote;
    }
}