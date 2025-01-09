using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Detection
{
    public partial class D_8_HOG2 : Form
    {
        public D_8_HOG2(Bitmap bmp)
        {
            InitializeComponent();
            orginalpic.Image = (Image)bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.tumour = (Bitmap)orginalpic.Image;
            imageToByteArray((System.Drawing.Image)(Bitmap)orginalpic.Image);
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
        public static int windowsize = 16;
    
        public void imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //return ms.ToArray();
            OrientationImage newImg = FromByteArray(ms.ToArray());

            byte[] finalarray = ToByteArray(newImg);
            MemoryStream ms1 = new MemoryStream(finalarray);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms1);
            pictureBox1.Image = returnImage;

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
            pictureBox2.Image = Program.blackImage;


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

        private void button1_Click(object sender, EventArgs e)
        {
           
            CNNModel obj1 = new CNNModel();
            string final = obj1.CNNPoolMatch((Bitmap)Image.FromFile(Program.OrginalFilePath));
           
            readfile(final);
          
        }
        public void readfile(string n)
        {

            string[] files = n.Split(new[] { "^&*#(" }, StringSplitOptions.None);

            if (files.Length >= 1)
            {
                string t = files[0].ToString();
                if (t.Length >= 6)
                {
                    MessageBox.Show("Leaf Disease not Found");
                    Application.Exit();
                    // pictureBox5.Image = Base64ToImage(t);
                }
                else
                {
                    D_9_Classification obj = new D_9_Classification();
                    ActiveForm.Hide();
                    obj.Show();
                }
            }
            else
            {
                MessageBox.Show("Disease not detected");
                Application.Exit();
               

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.HOG = (Bitmap)pictureBox2.Image;
            D_9_Classification obj = new D_9_Classification();
            ActiveForm.Hide();
            obj.Show();
        }

    }
}
