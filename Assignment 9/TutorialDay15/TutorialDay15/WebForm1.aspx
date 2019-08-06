<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TutorialDay15.WebForm1" %>
<%@ Register Src="~/UserControls/UserControl.ascx" TagName="UserControl" TagPrefix="UC" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <UC:UserControl runat="server" />
    </div>
    </form>
</body>
</html>
