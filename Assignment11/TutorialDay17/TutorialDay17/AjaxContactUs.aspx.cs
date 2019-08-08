using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutorialDay17
{
    public partial class AjaxContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            LabelResult.Text = "You are in...";
        }

        protected void Unnamed1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}