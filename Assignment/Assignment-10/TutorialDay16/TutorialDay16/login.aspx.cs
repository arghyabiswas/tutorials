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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(FormsAuthentication.Authenticate(TextBox_UserName.Text,TextBox_PassWord.Text))
            {
                Label_Text.Text = " ";
                FormsAuthentication.RedirectFromLoginPage(TextBox_UserName.Text, false);
            }
            else
            {
                Label_Text.Text = "...Invalid UserName Or PassWord...";
            }
        }
    }
}