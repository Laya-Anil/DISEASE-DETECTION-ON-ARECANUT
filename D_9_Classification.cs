using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;
using AForge.Math;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using AForge;


namespace Detection
{
    public partial class D_9_Classification : Form
    {
        Bitmap bmp = null;
        Bitmap bmp1 = null;
        public D_9_Classification()
        {
            InitializeComponent();
            pictureBox1.Image = (Bitmap)Program.org;
           // orginalpic.Image = (Bitmap)Program.tumour;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void cannyf()
        {

            IFilter filler = new SobelEdgeDetector();
            Bitmap newImage = filler.Apply((Bitmap)Bitmap.FromFile(Program.sliceFilePath));
            orginalpic.Image= newImage;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = "92";
                
                Program.text = text;
                Filehandler obj = new Filehandler();
                Bitmap c = obj.savefile();
                string[] filelist = Directory.GetFiles(Application.StartupPath + "\\dataset", "*.jpg");
                int i = filelist.Length;
                i++;

                c.Save(Application.StartupPath + "\\dataset\\dataset_" + i.ToString() + ".jpg", ImageFormat.Png);

              

                MessageBox.Show("Training finished....");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Training Failure....");
            }
          
        }

        private void D_9_Classification_Load(object sender, EventArgs e)
        {
            cannyf();
           // pictureBox1.Image.Save(Application.StartupPath + "\\attach\\picture1.jpg");
        }

       
    }
}
