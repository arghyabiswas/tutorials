<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TutorialDay15.WebForm1" %>

<%@ Register Src="~/UserControls/UserControl.ascx" TagPrefix="uc1" TagName="UserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div Style="margin-left: 40vw; margin-top: 20vh;">

            <uc1:UserControl runat="server" ID="UserControl"/>

        </div>
    </form>
</body>
</html>
