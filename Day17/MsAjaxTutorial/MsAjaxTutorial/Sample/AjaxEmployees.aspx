<%@ Page Title="Axax" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AjaxEmployees.aspx.cs" Inherits="MsAjaxTutorial.Sample.AjaxEmployees" %>

<%@ Register Src="~/Sample/UserControls/AddEmployee.ascx" TagPrefix="uc1" TagName="AddEmployee" %>
<%@ Register Src="~/Sample/UserControls/EmployeeGrid.ascx" TagPrefix="uc1" TagName="EmployeeGrid" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <p>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <uc1:AddEmployee runat="server" ID="AddEmployee1" Visible="false" />
                <asp:Button ID="btnSave" runat="server" Visible="false" Text="Save" OnClick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" Visible="false" CausesValidation="false" OnClick="btnCancel_Click" />
                <asp:LinkButton ID="lnkAddEmployee" runat="server" Text="Add Employee" OnClick="lnkAddEmployee_Click"></asp:LinkButton>
            </ContentTemplate>
        </asp:UpdatePanel>
    </p>
    <p>
        <asp:UpdatePanel ID="upnlEmployee" runat="server" >
            <ContentTemplate>
                <uc1:EmployeeGrid runat="server" ID="EmployeeGrid" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </p>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" DynamicLayout="true">
        <ProgressTemplate>
            <div class="loader"></div>
        </ProgressTemplate>
    </asp:UpdateProgress>
</asp:Content>

