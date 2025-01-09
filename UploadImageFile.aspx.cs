using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

public partial class UploadImageFile : System.Web.UI.Page
{
    CNNModel sm = new CNNModel();
    Class1 f1 = new Class1();
    Class2 f2 = new Class2();
    Class3 f3 = new Class3();

   
    DataSet ds = new DataSet();
    public static string img2 = "";
    string t = "";
    private Bitmap bmp = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Add(f3.a1);
        ListBox1.Items.Add(f3.a2);
        img2 = Server.MapPath("~/ImgProduct/" + "/");
        ListBox1.Items.Add(f3.a3);
        string str = FileUpload1.FileName.ToString();
        ListBox1.Items.Add(f3.a4);
        Image1.ImageUrl = "~/ImgProduct/" + str;
        bmp = new Bitmap(img2 + str);
        ListBox1.Items.Add(f3.a5);
        t = sm.CNNPoolMatch(bmp);
        ListBox1.Items.Add(f3.a6);
        ListBox1.Items.Add(f3.a7);
        ListBox1.Items.Add(f3.a8);
        ListBox1.Items.Add(f3.a9);
        ListBox1.Items.Add(f3.a10);
        ListBox1.Items.Add(f3.a11);
        ListBox1.Items.Add(f3.a12);
        if (t == f1.a1)
        {

            TextBox10.Text = "Abnormal";
            TextBox11.Text = f2.a101;
            TextBox12.Text = "Intial Stage";


        }
        if (t == f1.a2)
        {
            TextBox10.Text = "Abnormal";
            TextBox11.Text = f2.a101;
            TextBox12.Text = "Moderate Stage";

        }
        if (t == f1.a3)
        {
            TextBox10.Text = "Abnormal";
            TextBox11.Text = f2.a101;
            TextBox12.Text = "Final Stage";

        }
        if (t == f1.a4)
        {
            TextBox10.Text = "Abnormal";
            TextBox11.Text = f2.a102;
            TextBox12.Text = "Intial Stage";


        }
        if (t == f1.a5)
        {
            TextBox10.Text = "Abnormal";
            TextBox11.Text = f2.a102;
            TextBox12.Text = "Moderate Stage";

        }
        if (t == f1.a6)
        {
            TextBox10.Text = "Abnormal";
            TextBox11.Text = f2.a102;
            TextBox12.Text = "Final Stage";

        }
        //  Label7.Text = img2+str;
        
        
    }
    protected void FileUpload1_Load(object sender, EventArgs e)
    {

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {


        
       
        
    }
}