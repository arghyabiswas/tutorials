<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ESSPLControlUsage.aspx.cs" Inherits="TutorialDay15.WebForm3" %>

<%@ Register Assembly="ESSPLControls" Namespace="ESSPLControls" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:SampleControl ID="SampleControl1" runat="server"  Text="Welcome to ESSPL"/>
    </div>
    </form>
</body>
</html>
