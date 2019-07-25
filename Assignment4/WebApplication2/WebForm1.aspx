<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server" BackColor="#FF99FF" BorderColor="Black" ForeColor="Black" Height="29px" OnTextChanged="TextBox1_TextChanged" Width="405px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" BackColor="#CC0099" BorderColor="Black" ForeColor="White" Height="33px" OnClick="Button1_Click" Text="Submit" Width="71px" />
        <p>
            <asp:Label ID="Label1" runat="server" EnableTheming="True"></asp:Label>
        </p>
    </form>
</body>
</html>
