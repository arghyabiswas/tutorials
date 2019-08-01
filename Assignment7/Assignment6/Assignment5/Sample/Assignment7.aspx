<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Assignment7.aspx.cs" Inherits="Assignment5.Sample.Assignment7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="Employees" runat="server"
        AutopostBack="true"
         OnSelectedIndexChanged="Employees_SelectedIndexChanged">
    </asp:DropDownList>
</asp:Content>
