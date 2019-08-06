<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EssplControlUsage.aspx.cs" Inherits="EssplControlWebApplication.WebForms.EssplControlUsage" %>
<%@ Register assembly="ESSPLControls" namespace="ESSPLControls" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <cc1:SampleControl ID="SampleControl1" runat="server" />
</asp:Content>
