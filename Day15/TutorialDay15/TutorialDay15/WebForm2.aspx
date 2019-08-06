﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TutorialDay15.WebForm2" %>

<%@ Register src="UserControls/SampleWebUserControl.ascx" tagname="SampleWebUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Web Page 2</h1>
        </div>
        <uc1:SampleWebUserControl ID="SampleWebUserControl1" runat="server" />
        <br />
        <uc1:SampleWebUserControl ID="SampleWebUserControl3" runat="server" />
        <br />
        <uc1:SampleWebUserControl ID="SampleWebUserControl2" runat="server" />
    </form>
</body>
</html>
