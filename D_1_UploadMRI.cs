using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;

namespace Detection
{
    public partial class D_1_UploadMRI : Form
    {
        BaseConnection con = new BaseConnection();
        string uid;
        public D_1_UploadMRI()
        {
            InitializeComponent();
        }
        public string getid()
        {


            string query = "select isnull(max(uid)+1,100) from register";
            SqlDataReader sd = con.ret_dr(query);
            if (sd.Read())
            {
                uid = sd[0].ToString();

            }
            return uid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(Application.StartupPath + "\\sample");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBox1.Text = openFileDialog1.FileName.ToString();
                pictureBox1.ImageLocation = textBox1.Text;
                Program.OrginalFilePath = textBox1.Text;
                

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
            //string uid11 = getid();
            //int userid = 504;
            //int rgb = 255;
            //int status = 0;
            //string str2 = "insert into image_store values (" + uid11 + "," + userid + ",'" + rgb + "','" + textBox1.Text + "'," + status + ")";
            //con.exec(str2);
            bool s = IsGrayScale((Bitmap)pictureBox1.Image);
            if (s == false)
            {
                D_2_Slicing obj = new D_2_Slicing(Program.OrginalFilePath);
                ActiveForm.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Please input correct image");
            }

           
        }

        private void D_1_UploadMRI_Load(object sender, EventArgs e)
        {

        }
    }
}
