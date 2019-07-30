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
            string firstname = TextboxFirstName.Text;
            string lastname = TextboxLastname.Text;
            string department = Dropdown1.SelectedItem.Text;
            string email = TextboxEmail.Text;
            string password = TextBoxPassword.Text;
            string ConfirmPassword = TextBoxConfirmPassword.Text;

            if (firstname!=string.Empty && email!=string.Empty && password!=string.Empty)
            {
                if(password==ConfirmPassword)
                {
                    Session["firstname"] = firstname;
                    Session["lastname"] = lastname;
                    Session["department"]= department;
                    Session["email"] = email;
                    Response.Redirect("Assignment-6.aspx");
                }
            }
        }
      
    }
}