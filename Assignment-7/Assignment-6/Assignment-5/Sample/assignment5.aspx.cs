using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5
{
    public partial class Assignment_5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String fname = tb1.Text;
            String lname = tb2.Text;
            String department = dd.SelectedItem.Text;
            String email = tb3.Text;
            String pass1 = tb4.Text;
            String pass2 = tb5.Text;

           if(pass1==pass2)
            {         
                    Session["fname"] = fname;
                    Session["lname"] = lname;
                    Session["department"] = department;
                    Session["email"] = email;
                Response.Redirect("assignment6.aspx");
            }
           
        }
    }
}