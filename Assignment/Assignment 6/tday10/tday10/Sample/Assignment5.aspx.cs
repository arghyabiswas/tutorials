using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tday10
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sbmtbtn1_Click(object sender, EventArgs e)
        {
            Session["tfname"] = firstname.Text;
            Session["tflname"] = lastname.Text;
            Session["tfemail"] = email.Text;
            Session["tfdepartment"] = dlist.SelectedItem.Text;
 


            Response.Redirect("Assiginment6.aspx");
        }

    }
}