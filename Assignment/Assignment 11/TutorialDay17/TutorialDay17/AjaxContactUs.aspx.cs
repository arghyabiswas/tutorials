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
            Thread.Sleep(1000);
        }

        

        protected void submit_Click1(object sender, EventArgs e)
        {
            lbl.Text = "You have been successfully logged in: " + nametxt.Text;
        }
    }
}