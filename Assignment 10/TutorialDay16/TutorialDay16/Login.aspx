<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TutorialDay16.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
     <asp:Label ID="Label1" runat="server" Text="Username:" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter userID"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password:" Font-Bold="true"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox2" runat="server"  CssClass="form-control" TextMode="Password" placeholder =" Enter Password"></asp:TextBox>
            <br />
            <asp:Button ID="Button" runat="server" Text="LOGIN" BorderStyle="Solid" OnClick="ButtonLogin_Click" />

            <br />
            <br />

            <asp:Label ID="Label3" runat="server" Font-Bold="true" style="text-align: center"></asp:Label>
        
    </div>
    </form>
</body>
</html>
