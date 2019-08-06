<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Assignment7.aspx.cs" Inherits="Assignment_5.Sample.Assignment7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" ID="labelemp" Text="EMPLOYEE TYPE :"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList AutoPostBack="true" ID="dropdownemp" runat="server" OnSelectedIndexChanged="dropdownemp_SelectedIndexChanged"></asp:DropDownList>
</asp:Content>
