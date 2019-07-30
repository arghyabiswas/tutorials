using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleDay11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<Manager> managers = new List<Manager>();
        protected void Page_Load(object sender, EventArgs e)
        {
            managers.Add(new Manager()
            {
                Id = 1,
                Name = "Manager 1"
            });

            managers.Add(new Manager()
            {
                Id = 2,
                Name = "Manager 2"
            });

            DropDownList1.DataSource = managers;
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();


            ListBox1.DataSource = managers;
            ListBox1.DataTextField = "Name";
            ListBox1.DataValueField = "Id";
            ListBox1.DataBind();

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string[] notAllowdCharecters = new string[4];

            notAllowdCharecters[0] = "@";
            notAllowdCharecters[1] = "#";
            notAllowdCharecters[2] = "$";
            notAllowdCharecters[3] = "%";

            bool isValid = true;


            for (int i = 0; i < notAllowdCharecters.Length; i++)
            {
                if(TextBox1.Text.Contains(notAllowdCharecters[i]) == true)
                {
                    isValid = false;
                    break;
                }
            }

            args.IsValid = isValid;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }

    class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}