using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5.Sample
{
    public partial class Assignment6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelDepartment.Text = Convert.ToString(Session["department"]);
            LabelFirstname.Text = Convert.ToString(Session["firstname"]);
            LabelLastname.Text = Convert.ToString(Session["lastname"]);
            LabelEmail.Text = Convert.ToString(Session["email"]);

        }

        protected void ButtonGoBack_Click(object sender, EventArgs e)
        {

            Server.Transfer("WebForm1.aspx");
        }
    }
}