﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxContactUs.aspx.cs" Inherits="TutorialDay17.AjaxContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">

                <ContentTemplate>
                    <asp:TextBox runat="server" ID="TextBoxName" Height="20px" placeholder="Enter your Name" BackColor="#FF3300" BorderColor="#0033CC" BorderStyle="Double" ForeColor="Black" Width="152px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxName" ErrorMessage="Name field can't be empty" ForeColor="Black"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxName" ErrorMessage="Invalid Name it should contain alphabates only" ForeColor="Black" ValidationExpression="[A-Z a-z]+"></asp:RegularExpressionValidator>
                    <br />
                    <asp:TextBox ID="TextBoxEmail" runat="server" placeholder="Enter Email" BackColor="#FF3300" BorderColor="#0033CC" BorderStyle="Double" Height="20px" style="margin-bottom: 2px" ForeColor="Black" Width="152px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email field can't be empty" ForeColor="Black"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Invalid Email, It should look like abc@xyz.com" ForeColor="Black" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <br />
                    <br />
                    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Button1_Click" BackColor="#FF3300" BorderColor="#0033CC" BorderStyle="Double" ForeColor="Black" Height="33px" style="margin-left: 29px" Width="96px" />
                     &nbsp;<br />
                    <asp:Label ID="LabelResult" runat="server" Text="Label"></asp:Label>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                <ProgressTemplate>
                    Loading...
                </ProgressTemplate>
            </asp:UpdateProgress>

        </div>
    </form>
</body>
</html>
