using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleDay13
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Application["TEST"] = "Test Application Value";
                //Session["TEST"] = "Test Session Value";
                ViewState.Add("TEST", "Test ViewState Value ");
            }


            string test = Request["text1"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = string.Format("{0} - {1}", DateTime.Now, ViewState["TEST"]);
        }
    }
}