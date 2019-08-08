using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MsAjaxTutorial.Sample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
        }

        protected void btcTotalPostback_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();

            lblMessage1.Text = "Server time called by total submit: " + time;
            lblMessage2.Text = "Server time called by AJAX: " + time;
            lblMessage3.Text = "Server time called by Ajax outside of update panel: " + time;
        }

        protected void btnAjax_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();

            lblMessage1.Text = "Server time called by total submit: " + time;
            lblMessage2.Text = "Server time called by AJAX: " + time;
            lblMessage3.Text = "Server time called by Ajax outside of update panel: " + time;
        }

        protected void btnAjaxOutside_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();

            lblMessage1.Text = "Server time called by total submit: " + time;
            lblMessage2.Text = "Server time called by AJAX: " + time;
            lblMessage3.Text = "Server time called by Ajax outside of update panel: " + time;
        }
    }
}