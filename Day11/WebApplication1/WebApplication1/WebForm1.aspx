﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>    
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="@ # %  is not allowed " OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="jj">hgh</asp:ListItem>
            <asp.ListItem Value
        </asp:DropDownList>
    </form>
</body>
</html>