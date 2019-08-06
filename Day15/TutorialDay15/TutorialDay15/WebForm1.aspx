<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TutorialDay15.WebForm1" %>

<%@ Register src="UserControls/SampleWebUserControl.ascx" tagname="SampleWebUserControl" tagprefix="essplUc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h1>Web Form 1</h1>

        </div>
        <essplUc:SampleWebUserControl ID="SampleWebUserControl1" runat="server" />
    </form>
</body>
</html>
