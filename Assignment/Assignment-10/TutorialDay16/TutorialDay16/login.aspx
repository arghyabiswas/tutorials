<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TutorialDay16.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LogIn</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">
      User Name :&nbsp;&nbsp;   <asp:TextBox ID="TextBox_UserName" runat="server"></asp:TextBox>
        <br /><br />
      &nbsp;&nbsp;
      Password   :&nbsp; <asp:TextBox ID="TextBox_PassWord" runat="server" TextMode="Password"></asp:TextBox>
        <br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" Width="66px" />
        <br />
        <br />
        <asp:Label ID="Label_Text" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
