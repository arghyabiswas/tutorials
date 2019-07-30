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

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string email = TextBoxEmail.Text;
            string firstname = TextBoxFirstname.Text;
            string lastname = TextBoxLastname.Text;
            string password = TextBoxPassword.Text;
            string department = DropDownListDepartment.SelectedItem.Text;
            string confirmPassword = TextBoxConfirmPassword.Text;
            if (email != string.Empty && firstname != string.Empty && password != string.Empty && confirmPassword != string.Empty)
            {
                if (password == confirmPassword)
                {
                    Session["Email"] = email;
                    Session["Firstname"] = firstname;
                    Session["Lastname"] = lastname;
                    Session["Department"] = department;
                    Response.Redirect("Assignment6Data.aspx");
                }
            }
            Response.Redirect("Assignment5.aspx");
        }
    }
}