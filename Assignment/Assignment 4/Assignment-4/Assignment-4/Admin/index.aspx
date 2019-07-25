<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Assignment_4.Admin.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter your name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="171px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="sayHello" Text="Say Hello" />
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
