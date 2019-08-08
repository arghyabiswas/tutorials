<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TutorialDay16.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            color: #0000FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div>
       <div style="text-align:center"><h2 class="auto-style1">Login Page</h2></div>
    <div style="text-align: center">
        <br />
        <br />
        Username:&nbsp;
 <asp:TextBox ID="loginid" runat="server" Height="25px" Width="200px"></asp:TextBox>

                <br />
        <br />

                Password:&nbsp; 
                <asp:TextBox ID="password" TextMode="Password" runat="server" Height="25px" Width="200px"></asp:TextBox></asp:TableCell>

        <br />
        <div style="text-align:center;color:red">
            <asp:Label ID="label" runat="server"></asp:Label>
        </div>
        <br />
       <div style="text-align:center"> 
           <asp:Button ID="submit" runat="server" Text="Log in" OnClick="submit_Click" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" Height="30px" Width="80px" /></div>
       </div>
    </div>
    </form>
</body>
</html>
