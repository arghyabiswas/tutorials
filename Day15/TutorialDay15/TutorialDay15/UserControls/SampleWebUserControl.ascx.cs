using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutorialDay15.UserControls
{
    public partial class SampleWebUserControl : System.Web.UI.UserControl
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Load of User Control");
        }

        

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Welcome :" + txtSample.Text;
        }
    }
}