using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_7.Sample
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["SelectedEmployee"] != null)
            {
                IEmployee employee = (IEmployee)Session["SelectedEmployee"];
                LabelEmail.Text = employee.Email;
                LabelEmployeeId.Text = Convert.ToString(employee.EmployeeId);
                LabelName.Text = employee.Name;
                LabelReportingManager.Text = employee.ReportingManager.Name;

                //Session.Abandon();
            }

        }
    }
}