<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ESSPLControlUsage.aspx.cs" Inherits="TutorialDay15.ESSPLControlUsage" %>

<%@ Register Assembly="ESSPLControls" Namespace="ESSPLControls" TagPrefix="cc1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ESSPLControlUsage</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">
        <cc1:SampleControl ID="SampleControl1" runat="server"  Text="WELCOME TO ESSPL"/>
    </div>
    </form>
</body>
</html>
