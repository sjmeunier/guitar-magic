using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SpectrumLib
{
    public partial class SpectrumSpread : UserControl
    {
        public Color drawColor = Color.Black;
        public Color backColor = Color.White;

        public SpectrumSpread()
        {
            InitializeComponent();
        }

        private void SpectrumSpread_Load(object sender, EventArgs e)
        {

        }

        public void SetScopeColor(Color oColor)
        {
            picSpectrum.BackColor = oColor;
            backColor = oColor;
        }

        public void SetScopeForeColor(Color oColor)
        {
            drawColor = oColor;
        }

        public void DrawSpectrum(ref double[] data, double dataMax, bool exponential, int samples)
        {
            Bitmap image = new Bitmap(picSpectrum.Width, picSpectrum.Height);
            Graphics g = Graphics.FromImage(image);
            Pen linePen = new Pen(drawColor, 1);


            double samplesPerPixel = (double)samples/ (double)picSpectrum.Width;

            double temp = 0;
            int xPos = 0;
            int yMid = picSpectrum.Height - 10;
            int ySize = picSpectrum.Height - 10;

            int yPos = 0;
            int yPrevPos = 0;
            int xPrevPos = 0;
            double xPosDouble = 0;

            g.Clear(backColor);
            g.DrawLine(linePen, 0, yMid, picSpectrum.Width - 1, yMid);

            for (int i = 0; i < (samples); i++)
            {
                if (samplesPerPixel >= 1)
                {
                    //temp += (Math.Pow(data[i], 2));
                    if (exponential == true)
                    {
                        temp += Math.Log10(data[i]);
                    }
                    else
                    {
                        temp += Math.Pow(data[i], 2);
                    }
                    if ((i % (int)Math.Floor(samplesPerPixel)) == ((int)Math.Floor(samplesPerPixel) - 1))
                    {
                        temp /= (int)Math.Floor(samplesPerPixel);
                        yPos = Convert.ToInt32(Math.Round((double)ySize * (temp / dataMax)));

                        if ((xPos > 0) && (xPos < picSpectrum.Width))
                        {
                            g.DrawLine(linePen, xPos, yMid, xPos, yMid - yPos);
                        }
                        temp = 0;
                        xPos++;
                    }
                }
                else
                {
                    yPos = Convert.ToInt32(Math.Round((double)ySize * (data[i] / dataMax)));

                    if (xPos > 0)
                    {
                        g.DrawLine(linePen, xPrevPos, yMid, xPos, yMid - yPos);
                    }
                    temp = 0;
                    yPrevPos = yPos;
                    xPosDouble += 1.0 / samplesPerPixel;
                    xPrevPos = xPos;
                    xPos = Convert.ToInt32(Math.Round(xPosDouble));
                }

            }

            picSpectrum.Image = image;
        }

    }
}
