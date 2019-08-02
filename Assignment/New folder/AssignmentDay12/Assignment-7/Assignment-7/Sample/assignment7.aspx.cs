using EmployeeModel.BusinessLogic.Classes;
using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_7.Sample
{
    public partial class assignment7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListEmployee.DataSource = DataContext.Employees;
                DropDownListEmployee.DataTextField = "Name";
                DropDownListEmployee.DataValueField = "EmployeeId";

                DropDownListEmployee.DataBind();
                DropDownListEmployee.Items.Insert(0, new ListItem("**************Select Employee***************", ""));
            }

        }

        protected void DropDownListEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownListEmployee.SelectedItem.Value != string.Empty)
            {
                int selectedItem = Convert.ToInt32(DropDownListEmployee.SelectedItem.Value);
                if (selectedItem <= 14 && selectedItem > 0)
                {
                    if (selectedItem == 1 || selectedItem == 2)
                    {
                        List<IEmployee> myEmployee = DataContext.Employees;
                        var empDetails = myEmployee.Find(m => m.EmployeeId == selectedItem);
                        ViewState["SelectedEmployee"] = empDetails;
                        Server.Transfer("EmployeeDetails.aspx");

                    }
                    else
                    {
                        List<IEmployee> myEmployee = DataContext.Employees;
                        var empDetails = myEmployee.Find(m => m.EmployeeId == selectedItem);
                        Session["SelectedEmployee"] = empDetails;
                        Response.Redirect("EmployeeDetails.aspx");
                    }
                }


            }

        }
    }
}