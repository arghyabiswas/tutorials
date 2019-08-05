<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="assignment8.aspx.cs" Inherits="Assignmnet8.Sample.assignment8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center">
      <asp:Label runat="server" ID="labelemp" Text="MANAGER :" Font-Bold="true"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList AutoPostBack="true" ID="dropdownmgr" runat="server" OnSelectedIndexChanged="dropdownemp_SelectedIndexChanged">
    </asp:DropDownList>
        </div>
</asp:Content>