using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutorialDay10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PlaceHolder2.Visible = false;
            Label4.Text = "<span style=\"color: red; \">*</span>This is a label From Server";

            l2.Visible = false;
        }
    }
}