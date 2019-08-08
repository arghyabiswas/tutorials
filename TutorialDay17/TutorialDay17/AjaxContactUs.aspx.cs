using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutorialDay17
{
    public partial class AjaxContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            lblMessage.Visible = true;
            if (String.IsNullOrEmpty(TextBox1.Text.ToString()) || String.IsNullOrEmpty(TextBox2.Text.ToString()))
                lblMessage.Text = "Some fileds aren't filled !!";
            else
                lblMessage.Text = "Success !!";
            

        }
    }
}