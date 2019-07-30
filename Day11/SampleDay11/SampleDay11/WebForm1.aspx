<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SampleDay11.WebForm1" MasterPageFile="~/Site.Master" %>




<asp:Content ContentPlaceHolderID="MainContent" runat="server" ID="Content1">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="@ # $ % is not allowed." OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        <hr />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <hr />
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple"></asp:ListBox>
        <hr />
        <a href="http://www.google.com">Go to Google</a>
        <hr />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="WebForm2.aspx">Go to WebForm2</asp:HyperLink>
        <hr />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Go to WebForm2 using Button</asp:LinkButton>
        <hr />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
</asp:Content>

