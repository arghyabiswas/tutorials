using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String[] notallowedchar= new string[4];
            notallowedchar[0] = "@";
            notallowedchar[1] = "#";
            notallowedchar[2] = "$";
            notallowedchar[3] = "%";
            bool isvalid = true;
            for (int i = 0; i < 4; i++)
            {
                if (TextBox1.Text.Contains( notallowedchar[i]) == true )
                    isvalid = false;
                break;
            }
            args.IsValid = isvalid;

        }
    }
}