<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TutorialDay15.WebForm2" %>

<%@ Register src="UserControls/WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
    </div>
        
    </form>
</body>
</html>
