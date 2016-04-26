using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SpectrumLib
{
    public partial class Oscilloscope : UserControl
    {
        public Color drawColor = Color.Black;
        public Color backColor = Color.White;



        public Oscilloscope()
        {
            InitializeComponent();
        }

        private void Oscilloscope_Load(object sender, EventArgs e)
        {

        }

        public void SetScopeColor(Color oColor)
        {
            picScope.BackColor = oColor;
            backColor = oColor;
        }

        public void SetScopeForeColor(Color oColor)
        {
            drawColor = oColor;
        }

        public void DrawSpectrum(ref double[] data, double dataMax, int sampleRate, int samples, double scaleTime)
        {
            int samplesToDraw;
            Bitmap image = new Bitmap(picScope.Width, picScope.Height);
            Graphics g = Graphics.FromImage(image);
            Pen linePen = new Pen(drawColor, 1);

            if (scaleTime == 0)
            {
                samplesToDraw = samples;
            }
            else
            {
                samplesToDraw = Convert.ToInt32(Math.Floor(scaleTime * sampleRate));
                if (samplesToDraw > samples)
                {
                    samplesToDraw = samples;
                }
            }

            double samplesPerPixel = (double)samplesToDraw / (double)picScope.Width;

            double temp = 0;
            int xPos = 0;
            int yMid = picScope.Height / 2;
            int ySize = picScope.Height / 2;

            int yPos = 0;
            int yPrevPos = 0;
            int xPrevPos = 0;
            double xPosDouble = 0;

            g.Clear(backColor);
     //       g.DrawLine(linePen, 0, yMid, picScope.Width - 1, yMid);

            for (int i = 0; i < samplesToDraw; i++)
            {
                if (samplesPerPixel >= 1)
                {
                    temp += data[i];

                    if ((i % (int)Math.Floor(samplesPerPixel)) == ((int)Math.Floor(samplesPerPixel) - 1))
                    {
                        temp /= (int)Math.Floor(samplesPerPixel);
                        yPos = Convert.ToInt32(Math.Round((double)ySize * (temp / dataMax)));

                        if ((xPos > 0) && (xPos < picScope.Width))
                        {
                            g.DrawLine(linePen, xPos - 1, yMid - yPrevPos, xPos, yMid - yPos);
                        }
                        temp = 0;
                        yPrevPos = yPos;
                        xPos++;
                    }
                }
                else
                {
                    yPos = Convert.ToInt32(Math.Round((double)ySize * (data[i] / dataMax)));

                    if (xPos > 0)
                    {
                        g.DrawLine(linePen, xPrevPos, yMid - yPrevPos, xPos, yMid - yPos);
                    }
                    temp = 0;
                    yPrevPos = yPos;
                    xPosDouble += 1.0 / samplesPerPixel;
                    xPrevPos = xPos;
                    xPos = Convert.ToInt32(Math.Round(xPosDouble));
                }

            }

            Font textFont = new Font("Courier", 7);
            SolidBrush textBrush = new SolidBrush(Color.Black);
            double timeScale = (double)samplesToDraw / (double)sampleRate;
            g.DrawLine(linePen, 3, picScope.Height - 7, 3, picScope.Height - 1);
            g.DrawString("0.00s", textFont, textBrush, 5, picScope.Height - 12);

            g.DrawLine(linePen, picScope.Width / 4, picScope.Height - 7, picScope.Width / 4, picScope.Height - 1);
            g.DrawString((timeScale / 4).ToString("#0.00") + "s", textFont, textBrush, (picScope.Width / 4) + 2, picScope.Height - 12);

            g.DrawLine(linePen, picScope.Width / 2, picScope.Height - 7, picScope.Width / 2, picScope.Height - 1);
            g.DrawString((timeScale / 2).ToString("#0.00") + "s", textFont, textBrush, (picScope.Width / 2) + 2, picScope.Height - 12);

            g.DrawLine(linePen, picScope.Width * 3 / 4, picScope.Height - 7, picScope.Width * 3 / 4, picScope.Height - 1);
            g.DrawString((timeScale * 3 / 4).ToString("#0.00") + "s", textFont, textBrush, (picScope.Width * 3 / 4) + 2, picScope.Height - 12);

            g.DrawLine(linePen, picScope.Width - 3, picScope.Height - 7, picScope.Width - 3, picScope.Height - 1);
            g.DrawString((timeScale).ToString("#0.00") + "s", textFont, textBrush, picScope.Width - 30, picScope.Height - 12);

            picScope.Image = image;
        }
    }
}
