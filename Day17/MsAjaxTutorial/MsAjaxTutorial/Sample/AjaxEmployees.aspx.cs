using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MsAjaxTutorial.Sample
{
    public partial class AjaxEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TO Display Ajax progress
            Thread.Sleep(2000);
        }

        protected void lnkAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee1.Visible = true;
            lnkAddEmployee.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                AddEmployee1.AddNewEmployee();
                AddEmployee1.Visible = false;
                lnkAddEmployee.Visible = true;
                btnSave.Visible = false;
                btnCancel.Visible = false;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            AddEmployee1.Visible = false;
            lnkAddEmployee.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }
    }
}