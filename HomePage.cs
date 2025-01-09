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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            D_1_UploadMRI obj = new D_1_UploadMRI();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            F_1_BrowseImage obj = new F_1_BrowseImage();
            obj.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            string[] filePaths = Directory.GetFiles(Application.StartupPath + "\\sample\\");
            foreach (string filePath in filePaths)
                File.Delete(filePath);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            F_1_BrowseImage obj = new F_1_BrowseImage();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasePage obj = new BasePage();
            ActiveForm.Hide();
            obj.Show();
        }
    }
}
