using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5.Sample
{
    public partial class Assignment_5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["First Name"] = textbox1.Text;
            Session["Last Name"] = textbox2.Text;
            Session["Department"] = dropdownlist.SelectedItem.Text;
            Session["Email"] = textbox3.Text;
            Session["Password"] = textbox4.Text;
            Session["Confirm Password"] = textbox5.Text;

            Response.Redirect("Assignment 6.aspx");

        }
    }
}