using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

namespace Detection
{
    public partial class D_3_SelectSlice : Form
    {
        public D_3_SelectSlice()
        {
            InitializeComponent();
            loadslices();
        }
        public void loadslices()
        {
            string[] array1 = Directory.GetFiles(Application.StartupPath + "\\sample");
           
            imageList1.Images.Clear();
            for (int i = 0; i < array1.Count(); i++)
            {
                string path=array1[i];
                comboBox1.Items.Add(Path.GetFileName(path));
            }
            int count = 0;

           
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            D_4_OTSUbinarization obj = new D_4_OTSUbinarization(PictureBox1.ImageLocation);
            Program.org = (Bitmap)PictureBox1.Image;
            Program.sliceFilePath = PictureBox1.ImageLocation;
            ActiveForm.Hide();
            obj.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureBox1.ImageLocation = Application.StartupPath + "\\sample\\" + comboBox1.Text;
        }
    }
}
