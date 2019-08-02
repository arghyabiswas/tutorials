using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5.Sample
{
    public partial class assignment6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String fname = Convert.ToString(Session["fname"]);
            String lname = Convert.ToString(Session["lname"]);
            String department = Convert.ToString(Session["department"]);
            String email = Convert.ToString(Session["email"]);

            Label1.Text = fname;
            Label2.Text = lname;
            Label3.Text = department;
            Label4.Text = email;
        }

        protected void ButtonGo_Click(object sender, EventArgs e)
        {
            Server.Transfer("assignment5.aspx");
        }
    }
}