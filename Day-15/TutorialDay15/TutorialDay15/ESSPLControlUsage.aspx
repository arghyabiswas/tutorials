<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ESSPLControlUsage.aspx.cs" Inherits="TutorialDay15.ESSPLControlUsage" %>

<%@ Register assembly="ESSPLControls" namespace="ESSPLControls" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
 
        <cc1:SampleControl ID="SampleControl1" runat="server" Text="WelCome to ESSPL" />
    </div>
    </form>
</body>
</html>
