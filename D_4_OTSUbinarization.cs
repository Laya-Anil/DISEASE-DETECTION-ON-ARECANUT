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
using System.IO;


namespace Detection
{
    public partial class D_4_OTSUbinarization : Form
    {
        public CannyEdgeDetector filter2 = new CannyEdgeDetector();
        private byte threshold1 = 128;
        private Threshold filter = new Threshold();
        private ContrastCorrection filter1 = new ContrastCorrection();
        private byte threshold = 58;
        public Bitmap dobitmap;
        public D_4_OTSUbinarization()
        {
            InitializeComponent();
        }
        public D_4_OTSUbinarization(string filename)
        {
            InitializeComponent();
            pictureBox1.Image = System.Drawing.Image.FromFile(filename);
            dobitmap = (Bitmap)Bitmap.FromFile(filename);
           
        }

        public void cannyf()
        {

            IFilter filler = new SobelEdgeDetector();
            Bitmap newImage = filler.Apply((Bitmap)Bitmap.FromFile(Program.sliceFilePath));
            pictureBox3.Image = newImage;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap newImage = filter.Apply((Bitmap)pictureBox1.Image);
            orginalpic.Image = newImage;
            cannyf();
        }

        private void slider_Scroll(object sender, EventArgs e)
        {
            thresholdBox.Text = slider.Value.ToString();
            filter.ThresholdValue = (byte)slider.Value;

            Bitmap newImage = filter.Apply((Bitmap)dobitmap);
            orginalpic.Image = newImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            double v = (double)trackBar1.Value / 20 + 1.0;

            label5.Text = "Sigma Value= " + v.ToString();

            filter2.GaussianSigma = v;
            Bitmap newImage = filter2.Apply((Bitmap)Bitmap.FromFile(Program.sliceFilePath));
            pictureBox3.Image = newImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
            Bitmap newImage = filter.Apply((Bitmap)pictureBox1.Image);
            orginalpic.Image = newImage;
            cannyf();
            label5.Text = "...";
            pictureBox2.Image = (System.Drawing.Image)(Makeoptimum((Bitmap)Bitmap.FromFile(Program.sliceFilePath)));
        }
        public static Bitmap Makeoptimum(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][] 
      {
         new float[] {.3f, .3f, .3f, 0, 0},
         new float[] {.59f, .59f, .59f, 0, 0},
         new float[] {.11f, .11f, .11f, 0, 0},
         new float[] {0, 0, 0, 1, 0},
         new float[] {0, 0, 0, 0, 1}
      });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.tumour = (Bitmap)pictureBox3.Image;

            Program.HOG = (Bitmap)pictureBox2.Image;
            //D_9_Classification obj = new D_9_Classification();
            //ActiveForm.Hide();
            //obj.Show();

            D_5_CNN obj = new D_5_CNN((Bitmap)pictureBox3.Image, (Bitmap)pictureBox2.Image);
            ActiveForm.Hide();
            obj.Show();
        }

    }
}
