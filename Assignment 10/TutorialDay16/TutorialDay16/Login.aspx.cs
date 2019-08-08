﻿using System;
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

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(TextBox1.Text, TextBox2.Text))
            {
                Label3.Text = " ";
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, true);
            }
            else
            {
                Label3.Text = "Invalid Username or Password.";
            }
        }
    }
}