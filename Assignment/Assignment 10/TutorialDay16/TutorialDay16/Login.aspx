<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TutorialDay16.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
       <div style="text-align:center"><h2>Login Page</h2></div>
    <div>
        <asp:Table ID="Table1" HorizontalAlign="Center" runat="server">
            <asp:TableRow>
                <asp:TableCell> Login Id: </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="loginid" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Password: </asp:TableCell>
                <asp:TableCell><asp:TextBox ID="password" TextMode="Password" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
        <div style="text-align:center;color:red">
            <asp:Label ID="label" runat="server"></asp:Label>
        </div>
        <br />
       <div style="text-align:center"> 
           <asp:Button ID="submit" runat="server" Text="SUBMIT" OnClick="submit_Click" /></div>
       </div>
    </div>
    </form>
</body>
</html>
