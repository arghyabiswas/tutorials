<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Assignment8.aspx.cs" Inherits="Assignment5.Assignment8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <div style="text-align:center"> <asp:Label ID="Label1" runat="server" Text="Select Manager"></asp:Label>
    <asp:DropDownList ID="DropDownListManager" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListManager_SelectedIndexChanged">
    </asp:DropDownList>
      </div> 
</asp:Content>
