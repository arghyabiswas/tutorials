<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxContactUs.aspx.cs" Inherits="TutorialDay17.AjaxContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        .auto-style2 {
            font-size: x-large;
            color: #0000FF;
        }
    </style>
    
    </head>
<body style="text-align: center">
<form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
       <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <br />
        <br />

        <span class="auto-style2">Name:&nbsp; </span> &nbsp;<asp:TextBox ID="TextBox1" runat="Server" Height="20px" Width="200px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="Req1" runat="server" ForeColor="Red" ControlToValidate="TextBox1" Text=" * Required"></asp:RequiredFieldValidator>
        <br />
        <br />
        <span class="auto-style2">Email:&nbsp; </span><asp:TextBox ID="TextBox2" runat="Server" TextMode="Email" Height="20px" Width="200px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ControlToValidate="TextBox2" Text=" * Required"></asp:RequiredFieldValidator>

            <br />
        <br />
        <br />

            <asp:Button ID="btnSave" runat="Server" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" Height="30px" onclick="btnSave_Click" Text="Submit" Width="70px" />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" EnableViewState="False" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="X-Large" ForeColor="Red" Visible="False"></asp:Label>
        <br />
        <br />
</ContentTemplate>
           </asp:UpdatePanel>
    <asp:UpdateProgress ID="Up1" runat="Server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
        <span style="color:blue; font-family:'Comic Sans MS'; font-size:larger; align-content:center"> Please wait ...</span>
        <br />
        <br />
        <br />
        <br />
    </ProgressTemplate>
</asp:UpdateProgress>
    </form>
</body>
</html>
