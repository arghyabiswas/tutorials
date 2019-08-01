using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5.Sample
{
    public partial class assignment6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (Session["KeyName"] != null)

                //{

                    //get the Session value

                    //string fname = Convert.ToString(Session["fname"]);
                    //string lname = Convert.ToString(Session["lname"]);
                    //string ddlist = Convert.ToString(Session["DDList"]);
                    //string email = Convert.ToString(Session["Email"]);

                    FirstName.Text = Convert.ToString(Session["fname"]);
                    LastName.Text = Convert.ToString(Session["lname"]);
                    course.Text = Convert.ToString(Session["DDList"]);
                    Email.Text = Convert.ToString(Session["Email"]);

                //}
            }
        }

        protected void GoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("assignment5.aspx");
        }
    }
}