using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class viewgallery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L3P6L8R\SQLEXPRESS;Initial Catalog=PulseGymDB;Integrated Security=True");
        con.Open();

        SqlDataAdapter dn = new SqlDataAdapter("SELECT IMAGES FROM Gallery", con);
        DataSet ds = new DataSet();
        dn.Fill(ds, "Gallery");
        Repeater1.DataSource = ds.Tables["Gallery"];
        Repeater1.DataBind();
        con.Close();
    }
}