<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ESSPLControlUsage.aspx.cs" Inherits="ESSPLWebApplication.ESSPLControlUsage" %>
<%@ Register assembly="ESSPLControls" namespace="ESSPLControls" tagprefix="ec1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <ec1:SampleControl ID="SampleControls1"  runat="server" Text="Welcome to ESSPL" Font-Bold="true" Font-Underline="true" />
    </div>
    </form>
</body>
</html>
