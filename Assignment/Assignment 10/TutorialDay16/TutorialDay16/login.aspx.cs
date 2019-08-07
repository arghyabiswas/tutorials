using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace TutorialDay16
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(UsernameE.Text, PasswordE.Text))
            {
                //if (UsernameE.Text == "admin" && PasswordE.Text == "admin@123")
                //    Server.Transfer("Sample/AdminHome.aspx");
                FormsAuthentication.RedirectFromLoginPage(UsernameE.Text, chkboxPersist.Checked);


            }
            else {
                msg.Text = "Invalid User Name and/or Password";
            }
        }
    }
}