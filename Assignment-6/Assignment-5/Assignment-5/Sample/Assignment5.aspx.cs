using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5.Sample
{
    public partial class Assgnment5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Session["fn"] = tb1.Text;
            Session["ln"] = tb2.Text;
            Session["dept"] = ddl.SelectedItem.Text;
            Session["email"] = tb3.Text;
            Response.Redirect("assignment6.aspx");
        }
    }
}