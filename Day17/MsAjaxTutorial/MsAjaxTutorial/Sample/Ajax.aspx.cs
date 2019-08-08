using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MsAjaxTutorial
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string startTime;
        string endTime;
        protected void Page_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now.ToLongTimeString();
            //TO display loading...
            Thread.Sleep(2000);
            endTime = DateTime.Now.ToLongTimeString();
        }

        protected void btnTotalPostback_Click(object sender, EventArgs e)
        {
            lblMessage1.Text = string.Format("Showing time by Total PostBack: {0} to {1}", startTime,endTime);
            lblMessage2.Text = string.Format("Showing time by Partial PostBack: {0} to {1}", startTime, endTime);
        }

        protected void btnPartialPostback_Click(object sender, EventArgs e)
        {
            lblMessage1.Text = string.Format("Showing time by Total PostBack: {0} to {1}", startTime, endTime);
            lblMessage2.Text = string.Format("Showing time by Partial PostBack: {0} to {1}", startTime, endTime);
        }

        

        protected void btnTrigger_Click(object sender, EventArgs e)
        {
            lblMessage3.Text = string.Format("Showing time by Using Trigger: {0} to {1}", startTime, endTime);
        }
    }
}