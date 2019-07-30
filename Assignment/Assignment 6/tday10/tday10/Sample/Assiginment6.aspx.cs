using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tday10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String efname = Session["tfname"].ToString(), elname = Session["tflname"].ToString(),
                elemail = Session["tfemail"].ToString(), etdept = Session["tfdepartment"].ToString();
            
            fname.Text = efname;
            lname.Text = elname;
            dept.Text = etdept;
            email.Text = elemail;
             

        }
    }
}