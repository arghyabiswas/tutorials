using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5.Sample
{
    public partial class assignment_5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Button1_Click1(object sender, EventArgs e)
        
        {
            //Store data entered in Textbox in session objects
            Session["FirstName"] = Textbox1.Text;
            Session["LastName"] = Textbox2.Text;
            Session["Department"] = Dropdown1.SelectedItem.Text;
            Session["Email"] = Textbox3.Text;
            Response.Redirect("Assignment 6.aspx");
        }
    }
}