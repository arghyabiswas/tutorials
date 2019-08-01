using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

            Session["firstname"] = TextboxFirstName.Text;
            Session["lastname"] = TextboxLastname.Text;
            Session["department"] = Dropdown1.SelectedItem.Text;
            Session["email"] = TextboxEmail.Text;
            Response.Redirect("Assignment-6.aspx");
              
            
        }
      
    }
}