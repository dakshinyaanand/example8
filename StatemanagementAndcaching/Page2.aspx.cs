using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StatemanagementAndcaching
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string n = Request.QueryString["v1"].ToString();
            int age = int.Parse(Request.QueryString["v2"]);
            string em = Request.QueryString["v3"].ToString();
            Response.Write(n + "<br/>" + age + "<br/>" + em);
        }
    }
}