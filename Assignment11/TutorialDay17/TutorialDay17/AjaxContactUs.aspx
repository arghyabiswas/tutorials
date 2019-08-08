<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxContactUs.aspx.cs" Inherits="TutorialDay17.AjaxContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="auto-style1">
                    <asp:TextBox ID="TextBoxName" runat="server" BorderColor="#336699" placeholder="Enter Name" Width="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxName" Display="Dynamic" ErrorMessage="Your name  is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBoxName" ErrorMessage="Your name should be with [A-z] and [a-z]" ForeColor="#CC0000" ValidationExpression="[A-Z a-z]+"></asp:RegularExpressionValidator>
                    <br />
                    <br/>
                    <asp:TextBox ID="TextBoxEmail" runat="server" BorderColor="#336699" placeholder="Enter Email" Width="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxEmail" Display="Dynamic" ErrorMessage="Your Email ID is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Your Email ID should be abc@gmail.com" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <br />
                    <asp:Button ID="ButtonSubmit" runat="server" BackColor="#0033CC" ForeColor="White" OnClick="ButtonSubmit_Click" style="font-weight: 700; height: 26px;" Text="Submit" />
                    <br />
                    <asp:Label ID="LabelError" runat="server"></asp:Label>
                </div>

            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
            <ProgressTemplate>
                <div class="auto-style2">
                    Loading..........
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>

        </div>
    </form>
</body>
</html>
