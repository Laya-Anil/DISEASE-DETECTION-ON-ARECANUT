using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserRegistration : System.Web.UI.Page
{
    DbConnection ob2 = new DbConnection();
    DbConnection ob = new DbConnection();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public int getid()
    {
        int c = 0;
        ob.dr = ob.ret_dr("select isnull(max(uid),500)+1 from register");
        if (ob.dr.Read())
        {
            c = Convert.ToInt32(ob.dr[0].ToString());
        }
        return c;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox8.Text == "")
        {
            Label3.Visible = true;
            Label3.ForeColor = System.Drawing.Color.Red;
            Label3.Text = "Please Enter all fields correctly!";
        }
        else
        {


            string app = getid().ToString();
            string dcomment = "0";
            string bdate = DateTime.Now.ToShortDateString();

            string str11 = "insert into register values(" + app + ",'" + TextBox8.Text + "','" + TextBox10.Text + "','" + TextBox1.Text + "','" + TextBox4.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "',0)";
            ob2.exec(str11);
            // string role = "Wait";
            string str = "insert into Login values('" + TextBox8.Text + "','" + TextBox10.Text + "',0)";
            ob.exec(str);
            
            Label3.Visible = true;
            Label3.ForeColor = System.Drawing.Color.Green;
            Label3.Text = "Data stored successfully !";
            TextBox1.Text = "";

            TextBox3.Text = "";
            TextBox10.Text = "";
            TextBox4.Text = "";
            TextBox2.Text = "";
            TextBox8.Text = "";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";

        TextBox3.Text = "";
        TextBox10.Text = "";
        TextBox4.Text = "";
        TextBox2.Text = "";
        TextBox8.Text = "";
    }
}