using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Detection
{
    public partial class F_1_BrowseImage : Form
    {
        public F_1_BrowseImage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image (*.bmp; *.jpg; *.jpeg; *.png) |*.bmp; *.jpg; *.jpeg; *.png|All files (*.*)|*.*||";
           // dlg.InitialDirectory = Application.StartupPath + "\\dataset";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            else
            {
                pictureBox1.ImageLocation = dlg.FileName;
                textBox1.Text = dlg.FileName.ToString();
                Program.ss = textBox1.Text;
            }
        }
        private static unsafe bool IsGrayScale(Image image)
        {
            using (var bmp = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb))
            {
                using (var g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(image, 0, 0);
                }

                var data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat);

                var pt = (int*)data.Scan0;
                var res = true;

                for (var i = 0; i < data.Height * data.Width; i++)
                {
                    var color = Color.FromArgb(pt[i]);

                    if (color.A != 0 && (color.R != color.G || color.G != color.B))
                    {
                        res = false;
                        break;
                    }
                }

                bmp.UnlockBits(data);

                return res;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
             //bool s = IsGrayScale((Bitmap)pictureBox1.Image);
             //if (s == true)
             //{
                 F_1_MainForm obj = new F_1_MainForm((Bitmap)pictureBox1.Image);
                 ActiveForm.Hide();
                 obj.Show();
             //}
             //else
             //{
             //    MessageBox.Show("Please Select MRI Image");
             //}
        }
    }
}
