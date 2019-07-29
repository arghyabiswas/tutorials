<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Assignment4.Admin.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" BorderWidth="1px" Font-Bold="False" Font-Size="Large" Height="20px" OnTextChanged="Page_Load" Width="200px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" BorderStyle="Solid" BorderWidth="1px" Font-Bold="False" Font-Size="Large" Height="30px" OnClick="Button1_Click" Text="Say Hello" Width="90px" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="X-Large" ForeColor="Red" Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
