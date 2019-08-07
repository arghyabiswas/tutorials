<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="TutorialDay16.Logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ButtonLogout" runat="server" Text="Logout" CssClass="btn form-control btn-danger" OnClick="ButtonLogout_Click" />
        </div>
    </form>
</body>
</html>
