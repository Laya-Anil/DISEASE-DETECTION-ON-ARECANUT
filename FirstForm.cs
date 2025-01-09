using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Detection
{
    public partial class FirstForm : Form
    {
        BaseConnection con = new BaseConnection();
        public FirstForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from login where username='" + textBox1.Text + "'";
            SqlDataReader sd = con.ret_dr(query);
            if (sd.Read())
            {
                if ((textBox1.Text == "admin") && textBox2.Text =="admin")
                {

                    //Program.uname = sd[0].ToString();
                    //HomeForm obj = new HomeForm();
                    //ActiveForm.Hide();
                    //obj.Show();
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
}
