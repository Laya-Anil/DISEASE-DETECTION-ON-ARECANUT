using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CPatientPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox8.Text = "Rs 1000";
        TextBox1.Text = DateTime.Now.ToShortDateString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox3.Text == "" || TextBox10.Text == "" || TextBox8.Text == "" || TextBox11.Text == "" || TextBox9.Text == "")
        {
            Label11.Visible = true;
            Label11.ForeColor = System.Drawing.Color.Red;
            Label11.Text = "Please Enter all fields correctly!";
        }
        else
        {
            Label11.Visible = true;
            Label11.ForeColor = System.Drawing.Color.Green;
            Label11.Text = "Payment successfully !";
        }
    }
}