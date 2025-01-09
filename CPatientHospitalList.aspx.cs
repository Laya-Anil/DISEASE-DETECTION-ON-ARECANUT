using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;

public partial class CPatientHospitalList : System.Web.UI.Page
{
    DbConnection con = new DbConnection();
    DbConnection ob = new DbConnection();
    DataSet ds = new DataSet();
    public static string fpath = "", s = "", mode = "", str1 = "", pp = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        // Session["uname"] = "nichu123";
      //  Label1.Text = Session["pname"].ToString();
        BindData();
    }
    public int CurrentPageIndex
    {
        get
        {
            if (ViewState["pg"] == null)
                return 0;
            else
                return Convert.ToInt16(ViewState["pg"]);
        }
        set
        {
            ViewState["pg"] = value;
        }
    }
    int pg = 0;
    protected void BindData()
    {
        CurrentPageIndex = 0;
        ds.Tables.Clear();


        PagedDataSource pgd = new PagedDataSource();
        string cmdstr = "select * from register where username='" + Session["uname"].ToString() + "'";

        //  string str = "select * from design";
        ds = con.ret_ds(cmdstr);
        pgd.DataSource = ds.Tables[0].DefaultView;
        pgd.CurrentPageIndex = CurrentPageIndex;
        pgd.AllowPaging = true;
        pgd.PageSize = 12;
        // LinkButton1.Enabled = !(pgd.IsLastPage);
        // LinkButton2.Enabled = !(pgd.IsFirstPage);

        DataList1.DataSource = pgd;
        DataList1.DataBind();
    }
    protected void DataList1_CancelCommand(object source, DataListCommandEventArgs e)
    {

    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}