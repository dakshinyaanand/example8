using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StatemanagementAndcaching
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.StartsWith("X") || TextBox1.Text.StartsWith("y") || TextBox1.Text.StartsWith("z"))
            {
                HiddenField1.Value = "bad";

            }
            else
                HiddenField1.Value = "good";
            Label1.Text = HiddenField1.Value.ToString();
        }
    }
}