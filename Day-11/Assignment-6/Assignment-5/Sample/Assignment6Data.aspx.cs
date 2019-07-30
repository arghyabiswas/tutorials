using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5.Sample
{
    public partial class Assignment6Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            LabelEmail.Text = Convert.ToString(Session["Email"]);
            LabelLastname.Text = Convert.ToString(Session["Lastname"]);
            LabelDepartment.Text = Convert.ToString(Session["Department"]);
            LabelFirstname.Text = Convert.ToString(Session["Firstname"]);

        }

        protected void ButtonGoBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("Assignment5.aspx");
        }
    }
}