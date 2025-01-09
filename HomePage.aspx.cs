using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    DbConnection ob = new DbConnection();
    DbConnection ob1 = new DbConnection();
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox8.Text == "" && TextBox10.Text == "")
        {
            Response.Write("<script>alert('Fill the fields...............')</script>");
        }
        else
        {
            str = "select * from Login where Username='" + TextBox8.Text + "'";
            ob.dr = ob.ret_dr(str);
            if (ob.dr.Read())
            {
                if (ob.dr[1].ToString() == TextBox10.Text)
                {
                    str = "select status from Login where Username='" + TextBox8.Text + "' and Password='" + TextBox10.Text + "'";
                    ob1.dr = ob1.ret_dr(str);
                    if (ob1.dr.Read())
                    {
                        
                        if (ob1.dr[0].ToString() == "0")
                        {

                           
                            Session["uname"] = TextBox8.Text;
                            Response.Redirect("CPatientHomePage.aspx");

                        }
                        else
                        {
                            Response.Write("<script>alert('Invalid username or password...')</script>");
                        }
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid username or password...')</script>");
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}