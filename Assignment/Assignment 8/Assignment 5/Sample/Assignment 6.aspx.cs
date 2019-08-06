using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5
{
    public partial class Assignment_61 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelFirstname.Text = Convert.ToString(Session["First Name"]);
            LabelLastname.Text = Convert.ToString(Session["Last Name"]);
            LabelEmail.Text = Convert.ToString(Session["Email"]);
            LabelDepartment.Text = Convert.ToString(Session["Department"]);

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            Server.Transfer("Assignment 5.aspx");
        }
    }
}