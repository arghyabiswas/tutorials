<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="MsAjaxTutorial.WebForm1" %>

<%@ Register Src="~/Sample/UserControls/EmployeeGrid.ascx" TagPrefix="uc1" TagName="EmployeeGrid" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <p>
        <a href="AddEmployee.aspx">Add Employee</a>
    </p>
    <uc1:EmployeeGrid runat="server" ID="EmployeeGrid" />
</asp:Content>
