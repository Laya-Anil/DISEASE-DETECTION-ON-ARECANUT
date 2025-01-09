using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Detection
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
        {
            D_1_UploadMRI obj = new D_1_UploadMRI();
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
