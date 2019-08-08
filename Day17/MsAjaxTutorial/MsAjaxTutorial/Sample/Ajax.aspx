<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ajax.aspx.cs" Inherits="MsAjaxTutorial.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AJAX Tutorial</title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="btnTotalPostback" runat="server" OnClick="btnTotalPostback_Click" Text="Total PostBack" />
        </p>
        <asp:Label ID="lblMessage1" runat="server"></asp:Label>
        <hr />
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
        </div>
        <p>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Button ID="btnPartialPostback" runat="server" OnClick="btnPartialPostback_Click" Text="Partial PostBack" />
                    <br />
                    <asp:Label ID="lblMessage2" runat="server"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </p>
        <hr />
        <p>
           Submit button is Outside the Update Panel
        </p>
        <p>
            <asp:Button ID="btnTrigger" runat="server" Text="Using Trigger" OnClick="btnTrigger_Click" />
        </p>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server"
            UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="lblMessage3" runat="server" />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnTrigger"
                    EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        

        <asp:UpdateProgress ID="UpdateProgress1" runat="server" DynamicLayout="true" >

            <ProgressTemplate>
                Loading...
            </ProgressTemplate>

        </asp:UpdateProgress>

    </form>
</body>
</html>
