using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ShapeControl;

namespace GuitarMagic
{
    public partial class FretBoard : UserControl
    {
        public ShapeControl.ShapeControl[,] fretPoints = new ShapeControl.ShapeControl[6, 23];

        public FretBoard()
        {
            InitializeComponent();

            #region Set points

            fretPoints[0, 0] = point0100;
            fretPoints[0, 1] = point0101;
            fretPoints[0, 2] = point0102;
            fretPoints[0, 3] = point0103;
            fretPoints[0, 4] = point0104;
            fretPoints[0, 5] = point0105;
            fretPoints[0, 6] = point0106;
            fretPoints[0, 7] = point0107;
            fretPoints[0, 8] = point0108;
            fretPoints[0, 9] = point0109;
            fretPoints[0, 10] = point0110;
            fretPoints[0, 11] = point0111;
            fretPoints[0, 12] = point0112;
            fretPoints[0, 13] = point0113;
            fretPoints[0, 14] = point0114;
            fretPoints[0, 15] = point0115;
            fretPoints[0, 16] = point0116;
            fretPoints[0, 17] = point0117;
            fretPoints[0, 18] = point0118;
            fretPoints[0, 19] = point0119;
            fretPoints[0, 20] = point0120;
            fretPoints[0, 21] = point0121;
            fretPoints[0, 22] = point0122;

            fretPoints[1, 0] = point0200;
            fretPoints[1, 1] = point0201;
            fretPoints[1, 2] = point0202;
            fretPoints[1, 3] = point0203;
            fretPoints[1, 4] = point0204;
            fretPoints[1, 5] = point0205;
            fretPoints[1, 6] = point0206;
            fretPoints[1, 7] = point0207;
            fretPoints[1, 8] = point0208;
            fretPoints[1, 9] = point0209;
            fretPoints[1, 10] = point0210;
            fretPoints[1, 11] = point0211;
            fretPoints[1, 12] = point0212;
            fretPoints[1, 13] = point0213;
            fretPoints[1, 14] = point0214;
            fretPoints[1, 15] = point0215;
            fretPoints[1, 16] = point0216;
            fretPoints[1, 17] = point0217;
            fretPoints[1, 18] = point0218;
            fretPoints[1, 19] = point0219;
            fretPoints[1, 20] = point0220;
            fretPoints[1, 21] = point0221;
            fretPoints[1, 22] = point0222;

            fretPoints[2, 0] = point0300;
            fretPoints[2, 1] = point0301;
            fretPoints[2, 2] = point0302;
            fretPoints[2, 3] = point0303;
            fretPoints[2, 4] = point0304;
            fretPoints[2, 5] = point0305;
            fretPoints[2, 6] = point0306;
            fretPoints[2, 7] = point0307;
            fretPoints[2, 8] = point0308;
            fretPoints[2, 9] = point0309;
            fretPoints[2, 10] = point0310;
            fretPoints[2, 11] = point0311;
            fretPoints[2, 12] = point0312;
            fretPoints[2, 13] = point0313;
            fretPoints[2, 14] = point0314;
            fretPoints[2, 15] = point0315;
            fretPoints[2, 16] = point0316;
            fretPoints[2, 17] = point0317;
            fretPoints[2, 18] = point0318;
            fretPoints[2, 19] = point0319;
            fretPoints[2, 20] = point0320;
            fretPoints[2, 21] = point0321;
            fretPoints[2, 22] = point0322;

            fretPoints[3, 0] = point0400;
            fretPoints[3, 1] = point0401;
            fretPoints[3, 2] = point0402;
            fretPoints[3, 3] = point0403;
            fretPoints[3, 4] = point0404;
            fretPoints[3, 5] = point0405;
            fretPoints[3, 6] = point0406;
            fretPoints[3, 7] = point0407;
            fretPoints[3, 8] = point0408;
            fretPoints[3, 9] = point0409;
            fretPoints[3, 10] = point0410;
            fretPoints[3, 11] = point0411;
            fretPoints[3, 12] = point0412;
            fretPoints[3, 13] = point0413;
            fretPoints[3, 14] = point0414;
            fretPoints[3, 15] = point0415;
            fretPoints[3, 16] = point0416;
            fretPoints[3, 17] = point0417;
            fretPoints[3, 18] = point0418;
            fretPoints[3, 19] = point0419;
            fretPoints[3, 20] = point0420;
            fretPoints[3, 21] = point0421;
            fretPoints[3, 22] = point0422;

            fretPoints[4, 0] = point0500;
            fretPoints[4, 1] = point0501;
            fretPoints[4, 2] = point0502;
            fretPoints[4, 3] = point0503;
            fretPoints[4, 4] = point0504;
            fretPoints[4, 5] = point0505;
            fretPoints[4, 6] = point0506;
            fretPoints[4, 7] = point0507;
            fretPoints[4, 8] = point0508;
            fretPoints[4, 9] = point0509;
            fretPoints[4, 10] = point0510;
            fretPoints[4, 11] = point0511;
            fretPoints[4, 12] = point0512;
            fretPoints[4, 13] = point0513;
            fretPoints[4, 14] = point0514;
            fretPoints[4, 15] = point0515;
            fretPoints[4, 16] = point0516;
            fretPoints[4, 17] = point0517;
            fretPoints[4, 18] = point0518;
            fretPoints[4, 19] = point0519;
            fretPoints[4, 20] = point0520;
            fretPoints[4, 21] = point0521;
            fretPoints[4, 22] = point0522;


            fretPoints[5, 0] = point0600;
            fretPoints[5, 1] = point0601;
            fretPoints[5, 2] = point0602;
            fretPoints[5, 3] = point0603;
            fretPoints[5, 4] = point0604;
            fretPoints[5, 5] = point0605;
            fretPoints[5, 6] = point0606;
            fretPoints[5, 7] = point0607;
            fretPoints[5, 8] = point0608;
            fretPoints[5, 9] = point0609;
            fretPoints[5, 10] = point0610;
            fretPoints[5, 11] = point0611;
            fretPoints[5, 12] = point0612;
            fretPoints[5, 13] = point0613;
            fretPoints[5, 14] = point0614;
            fretPoints[5, 15] = point0615;
            fretPoints[5, 16] = point0616;
            fretPoints[5, 17] = point0617;
            fretPoints[5, 18] = point0618;
            fretPoints[5, 19] = point0619;
            fretPoints[5, 20] = point0620;
            fretPoints[5, 21] = point0621;
            fretPoints[5, 22] = point0622;

            #endregion

        }

        private void FretBoard_Load(object sender, EventArgs e)
        {

        }

        public void HideFretPoints()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 23; j++)
                {
                    fretPoints[i, j].Visible = false;
                }
            }
        }
    }
}
