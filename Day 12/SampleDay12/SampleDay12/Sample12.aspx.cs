using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleDay12
{
    public partial class Sample12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session.SessionID

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Application["name"] = txtName.Text;

            //Session["name"] = txtName.Text;

            ViewState["name"] = txtName.Text;

            //Response.Redirect("Sample121.aspx");
            Server.Transfer("Sample121.aspx");
        }
    }
}