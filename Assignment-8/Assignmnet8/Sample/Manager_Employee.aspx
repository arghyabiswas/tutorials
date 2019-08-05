<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manager_Employee.aspx.cs" Inherits="Assignmnet8.Sample.Manager_Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridViewEmp" runat="server" Width="100%" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="employeeId" HeaderText="EMPLOYEE ID">
                <ControlStyle Font-Bold="True" />
                <HeaderStyle BackColor="White" ForeColor="Black" />
            </asp:BoundField>
            <asp:BoundField DataField="name" HeaderText="EMPLOYEE NAME">
                <ControlStyle BackColor="White" Font-Bold="True" ForeColor="Black" />
            </asp:BoundField>
            <asp:BoundField DataField="email" HeaderText="EMAIL">
                <ControlStyle BackColor="White" Font-Bold="true" ForeColor="Black" />
            </asp:BoundField>
            <asp:BoundField DataField="ReportingManager.email" HeaderText="MANAGER EMAILID">
                <ControlStyle BackColor="White" Font-Bold="true" ForeColor="White" />
            </asp:BoundField>
            <asp:BoundField DataField="ReportingManager.name" HeaderText="MANAGER NAME">
                <ControlStyle BackColor="White" Font-Bold="true" ForeColor="White" />
            </asp:BoundField>
        </Columns>

    </asp:GridView>
</asp:Content>
