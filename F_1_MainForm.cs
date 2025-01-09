using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AForge.Math;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using AForge;
using System.Drawing.Imaging;
using System.IO;


namespace Detection
{
    public partial class F_1_MainForm : Form
    {
        public CannyEdgeDetector filter2 = new CannyEdgeDetector();
        private byte threshold1 = 128;
        private Threshold filter = new Threshold();
        private ContrastCorrection filter1 = new ContrastCorrection();
        private byte threshold = 58;
        public Bitmap dobitmap;
        public static Bitmap orginal;

        public static string jf="";


        CNNData _cnn1;
        public static int _count = 0;
        public static Bitmap bc1;
        public static Bitmap bc;
        public static Bitmap img2;


        public F_1_MainForm(Bitmap bmp)
        {
            InitializeComponent();
            orginal = bmp;
            pictureBox1.Image = (System.Drawing.Image)bmp;
        }

        public void otsu()
        {

            IFilter filler = new SobelEdgeDetector();
            Bitmap newImage = filler.Apply((Bitmap)orginal);
            pictureBox2.Image = newImage;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            otsu();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            double v = (double)trackBar1.Value / 20 + 1.0;

         

            filter2.GaussianSigma = v;
            Bitmap newImage = filter2.Apply((Bitmap)orginal);
            pictureBox2.Image = newImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bc = (Bitmap)orginal;
            if (radioButton1.Checked)
                _cnn1 = new CNNData(bc, Convert.ToInt32(txtNumClusters.Text), Detection.Colour.Types.RGB);
            else
                _cnn1 = new CNNData(bc, Convert.ToInt32(txtNumClusters.Text), Detection.Colour.Types.HSV);
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!_cnn1.Converged)
            {
                _cnn1.Iterate();
                pictureBox4.Image = _cnn1.ProcessedImage;
                pictureBox4.Refresh();
                _count++;
                label10.Text = "Iteration: " + _count.ToString();
            }
            else
            {
                label10.Text = "Converged After " + _count.ToString() + " Iterations";
                pictureBox3.Image = pictureBox4.Image;
                _count = 0;
                timer1.Enabled = false;
                timer1.Stop();
            }
        }
        public CannyEdgeDetector filteqr = new CannyEdgeDetector();
        private byte threshold2 = 128;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox2.Image;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imageToByteArray((System.Drawing.Image)(Bitmap)pictureBox3.Image);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dwt1(0);
        }

        public void dwt1(int value)
        {
            double v = (double)value;
           



            filteqr.GaussianSigma = v;
            Bitmap newImage = filteqr.Apply((Bitmap)orginal);
            pictureBox3.Image = newImage;
            



        }

        public void Show(OrientationImage orImg, Graphics g)
        {
            int lineLength = 10 / 2;
            Pen greenPen = new Pen(Brushes.Green) { Width = 2 };
            Pen redPen = new Pen(Brushes.Red) { Width = 2 };
            Pen currentPen;

            for (int i = 0; i < orImg.Height; i++)
                for (int j = 0; j < orImg.Width; j++)
                {
                    double angle;
                    if (orImg.IsNullBlock(i, j))
                    {
                        currentPen = redPen;
                        angle = 0;
                    }
                    else
                    {
                        currentPen = greenPen;
                        angle = orImg.AngleInRadians(i, j);
                    }
                    //double angle = orImg.IsNullBlock(i, j) ? 0 : orImg.AngleInRadians(i, j);
                    int x = j * 10 + 10 / 2;
                    int y = i * 10 + 10 / 2;

                    Point p0 = new Point
                    {
                        X = Convert.ToInt32(x - lineLength * Math.Cos(angle)),
                        Y = Convert.ToInt32(y - lineLength * Math.Sin(angle))
                    };

                    Point p1 = new Point
                    {
                        X = Convert.ToInt32(x + lineLength * Math.Cos(angle)),
                        Y = Convert.ToInt32(y + lineLength * Math.Sin(angle))
                    };

                    g.DrawLine(currentPen, p0, p1);
                    //showgridlines(orImg, g);
                }
        }
        public static byte[] ToByteArray(OrientationImage orImg)
        {
            byte[] bytes = new byte[orImg.Width * orImg.Height + 3];
            bytes[0] = orImg.WindowSize;
            bytes[1] = orImg.Height;
            bytes[2] = orImg.Width;
            int k = 3;
            for (int i = 0; i < orImg.Height; i++)
                for (int j = 0; j < orImg.Width; j++)
                    if (orImg.IsNullBlock(i, j))
                        bytes[k++] = 255;
                    else
                        bytes[k++] = Convert.ToByte(Math.Round(orImg.AngleInRadians(i, j) * 180 / Math.PI));
            return bytes;
        }
        public static int windowsize = 8;

        public void imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //return ms.ToArray();
            OrientationImage newImg = FromByteArray(ms.ToArray());

            byte[] finalarray = ToByteArray(newImg);
            MemoryStream ms1 = new MemoryStream(finalarray);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms1);
            pictureBox8.Image = returnImage;

            Bitmap newImage = (Bitmap)returnImage;
            Program.blackImage = new Bitmap(newImage.Width, newImage.Height);
            Show(newImg, Graphics.FromImage(returnImage));
            newimage(newImg);


        }
        public void newimage(OrientationImage orImg)
        {

            Graphics g = Graphics.FromImage(Program.blackImage);

            int lineLength = windowsize / 2;
            Pen greenPen = new Pen(Brushes.Green) { Width = 2 };
            Pen redPen = new Pen(Brushes.Red) { Width = 2 };
            Pen currentPen;

            for (int i = 0; i < orImg.Height; i++)
                for (int j = 0; j < orImg.Width; j++)
                {
                    double angle;
                    if (orImg.IsNullBlock(i, j))
                    {
                        currentPen = redPen;
                        angle = 0;
                    }
                    else
                    {
                        currentPen = greenPen;
                        angle = orImg.AngleInRadians(i, j);
                    }
                    //double angle = orImg.IsNullBlock(i, j) ? 0 : orImg.AngleInRadians(i, j);
                    int x = j * windowsize + windowsize / 2;
                    int y = i * windowsize + windowsize / 2;

                    Point p0 = new Point
                    {
                        X = Convert.ToInt32(x - lineLength * Math.Cos(angle)),
                        Y = Convert.ToInt32(y - lineLength * Math.Sin(angle))
                    };

                    Point p1 = new Point
                    {
                        X = Convert.ToInt32(x + lineLength * Math.Cos(angle)),
                        Y = Convert.ToInt32(y + lineLength * Math.Sin(angle))
                    };

                    g.DrawLine(currentPen, p0, p1);
                }
            pictureBox7.Image = Program.blackImage;


        }
        public static OrientationImage FromByteArray(byte[] bytes)
        {
            byte height = bytes[1];
            byte width = bytes[2];
            byte[,] orientations = new byte[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i * width + j + 3 < bytes.Length)
                    {
                        orientations[i, j] = Convert.ToByte(bytes[i * width + j + 3]);
                    }
                }
            }

            OrientationImage orImg = new OrientationImage(width, height, orientations, bytes[0]);

            return orImg;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CNNModel obj = new CNNModel();
            string final = obj.CNNPoolMatch((Bitmap)orginal);
            jf = final;
            readfile(final);
            cannyf1();
        }
        public void cannyf()
        {

            IFilter filler = new SobelEdgeDetector();
            Bitmap newImage = filler.Apply((Bitmap)pictureBox5.Image);
            pictureBox6.Image = newImage;

        }
        public void cannyf1()
        {

            IFilter filler = new SobelEdgeDetector();
            Bitmap newImage = filler.Apply((Bitmap)pictureBox2.Image);
            pictureBox5.Image = newImage;

        }
        public void readfile(string n)
        {

            string[] files = n.Split(new[] { "^&*#(" }, StringSplitOptions.None);

            if (files.Length >= 1)
            {
               
               // pictureBox6.Visible = true;
                string t = files[0].ToString();
              //  string text = files[1].ToString();
                // string h = files[2].ToString();
                
               // pictureBox6.Image = Base64ToImage(t);
                if (t.Length >= 6)
                {
                    MessageBox.Show("Leaf Disease not Found");
                    Application.Exit();
                    // pictureBox5.Image = Base64ToImage(t);
                }
                else
                {
                    pictureBox5.Visible = true;
                    button7.Visible = true;
                }
                //else
                //{
                //    pictureBox5.Image = Base64ToImage(h);
                //}
            }
            else
            {
                MessageBox.Show("Disease not detected");
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

            }


        }

        public System.Drawing.Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            cannyf();
            pictureBox6.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            F_2_Identification obj = new F_2_Identification(orginal, jf, (Bitmap)pictureBox6.Image);
            ActiveForm.Hide();
            obj.Show();
        }
    }
}
