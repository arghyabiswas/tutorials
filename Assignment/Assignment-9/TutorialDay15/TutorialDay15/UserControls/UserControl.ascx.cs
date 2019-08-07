using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutorialDay15.UserControls
{
    public partial class UserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if((TextBoxInput.Text).Trim().Count()!=0)
            {
                LabelDisplayResult.Text = $"Welcome :- {TextBoxInput.Text}";
            }
            else
            {
                LabelDisplayResult.Text = "";
            }
        }
    }
}