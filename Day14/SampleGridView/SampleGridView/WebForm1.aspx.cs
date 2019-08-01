using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleGridView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
            }
        }

        void BindGrid()
        {
            gvEmployee.DataSource = DataContext.Employees;
            gvEmployee.DataBind();
        }
        protected void gvEmployee_Sorting(object sender, GridViewSortEventArgs e)
        {
            BindGrid();
            List<IEmployee> employees = gvEmployee.DataSource as List<IEmployee>;

            string lastSortColumnName = Convert.ToString(ViewState["LastSortColumnName"]);

            switch (e.SortExpression)
            {
                case "Name":

                    if (!lastSortColumnName.Equals("Name"))
                    {
                        gvEmployee.DataSource = employees
                            .OrderBy(p => p.Name)
                            .ToList();
                    }
                    else
                    {
                        gvEmployee.DataSource = employees
                            .OrderByDescending(p => p.Name)
                             .ToList();
                    }
                    break;

                case "Email":
                    if (!lastSortColumnName.Equals("Email"))
                    {
                        gvEmployee.DataSource = employees
                            .OrderBy(p => p.Email)
                             .ToList();
                    }
                    else
                    {
                        gvEmployee.DataSource = employees
                            .OrderByDescending(p => p.Email)
                             .ToList();
                    }
                    break;

                default:
                    if (!lastSortColumnName.Equals("Employeeid"))
                    {
                        gvEmployee.DataSource = employees
                            .OrderBy(p => p.Employeeid)
                             .ToList();
                    }
                    else
                    {
                        gvEmployee.DataSource = employees
                            .OrderByDescending(p => p.Employeeid)
                             .ToList();
                    }
                    break;
            }

            ViewState["LastSortColumnName"] = e.SortExpression;
            gvEmployee.DataBind();

        }

        protected void gvEmployee_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            BindGrid();
            gvEmployee.PageIndex = e.NewPageIndex;
            gvEmployee.DataBind();
        }

        protected void gvEmployee_RowEditing(object sender, GridViewEditEventArgs e)
        {
            BindGrid();
            gvEmployee.EditIndex = e.NewEditIndex;
            gvEmployee.DataBind();
        }

        protected void gvEmployee_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow currentRow = gvEmployee.Rows[e.RowIndex];

            HiddenField employeeHidden = currentRow.FindControl("hidEmployeeId") as HiddenField;
            int employeeId = Convert.ToInt32(employeeHidden.Value);
            IEmployee employee = DataContext.Employees.FirstOrDefault(p => p.Employeeid == employeeId);
            employee.Name = Convert.ToString(e.NewValues["Name"]);
            employee.Email = Convert.ToString(e.NewValues["Email"]);

            DropDownList managerDropdownList = currentRow.FindControl("ddlManager") as DropDownList;
            if (string.IsNullOrEmpty(managerDropdownList.SelectedValue))
            {
                employee.ReportingManager = null;
            }
            else
            {
                int selectedManagerId = Convert.ToInt32(managerDropdownList.SelectedValue);
                IEmployee manager = DataContext.Employees
                    .FirstOrDefault(p => p.Employeeid == selectedManagerId);
                employee.ReportingManager = manager;
            }
            gvEmployee.EditIndex = -1;
            BindGrid();
        }

        protected void gvEmployee_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            BindGrid();
            gvEmployee.EditIndex = -1;
            gvEmployee.DataBind();
        }


        protected void gvEmployee_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int employeeId = Convert.ToInt32(e.Values["Employeeid"]);
            IEmployee employee = DataContext.Employees.FirstOrDefault(p => p.Employeeid == employeeId);
            DataContext.Employees.Remove(employee);
            BindGrid();
        }

        protected void gvEmployee_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            BindGrid();
            gvEmployee.SelectedIndex = e.NewSelectedIndex;

        }

        protected void gvEmployee_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    DropDownList managerDropdownList = e.Row.FindControl("ddlManager") as DropDownList;
                    managerDropdownList.DataSource = DataContext.Employees
                                                    .Where(p => p.ReportingManager == null)
                                                    .ToList();
                    managerDropdownList.DataTextField = "Name";
                    managerDropdownList.DataValueField = "Employeeid";
                    managerDropdownList.DataBind();
                    managerDropdownList.Items.Insert(0, new ListItem("--Select--", ""));

                    IEmployee employee = e.Row.DataItem as Employee;
                    if (employee != null && employee.ReportingManager != null)
                    {
                        managerDropdownList.SelectedValue = Convert.ToString(employee.ReportingManager.Employeeid);
                    }
                }
            }
        }
    }
}
