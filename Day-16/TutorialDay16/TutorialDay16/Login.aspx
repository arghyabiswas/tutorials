<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TutorialDay16.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/myStyle.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="form-group">
        <div class="container col-md-offset-4">
            <asp:Label ID="LabelName" runat="server" Text="Username:" CssClass="control-label"></asp:Label>
            <asp:TextBox ID="TextBoxName" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="LabelPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server"  CssClass="form-control" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonLogin" runat="server" Text="Login" CssClass="form-control btn btn-primary" OnClick="ButtonLogin_Click" />

            <br />
            <br />

            <asp:Label ID="LabelError" runat="server" CssClass="text-danger h4"></asp:Label>
        </div>
    </form>
</body>
</html>
