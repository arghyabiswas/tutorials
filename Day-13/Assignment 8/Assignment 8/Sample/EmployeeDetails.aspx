<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="Assignment_8.Sample.EmployeeDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <asp:GridView ID="GridViewEmployeeData" runat="server" AutoGenerateColumns="False" Width="100%">
            <Columns>
                <asp:BoundField DataField="EmployeeId" HeaderText="Employee Id" />
                <asp:BoundField DataField="Name" HeaderText="Employee Name" />
                <asp:BoundField DataField="Email" HeaderText="Employee e-Mail" />
                <asp:BoundField DataField="ReportingManager.Name" HeaderText="Reporting Manager" />
                <asp:BoundField DataField="ReportingManager.Email" HeaderText="Reporting Manager Email" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="ButtonReturn" runat="server" Text="Back" CssClass="btn btn-success" OnClick="ButtonReturn_Click" />
</asp:Content>
