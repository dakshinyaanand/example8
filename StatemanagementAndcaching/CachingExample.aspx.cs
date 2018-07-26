using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Caching;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace StatemanagementAndcaching
{
    public partial class CachingExample : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=TrainingDB;Integrated Security=True");
            adp = new SqlDataAdapter("select * from Userinfo", con);
            if (Cache["data"] == null)
            {
                ds = new DataSet();
                adp.Fill(ds, "UserInfo");
                Cache.Add("data", ds, null, DateTime.Now.AddMinutes(2), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Default, null);
                Label1.Text = "from Db";
            }
            else
            {
                ds = (DataSet)Cache["data"];
                Label1.Text = "form cache";
            }
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=TrainingDB;Integrated Security=True");
            adp = new SqlDataAdapter("select * from Userinfo", con);
            if (Cache["data1"] == null)
            {
                ds = new DataSet();
                adp.Fill(ds, "UserInfo");
                Cache.Add("data1", ds, null, DateTime.MaxValue, TimeSpan.FromMinutes(2), System.Web.Caching.CacheItemPriority.Default, null);
                Label1.Text = "from Db";
            }
            else
            {
                ds = (DataSet)Cache["data1"];
                Label1.Text = "form cache";
            }
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=TrainingDB;Integrated Security=True");
            adp = new SqlDataAdapter("select * from Userinfo", con);
            if (Cache["data1"] == null)
            {
                ds = new DataSet();
                adp.Fill(ds, "UserInfo");
                CacheDependency cd = new CacheDependency("C:\\files\\data.txt");

                Cache.Add("data1", ds, cd, DateTime.MaxValue, TimeSpan.FromMinutes(2), System.Web.Caching.CacheItemPriority.Default, null);
                Label1.Text = "from Db";
            }
            else
            {
                ds = (DataSet)Cache["data1"];
                Label1.Text = "form cache";
            }
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

    }
}
