using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleDay13
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Label1.Text = Convert.ToString(Application["TEST"]);
            //Label1.Text = Convert.ToString(Session["TEST"]);
            Label1.Text = string.Format("{0} - {1}", DateTime.Now, ViewState["TEST"]);
        }
    }
}