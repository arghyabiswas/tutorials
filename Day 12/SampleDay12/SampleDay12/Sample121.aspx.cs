using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleDay12
{
    public partial class Sample121 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["name"] != null)
            {
                //litResult.Text = string.Format("Session Name: {0}", Convert.ToString(Session["name"]));
                //litResult.Text = string.Format("Session Name: {0}", Session["name"].ToString());

                litResult.Text = string.Format("Session Name: {0}", Convert.ToString(ViewState["name"]));

                //if (!string.IsNullOrEmpty(Request.QueryString["name"]))
                //{
                //    string name = Request.QueryString["name"];

                //    litResult.Text = string.Format("Session Name: {0}", name);
                //}
            }



            //int i = 10;
            //Convert.ToString(i);
            //i.ToString()
        }
    }
}