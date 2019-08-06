<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TutorialDay15.WebForm1" %>
<%@ Register src="UserControls.ascx" tagname="UserControls" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Web Form 1</h1>
    <uc1:UserControls ID="UserControls1" runat="server" />
</asp:Content>
