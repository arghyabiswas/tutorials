using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5.Sample
{
    public partial class Assignment6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String fname = Session["fn"].ToString(), lname = Session["ln"].ToString(),
                dept = Session["dept"].ToString(), email = Session["email"].ToString();
            lbl1.Text = fname;
            lbl2.Text = lname;
            lbl3.Text = dept;
            lbl4.Text = email;


        }

        protected void lb1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Assignment5.aspx");
        }
    }
}