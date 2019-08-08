<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmployeeGrid.ascx.cs" Inherits="MsAjaxTutorial.Sample.UserControls.EmployeeGrid" %>

<asp:GridView ID="gvEmployee" runat="server" AutoGenerateColumns="False" Width="100%"
    PageSize="10" AllowPaging="True" OnPageIndexChanging="gvEmployee_PageIndexChanging"
    AllowSorting="True" OnSorting="gvEmployee_Sorting"
    OnRowEditing="gvEmployee_RowEditing"
    OnRowUpdating="gvEmployee_RowUpdating"
    OnRowCancelingEdit="gvEmployee_RowCancelingEdit"
    OnRowDeleting="gvEmployee_RowDeleting"
    OnRowDataBound="gvEmployee_RowDataBound">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="EmployeeId" HeaderText="Employee Id" SortExpression="EmployeeId" ReadOnly="True" />
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />

        <asp:TemplateField HeaderText="Manager">
            <ItemTemplate>
                <%# Eval("ReportingManager.Name") %>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:HiddenField ID="hidEmployeeId" runat="server" Value='<%#Eval("EmployeeId") %>' />
                <asp:DropDownList ID="ddlManager" runat="server"></asp:DropDownList>
            </EditItemTemplate>
        </asp:TemplateField>

        <asp:CommandField ButtonType="Button" HeaderText="#" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />

    </Columns>
    <PagerSettings Mode="NextPreviousFirstLast" />
    <PagerStyle HorizontalAlign="Center" />
</asp:GridView>
