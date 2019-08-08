<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MsAjaxTutorial.Sample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btcTotalPostback" runat="server" Text="TOTAL POSTBACK" OnClick="btcTotalPostback_Click" />
            <asp:Label ID="lblMessage1" runat="server"></asp:Label>
            <hr />

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Button ID="btnAjax" runat="server" Text="AJAX CALL" OnClick="btnAjax_Click" />
                    <asp:Label ID="lblMessage2" runat="server"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <div>Loading...</div>
                </ProgressTemplate>
            </asp:UpdateProgress>

            <hr />

            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:Label ID="lblMessage3" runat="server"></asp:Label>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnAjaxOutside" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>

            <asp:Button ID="btnAjaxOutside" runat="server" Text="AJAX CALL FROM OUTSIDE" OnClick="btnAjaxOutside_Click" />
        </div>
    </form>
</body>
</html>
