<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TutorialDay15.WebForm2" %>

<%@ Register src="UserControls/UserControl.ascx" tagname="UserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <uc1:UserControl ID="UserControl1" runat="server" />
    </form>
</body>
</html>
