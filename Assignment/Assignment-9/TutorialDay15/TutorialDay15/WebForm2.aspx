<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TutorialDay15.WebForm2" %>

<%@ Register Src="~/UserControl/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Form2</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:WebUserControl1 runat="server" ID="WebUserControl1" />
    </div>
    </form>
</body>
</html>
