using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5.Sample
{
    public partial class Assignment6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelFirstname.Text = Session["firstname"].ToString();//it will through null exception if null value wil be there in session var 
            LabelLastname.Text = Convert.ToString(Session["lastname"]);
            LabelEmail.Text = Convert.ToString(Session["email"]);

        }

        protected void ButtonGoBack_Click(object sender, EventArgs e)
        {

            Response.Redirect("WebForm1.aspx");
        }
    }
}