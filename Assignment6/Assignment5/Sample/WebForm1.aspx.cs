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

            Session["firstname"] = TextBoxFirstName.Text;
            Session["lastname"] = TextBoxLastName.Text;
            Session["Email"] = TextBoxEmail.Text;
            Session["department"] = DropDownListDept.SelectedItem.Text;

            Response.Redirect("Assignment6.aspx");

        }

    }
}
