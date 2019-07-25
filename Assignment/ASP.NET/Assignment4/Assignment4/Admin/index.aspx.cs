using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4.Admin
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event button click displays the input in textbox inside the Label in desired output 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonSayHello_Click(object sender, EventArgs e)
        {
            Labeloutput1.Text = TextBoxInputforhellobutton.Text;

        }
    }
}