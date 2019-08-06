<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CallingCustomControl.WebForm1" %>

<%@ Register assembly="SampleCustomControl" namespace="SampleCustomControl" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <cc1:EssplControl ID="EssplControl1" runat="server" Text="Sample text" />
        </div>
    </form>
</body>
</html>
