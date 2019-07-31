using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string firstname = TextBoxFirstName.Text;
            string lastname = TextBoxLastName.Text;
            string email = TextBoxEmail.Text;
            string department = DropDownListDept.SelectedItem.Text;
            string password = TextBoxPassword.Text;
            string confirmPassword = TextBoxConfirmPassword.Text;

            if(firstname!=string.Empty&& email!=string.Empty&&password!=string.Empty)
            {
                if(password==confirmPassword)
                {
                    Session["firstname"] = firstname;
                    Session["lastname"] = lastname;
                    Session["Email"] = email;
                    Session["department"] = department;

                    Response.Redirect("Assignment6.aspx");
                }
            }

        }
    }
}