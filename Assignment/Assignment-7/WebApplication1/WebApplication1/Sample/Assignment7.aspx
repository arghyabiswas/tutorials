<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Assignment7.aspx.cs" Inherits="WebApplication1.Sample.Assignment7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Employee List"></asp:Label>
    
    <asp:DropDownList ID="DropDownListEmployee" runat="server" OnSelectedIndexChanged="DropDownListEmployee_SelectedIndexChanged" AutoPostBack="true">

    </asp:DropDownList>


</asp:Content>
