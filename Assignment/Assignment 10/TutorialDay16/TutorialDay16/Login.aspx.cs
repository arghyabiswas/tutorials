using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace TutorialDay16
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(loginid.Text, password.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(loginid.Text, false);
            }

            else
            {
                label.Text = "Invalid Username or Password";
            }
        }
    }
}