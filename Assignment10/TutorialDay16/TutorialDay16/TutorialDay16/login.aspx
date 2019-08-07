<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TutorialDay16.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="LabelUserName" runat="server" style="font-weight: 700; text-align: left" Text="User Name"></asp:Label>
        </div>
    <div class="auto-style1">
    
        <asp:TextBox ID="TextBox1" runat="server" BorderColor="Silver" Height="26px" Width="225px" placeholder="Enter your username"></asp:TextBox>
        <br />
        <asp:Label ID="LabelPassword" runat="server" style="font-weight: 700" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" BorderColor="Silver" Height="25px" Width="225px" placeholder="Enter your password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonLogin" runat="server" BackColor="Blue" ForeColor="White" Height="27px" OnClick="ButtonLogin_Click" style="font-weight: 700; margin-right: 1px; margin-top: 0px" Text="Login" Width="233px" />
    
    </div>
    </form>
</body>
</html>
