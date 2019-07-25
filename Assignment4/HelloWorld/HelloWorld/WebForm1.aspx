<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HelloWorld.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server" BackColor="#99CCFF" BorderColor="Black" Height="27px" style="margin-left: 0px; margin-top: 0px" Width="367px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" BackColor="#3366FF" BorderColor="Black" Height="32px" OnClick="Button1_Click" Text="Submit" Width="92px" />
        <p style="width: 350px">
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
