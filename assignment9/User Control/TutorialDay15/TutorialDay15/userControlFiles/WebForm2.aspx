<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TutorialDay15.WebForm2" %>
<%@ Register src="UserControls.ascx" tagname="UserControls" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Web Form 2</h1>
    <p>
        <uc1:UserControls ID="UserControls1" runat="server" />
    </p>
</asp:Content>
