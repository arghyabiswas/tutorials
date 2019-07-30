using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5.Sample
{
    public partial class Assignment_6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Extract the data stored in Session object to textbox
            TextBox1.Text = Convert.ToString(Session["FirstName"]);
            TextBox2.Text = Convert.ToString(Session["LastName"]);
            TextBox3.Text = Convert.ToString(Session["Department"]);
            TextBox4.Text = Convert.ToString(Session["Email"]);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Clicking Go Back button will cause redirection
            Server.Transfer("Assignment-5.aspx");
        }
    }
}