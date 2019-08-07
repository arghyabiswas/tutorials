using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutorialDay16.Sample
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(username.Text, password.Text))
            {
                Error.Text = " ";
                FormsAuthentication.RedirectFromLoginPage(username.Text, true);
            }
            else
            {
                Error.Text = "Invalid Username or Password.";
            }
        }
    }
}