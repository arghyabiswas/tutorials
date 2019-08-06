using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_8
{
    public partial class MyApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            Session["Name"] = "Nikolash";
            Session["Name"] = "Bikash";
            Session.Timeout = 10;

            LabelApplicationName.Text = Convert.ToString(Application["ApplicationName"]);
            LabelName.Text = Convert.ToString(Session[ "Name"]);
           
        }
    }
}