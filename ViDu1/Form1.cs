using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFDLg = new OpenFileDialog();
            if (oFDLg.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = new Bitmap(oFDLg.FileName);
        }

        private void btnGhiDL_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("D:\\Xulianh\\ViDu1.txt");
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    sw.Write("(" + c.R + "," + c.G + "," + c.B + ") ");
                }
                sw.WriteLine();
            }
            sw.Close();
        }

        private void btnAnhXam_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    double g = (c.R + c.G + c.B) / 3;
                    int rgb = (int)g;
                    Color c_new = Color.FromArgb(rgb, rgb, rgb);
                    bmp.SetPixel(x, y, c_new);
                }
            }
            pictureBox2.Image = bmp;
        }

        private void btnLuuFileAnh_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox2.Image;
            bmp.Save("D:\\Xulianh\\AnhKetQua.jpg");
        }

        private void btnGhiGvaHg_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("D:\\Xulianh\\Histogram.txt");
            //sw.WriteLine("      R              G              B");
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            int[] hist = new int[256];
            hist.Initialize(); //-khởi tạo từng phẩn tử của mảng bằng 0
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    hist[c.R]++;
                }
            }
            for (int i = 0; i <= 255; i++)
            {
                sw.WriteLine(i + ": " + hist[i]);
            }
            /*for (int i = 0; i <= 255; i++)
            {
                int countR = 0, countG = 0, countB = 0;
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);
                        if (c.R == i) countR++;
                        if (c.G == i) countG++;
                        if (c.B == i) countB++;
                    }
                }
                sw.WriteLine(i + ": " + countR + "           " + countG +"           "+countB);*/
            sw.Close();
        }

        private void btnChinhSangToi_Click(object sender, EventArgs e)
        {
            int c = int.Parse(txtC.Text);
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color cl = bmp.GetPixel(x, y);
                    int r = cl.R + c;
                    int g = cl.G + c;
                    int b = cl.B + c;
                    if (r < 0) r = 0;
                    if (r > 255) r = 255;
                    if (g < 0) g = 0;
                    if (g > 255) g = 255;
                    if (b < 0) b = 0;
                    if (b > 255) b = 255;
                    Color cl_new = Color.FromArgb(r, g, b);
                    bmp.SetPixel(x, y, cl_new);
                }
            }
            pictureBox2.Image = bmp;
        }

        private void btnTaoVungTrang_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            for (int y = 100; y < 200; y++)
            {
                for (int x = 100; x < 200; x++)
                {
                    Color c = Color.FromArgb(255, 255, 255);
                    bmp.SetPixel(x, y, c);
                }
            }
            pictureBox2.Image = bmp;
        }

        private void btnAmBan_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color cl = bmp.GetPixel(x, y);
                    int r = 255 - cl.R;
                    int g = 255 - cl.G;
                    int b = 255 - cl.B;
                    if (r < 0) r = 0;
                    if (r > 255) r = 255;
                    if (g < 0) g = 0;
                    if (g > 255) g = 255;
                    if (b < 0) b = 0;
                    if (b > 255) b = 255;
                    Color cl_new = Color.FromArgb(r, g, b);
                    bmp.SetPixel(x, y, cl_new);
                }
            }
            pictureBox2.Image = bmp;
        }
        public void GianLuocDoXam()
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            int Rmin = 50, Rmax = 200, Gmin = 50, Gmax = 200, Bmin = 50, Bmax = 200;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color cl = bmp.GetPixel(x, y);
                    float r = 255 * (cl.R - Rmin) / (Rmax - Rmin);
                    float g = 255 * (cl.G - Gmin) / (Gmax - Gmin);
                    float b = 255 * (cl.B - Bmin) / (Bmax - Bmin);

                    if (r < 0) r = 0;
                    if (r > 255) r = 255;
                    if (g < 0) g = 0;
                    if (g > 255) g = 255;
                    if (b < 0) b = 0;
                    if (b > 255) b = 255;

                    Color cl_new = Color.FromArgb((int)r, (int)g, (int)b);
                    bmp.SetPixel(x, y, cl_new);
                }
            }
            pictureBox2.Image = bmp;
        }

        private void btnGianLuocDo_Click(object sender, EventArgs e)
        {
            GianLuocDoXam();
        }

        private void CanBangLuocDoXam()
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            int new_level = 200;
            double Tb = (bmp.Width * bmp.Height * 1.0) / new_level;

            int[] histR = new int[256];
            int[] histG = new int[256];
            int[] histB = new int[256];

            int[] tR = new int[256];
            int[] tG = new int[256];
            int[] tB = new int[256];

            double[] fR = new double[256];
            double[] fG = new double[256];
            double[] fB = new double[256];

            histR.Initialize();
            histG.Initialize();
            histB.Initialize();

            tR.Initialize();
            tG.Initialize();
            tB.Initialize();

            fR.Initialize();
            fG.Initialize();
            fB.Initialize();

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    histR[c.R]++;
                    histG[c.G]++;
                    histB[c.B]++;
                }
            }

            //for (int i=0; i < 256; i++)
            //{
            //        for (int j = 0; j <= i; j++)
            //        {
            //            tR[i] += histR[j];
            //        }
            //        for (int j = 0; j <= i; j++)
            //        {
            //            tG[i] += histG[j];
            //        }
            //        for (int j = 0; j <= i; j++)
            //        {
            //            tB[i] += histB[j];
            //        }
            //}
            tR[0] = histR[0];
            tG[0] = histG[0];
            tB[0] = histB[0];
            for (int i = 1; i < 256; i++)
            {

                tR[i] = tR[i - 1] + histR[i];
                tG[i] = tG[i - 1] + histG[i];
                tB[i] = tB[i - 1] + histB[i];
            }

            for (int i = 0; i < 256; i++)
            {
                fR[i] = Math.Round((tR[i] / Tb) - 1);
                fG[i] = Math.Round((tG[i] / Tb) - 1);
                fB[i] = Math.Round((tB[i] / Tb) - 1);
                if (fR[i] < 0) fR[i] = 0;
                if (fG[i] < 0) fG[i] = 0;
                if (fB[i] < 0) fB[i] = 0;

                if (fR[i] > 255) fR[i] = 255;
                if (fG[i] > 255) fG[i] = 255;
                if (fB[i] > 255) fB[i] = 255;
            }

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    Color cl_new = Color.FromArgb((int)fR[c.R], (int)fG[c.G], (int)fB[c.B]);
                    bmp.SetPixel(x, y, cl_new);
                }
            }

            //for (int y = 0; y < bmp.Height; y++)
            //{
            //    for (int x = 0; x < bmp.Width; x++)
            //    {
            //        Color c = bmp.GetPixel(x, y);
            //        int tR, tG, tB;
            //        tR = tG = tB = 0;

            //        for (int i = 0; i <= c.R; i++)
            //        {
            //            tR = tR + histR[i];
            //        }
            //        for (int i = 0; i <= c.G; i++)
            //        {
            //            tG = tG + histG[i];
            //        }
            //        for (int i = 0; i <= c.B; i++)
            //        {
            //            tB = tB + histB[i];
            //        }

            //        double fR = Math.Round((tR[c.R] / Tb) - 1), fG = Math.Round((tG[c.G] / Tb) - 1), fB = Math.Round((tB / Tb) - 1);

            //        if (fR < 0) fR = 0; 
            //        if (fG < 0) fG = 0; 
            //        if (fB < 0) fB = 0; 

            //        if (fR > 255) fR = 255;
            //        if (fG > 255) fG = 255;
            //        if (fB > 255) fB = 255;

            //        Color cl_new = Color.FromArgb((int)fR, (int)fG, (int)fB);
            //        bmp.SetPixel(x, y, cl_new);
            //    }
            //}
            pictureBox2.Image = bmp;
        }
        private void btnCanBangLuocDoXam_Click(object sender, EventArgs e)
        {
            CanBangLuocDoXam();
        }

        private void btnGhiHisAnh2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("D:\\Xulianh\\Histogram2.txt");
            Bitmap bmp = (Bitmap)pictureBox2.Image;
            int[] hist = new int[256];
            hist.Initialize(); //-khởi tạo từng phẩn tử của mảng bằng 0
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    hist[c.R]++;
                }
            }
            for (int i = 0; i <= 255; i++)
            {
                sw.WriteLine(i + ": " + hist[i]);
            }
            sw.Close();
        }

        public void tangTuongPhan()
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            int a = 50, b = 200;
            double alpha = 0.5, beta = 1.5, gamma = 1.5;
            double temp1, temp2, temp3;
            double vA = a * alpha, vB = beta * (b - a) + vA;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);

                    if (c.R <= a) temp1 = c.R * alpha;
                    else if (c.R <= b) temp1 = beta * (c.R - a) + vA;
                    else temp1 = gamma * (c.R - b) + vB;

                    if (c.G <= a) temp2 = c.G * alpha;
                    else if (c.G <= b) temp2 = beta * (c.G - a) + vA;
                    else temp2 = gamma * (c.G - b) + vB;

                    if (c.B <= a) temp3 = c.B * alpha;
                    else if (c.B <= b) temp3 = beta * (c.B - a) + vA;
                    else temp3 = gamma * (c.B - b) + vB;

                    if (temp1 < 0) temp1 = 0;
                    if (temp2 < 0) temp2 = 0;
                    if (temp3 < 0) temp3 = 0;

                    if (temp1 > 255) temp1 = 255;
                    if (temp2 > 255) temp2 = 255;
                    if (temp3 > 255) temp3 = 255;

                    Color cl_new = Color.FromArgb((int)temp1, (int)temp2, (int)temp3);
                    bmp.SetPixel(x, y, cl_new);
                }
            }
            pictureBox2.Image = bmp;
        }

        public void tangDoTuongPhanNew()
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            //int a = 25, b = 50;
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            double[] vr = new double[256];
            double[] vg = new double[256];
            double[] vb = new double[256];

            vr.Initialize();
            vg.Initialize();
            vb.Initialize();

            double alpha = 0.5, beta = 1.5, gamma = 1.5;
            double temp1, temp2, temp3;
            double vA = a * alpha, vB = beta * (b - a) + vA;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    if ((vr[c.R] == 0))
                    {
                        if (c.R <= a) temp1 = c.R * alpha;
                        else if (c.R <= b) temp1 = beta * (c.R - a) + vA;
                        else temp1 = gamma * (c.R - b) + vB;
                        if (temp1 < 0) temp1 = 0;
                        if (temp1 > 255) temp1 = 255;
                        vr[c.R] = temp1;
                    } 

                    if ((vg[c.G]) == 0)
                    {
                        if (c.G <= a) temp2 = c.G * alpha;
                        else if (c.G <= b) temp2 = beta * (c.G - a) + vA;
                        else temp2 = gamma * (c.G - b) + vB;
                        if (temp2 < 0) temp2 = 0;
                        if (temp2 > 255) temp2 = 255;
                        vg[c.G] = temp2;
                    }    
                     
                    if ((vb[c.B]) == 0)
                    {
                        if (c.B <= a) temp3 = c.B * alpha;
                        else if (c.B <= b) temp3 = beta * (c.B - a) + vA;
                        else temp3 = gamma * (c.B - b) + vB;
                        if (temp3 < 0) temp3 = 0;
                        if (temp3 > 255) temp3 = 255;
                        vb[c.B] = temp3;
                    }

                    Color cl_new = Color.FromArgb((int)vr[c.R], (int)vg[c.G], (int)vb[c.B]);
                    bmp.SetPixel(x, y, cl_new);
                }
            }
            pictureBox2.Image = bmp;
        }

        private void btnTangTuongPhan_Click(object sender, EventArgs e)
        {
            //tangTuongPhan();
            tangDoTuongPhanNew();
        }

        public void tachNguong()
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            double temp1, temp2, temp3;
            int Theta = int.Parse(txtTheta.Text);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    if (c.R >= Theta) temp1 = 255; else temp1 = 0;
                    if (c.G >= Theta) temp2 = 255; else temp2 = 0;
                    if (c.B >= Theta) temp3 = 255; else temp3 = 0;
                    Color c_new = Color.FromArgb((int)temp1, (int)temp2, (int)temp3);
                    bmp.SetPixel(x, y, c_new);
                }
            }
            pictureBox2.Image = bmp;

        }

        private void btnTachNguong_Click(object sender, EventArgs e)
        {
            tachNguong();
        }

        public void tachNguongAnhXamAuto()
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            double maxR = 0;
            int thetaR = 0;
            double temp1, temp2, temp3;

            int[] histR = new int[256];

            int[] tR = new int[256];

            double[] mR = new double[256];

            double[] fR = new double[256];

            double[] xichma = new double[256];

            histR.Initialize();

            tR.Initialize();

            xichma.Initialize();

            mR.Initialize();

            fR.Initialize(); 

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    histR[c.R]++;
                }
            }

            tR[0] = histR[0];
            for (int i = 1; i < 256; i++)
            {
                tR[i] = tR[i - 1] + histR[i];
            }

            xichma[0] = 0;
            for (int i =1; i < 256; i++)
            {
                xichma[i] = xichma[i - 1] + i * histR[i];
            }    
            mR[0] = 0;
            for (int i = 1; i < 256; i++)
            {
                mR[i] = xichma[i] / tR[i];
            }

            for (int i = 0; i < 256; i++)
            {
                if (((bmp.Width * bmp.Height) - tR[i]) == 0) break;
                else fR[i] = (tR[i] / ((bmp.Width * bmp.Height) - tR[i])) * Math.Pow((mR[i] - mR[255]), 2);
                if (fR[i] > maxR)
                {
                    maxR = fR[i];
                    thetaR = i;
                }
            }

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    if (c.R >= thetaR) temp1 = 255; else temp1 = 0;
                    if (c.G >= thetaR) temp2 = 255; else temp2 = 0;
                    if (c.B >= thetaR) temp3 = 255; else temp3 = 0;
                    Color c_new = Color.FromArgb((int)temp1, (int)temp2, (int)temp3);
                    bmp.SetPixel(x, y, c_new);
                }
            }
            MessageBox.Show(thetaR.ToString(), "Thông báo", MessageBoxButtons.OK);
            pictureBox2.Image = bmp;
        }

        private void btnTachNguongAnhXamAuto_Click(object sender, EventArgs e)
        {
            tachNguongAnhXamAuto();
        }

        public void nhanChap()
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            double[,] matrixT =
            {
                {1, 0},
                {0, 1}
            };
            int m = 2, n = 2;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if ((x < bmp.Width - n) && (y < bmp.Height - m))
                    {
                        double temp1= 0, temp2= 0, temp3= 0;
                        for (int i = 0; i < 2; i++)
                            for (int j = 0; j < 2; j++)
                            {
                                temp1 += bmp.GetPixel(x + i, y + j).R * matrixT[i,j];
                                temp2 += bmp.GetPixel(x + i, y + j).G * matrixT[i, j];
                                temp3 += bmp.GetPixel(x + i, y + j).B * matrixT[i, j];
                            }

                        if (temp1 < 0) temp1 = 0;
                        if (temp2 < 0) temp2 = 0;
                        if (temp3 < 0) temp3 = 0;

                        if (temp1 > 255) temp1 = 255;
                        if (temp2 > 255) temp2 = 255;
                        if (temp3 > 255) temp3 = 255;
                        Color c_new = Color.FromArgb((int)temp1, (int)temp2, (int)temp3);
                        bmp.SetPixel(x, y, c_new);
                    }                       
                }
            }
            pictureBox2.Image = bmp;
        }

        private void btnNhanChap_Click(object sender, EventArgs e)
        {
            nhanChap();
        }

        private void locTB()
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            int Theta = int.Parse(txtTheta.Text);
            for (int y = 0; y < bmp.Height-1; y++)
            {
                for (int x = 0; x < bmp.Width-1; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    double temp1 = 0, temp2 = 0, temp3 = 0;
                    if (x == 0 || y == 0 || y == bmp.Height -1 || x == bmp.Width-1)
                    {
                        temp1 = c.R;
                        temp2 = c.G;
                        temp3 = c.B;
                    }    
                    else
                    {
                        double sumR = 0;
                        double sumG = 0;
                        double sumB = 0;

                        for (int i =-1; i<=1; i++)
                            for (int j=-1; j<=1; j++)
                            {
                                sumR += bmp.GetPixel(x + j, y + i).R;
                                sumG += bmp.GetPixel(x + j, y + i).G;
                                sumB += bmp.GetPixel(x + j, y + i).B; 
                            }
                        double avgR = sumR / 9, avgB = sumB / 9, avgG = sumG / 9;

                        if (Math.Abs((c.R - avgR)) > Theta) temp1 = Math.Round(avgR);
                        else temp1 = c.R;
                        if (Math.Abs((c.G - avgG)) > Theta) temp2 = Math.Round(avgG);
                        else temp2 = c.G;
                        if (Math.Abs((c.B - avgB)) > Theta) temp3 = Math.Round(avgB);
                        else temp3 = c.B;

                        if (temp1 < 0) temp1 = 0;
                        if (temp2 < 0) temp2 = 0;
                        if (temp3 < 0) temp3 = 0;

                        if (temp1 > 255) temp1 = 255;
                        if (temp2 > 255) temp2 = 255;
                        if (temp3 > 255) temp3 = 255;
                    }
                    Color c_new = Color.FromArgb((int)temp1, (int)temp2, (int)temp3);
                    bmp.SetPixel(x, y, c_new);
                }
            }
            pictureBox2.Image = bmp;
        }

        private void btnLocTB_Click(object sender, EventArgs e)
        {
            locTB();
        }

        public void locTrungVi()
        {
            int theta = int.Parse(txtTheta.Text);
            int n = 4;
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            List<int> dsR = new List<int>();
            List<int> dsG = new List<int>();
            List<int> dsB = new List<int>();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color g = bmp.GetPixel(x, y);
                    if (y == 0 || x == 0 || x == bmp.Width - 1 || y == bmp.Height - 1)
                    {
                        bmp.SetPixel(x, y, g);
                    }
                    else
                    {
                        double R = g.R, G = g.G, B = g.B;
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                Color c = bmp.GetPixel(x + j, y + i);
                                dsR.Add(c.R);
                                dsG.Add(c.G);
                                dsB.Add(c.B);
                            }
                        }
                        dsR.Sort();
                        dsG.Sort();
                        dsB.Sort();
                        if (Math.Abs(g.R - dsR[n]) > theta)
                            R = dsR[n];
                        if (Math.Abs(g.G - dsG[n]) > theta)
                            G = dsG[n];
                        if (Math.Abs(g.B - dsB[n]) > theta)
                            B = dsB[n];
                        Color z = Color.FromArgb((int)R, (int)G, (int)B);
                        bmp.SetPixel(x, y, z);
                        dsR.Clear();
                        dsG.Clear();
                        dsB.Clear();
                    }
                }
                pictureBox2.Image = bmp;
            }
        }

        private void btnLocTrungVi_Click(object sender, EventArgs e)
        {
            locTrungVi();
        }
        private void nhanchap3x3(Bitmap bmp, double[,] matrixf)
        {
            int m = 3, n = 3;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if ((x < bmp.Width - n) && (y < bmp.Height - m))
                    {


                        double temp1 = 0, temp2 = 0, temp3 = 0;
                        for (int i = 0; i < 3; i++)
                            for (int j = 0; j < 3; j++)
                            {
                                Color c = bmp.GetPixel(x + i, y + j);
                                temp1 += c.R * matrixf[i, j];
                                temp2 += c.G * matrixf[i, j];
                                temp3 += c.B * matrixf[i, j];
                            }
                        if (temp1 > 255) temp1 = 255;
                        if (temp1 < 0) temp1 = 0;
                        if (temp2 > 255) temp2 = 255;
                        if (temp2 < 0) temp2 = 0;
                        if (temp3 > 255) temp3 = 255;
                        if (temp3 < 0) temp3 = 0;
                        Color c_new = Color.FromArgb((int)temp1, (int)temp2, (int)temp3);
                        bmp.SetPixel(x, y, c_new);
                    }
                }
                pictureBox2.Image = bmp;
            }
        }

        public void Robert()
        {
            Bitmap bmp1 = (Bitmap)pictureBox1.Image.Clone();
            double[,] matrixf1 =
            {
                {0,0,0 },
                {0,1,0 },
                { 0,0,-1}
            };
            nhanchap3x3(bmp1, matrixf1);
            Bitmap bmp2 = (Bitmap)pictureBox1.Image.Clone();
            double[,] matrixf2 =
            {
                {0,0,0 },
                {0,0,1 },
                { 0,-1,0}
            };
            nhanchap3x3(bmp2, matrixf2);
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    Color c1 = bmp1.GetPixel(x, y);
                    Color c2 = bmp2.GetPixel(x, y);
                    int g = c1.R + c2.R;
                    if (g > 255) g = 255;
                    else if (g < 0) g = 0;
                    bmp1.SetPixel(x, y, Color.FromArgb(g, g, g));
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Robert();
        }

        public void prewitt()
        {
            Bitmap bmp1 = (Bitmap)pictureBox1.Image.Clone();
            double[,] matrixf1 =
            {
                {-1,0,1},
                {-1,0,1},
                {-1,0,1}
            };
            nhanchap3x3(bmp1, matrixf1);
            Bitmap bmp2 = (Bitmap)pictureBox1.Image.Clone();
            double[,] matrixf2 =
            {
                {-1,-1,-1},
                {0,0,0},
                {1,1,1}
            };
            nhanchap3x3(bmp2, matrixf2);
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    Color c1 = bmp1.GetPixel(x, y);
                    Color c2 = bmp2.GetPixel(x, y);
                    int g = c1.R + c2.R;
                    if (g > 255) g = 255;
                    else if (g < 0) g = 0;
                    bmp1.SetPixel(x, y, Color.FromArgb(g, g, g));
                }
            }
        }

        private void btnPrewitt_Click(object sender, EventArgs e)
        {
            prewitt();
        }
    }
}