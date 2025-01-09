using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Detection
{
    public partial class BasePage : Form
    {
        BaseConnection con = new BaseConnection();
        public BasePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                AdminHome obj = new AdminHome();
                ActiveForm.Hide();
                obj.Show();
            }
            else
            {

                string query = "select * from login where username='" + textBox1.Text + "'";
                SqlDataReader sd = con.ret_dr(query);
                if (sd.Read())
                {
                    if ((textBox1.Text == sd[0].ToString()) && textBox2.Text == sd[1].ToString())
                    {

                        //System.IO.DirectoryInfo di = new DirectoryInfo(Application.StartupPath + "\\sample");

                        //foreach (FileInfo file in di.GetFiles())
                        //{
                        //    file.Delete();
                        //}

                        HomePage obj = new HomePage();
                        ActiveForm.Hide();
                        obj.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Password or username...");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            
            obj.Show();
        }

        private void BasePage_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }
    }
}
