<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="MsAjaxTutorial.Sample.AddEmployee" %>

<%@ Register Src="~/Sample/UserControls/AddEmployee.ascx" TagPrefix="uc1" TagName="AddEmployee" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <uc1:AddEmployee runat="server" ID="AddEmployee1" />
    <p>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CausesValidation="false" OnClick="btnCancel_Click" />
    </p>
</asp:Content>
