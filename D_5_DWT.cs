using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Math;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using AForge;
using System.Drawing.Imaging;
namespace Detection
{
    public partial class D_5_DWT : Form
    {
        public CannyEdgeDetector filter = new CannyEdgeDetector();
        private byte threshold = 128;
        Bitmap org;
        public D_5_DWT(Bitmap bmp,Bitmap bmp2)
        {
            InitializeComponent();
            org = bmp;
            pictureBox1.Image = (System.Drawing.Image)bmp2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dwt1(0, 50, 94);
        }

        public void dwt1(int value, int value2, int value3)
        {
            double v = (double)value;
            double y = (double)value2 + 2.0;
            double z = (double)value3 + 1.0;



            filter.GaussianSigma = v;
            Bitmap newImage = filter.Apply((Bitmap)org);
            LH1.Image = newImage;


            filter.GaussianSigma = y;
            Bitmap newImage1 = filter.Apply((Bitmap)org);
            HL1.Image = newImage1;


            filter.GaussianSigma = z;
            Bitmap newImage2 = filter.Apply((Bitmap)org);
            HH1.Image = newImage2;

            IFilter filler = new GrayscaleBT709();
            Bitmap OR = (Bitmap)filler.Apply((Bitmap)org);
            LL1.Image = OR;

            timer1.Enabled = false;
        }

        public void dwt2(int value, int value2, int value3)
        {
            double v = (double)value;
            double y = (double)value2 + .4;
            double z = (double)value3 + 1.0;



            filter.GaussianSigma = v;
            Bitmap newImage = filter.Apply((Bitmap)(Bitmap)org);
            LH2.Image = newImage;


            filter.GaussianSigma = y;
            Bitmap newImage1 = filter.Apply((Bitmap)(Bitmap)org);
            HL2.Image = newImage1;


            filter.GaussianSigma = z;
            Bitmap newImage2 = filter.Apply((Bitmap)(Bitmap)org);
            HH2.Image = newImage2;

            IFilter filler = new GrayscaleBT709();
            Bitmap OR = (Bitmap)filler.Apply((Bitmap)(Bitmap)org);
            LL2.Image = OR;
            timer1.Enabled = false;
            //  progressBar1.Value = 0;
        }
        public void dwt3(int value, int value2, int value3)
        {
            double v = (double)value;
            double y = (double)value2 + .4;
            double z = (double)value3 + 1.0;



            filter.GaussianSigma = v;
            Bitmap newImage = filter.Apply((Bitmap)(Bitmap)org);
            LH3.Image = newImage;


            filter.GaussianSigma = y;
            Bitmap newImage1 = filter.Apply((Bitmap)(Bitmap)org);
            HL3.Image = newImage1;


            filter.GaussianSigma = z;
            Bitmap newImage2 = filter.Apply((Bitmap)(Bitmap)org);
            HH3.Image = newImage2;

            IFilter filler = new GrayscaleBT709();
            Bitmap OR = (Bitmap)filler.Apply((Bitmap)(Bitmap)org);
            LL3.Image = OR;
            timer1.Enabled = false;
            //  progressBar1.Value = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dwt2(0, 30, 74);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value = progressBar1.Value + 20;

            }
            else
            {
                progressBar1.Value = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dwt3(60, 70, 200);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            D_8_HOG2 obj = new D_8_HOG2((Bitmap)LL1.Image);
            ActiveForm.Hide();
            obj.Show();
        }
    }
}
