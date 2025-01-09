using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CPatientChangePwd : System.Web.UI.Page
{
    DbConnection ob = new DbConnection();
    DbConnection ob1 = new DbConnection();
    protected void Page_Load(object sender, EventArgs e)
    { // Session["puname"] = "nichu123";
        TextBox8.Text = Session["pname"].ToString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string str = "select * from Login where Username='" + TextBox8.Text + "' and Password='" + TextBox3.Text + "'";
        ob.dr = ob.ret_dr(str);
        if (ob.dr.Read())
        {
            str = "update Login set Password='" + TextBox3.Text + "' where Username='" + TextBox8.Text + "'";
            ob1.exec(str);

            Response.Write("<script>alert('Ur passord is changed...')</script>");

        }
        else
        {
            Response.Write("<script>alert('Error...')</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}