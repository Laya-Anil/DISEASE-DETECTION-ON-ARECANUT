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
    public partial class F : Form
    {
      
        public F()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                filepath.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CNNModel obj = new CNNModel();
            string final = obj.CNNPoolMatch((Bitmap)pictureBox1.Image);
            readfile(final);
        }

        public void readfile(string n)
        {

            string[] files = n.Split(new[] { "^&*#(" }, StringSplitOptions.None);
            string text= files[0].ToString();
            string t = files[1].ToString();
            string h = files[2].ToString();
            pictureBox2.Image = Base64ToImage(t);
            pictureBox3.Image = Base64ToImage(h);
          

        }
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;

        }
    }
}
