using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5.Sample
{
    public partial class assignment5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, EventArgs e)
        {
            if (DropDownList.Text == "")
            { Result.Text = "Please choose a valid course"; }
                
            else
            { Result.Text = "Data forwarded to the server";
            }
                
            Session["fname"] = FirstNameE.Text;
            Session["lname"] = TextBox2.Text;
            Session["DDList"] = DropDownList.SelectedValue;
            Session["Email"] = EMailE.Text;
            Response.Redirect("assignment6.aspx");
        }
    }
}