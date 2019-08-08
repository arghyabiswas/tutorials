<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxContactUs.aspx.cs" Inherits="TutorialDay17.AjaxContactUs" %>

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
                    <asp:TextBox runat="server" ID="TextBox1" Height="20px" placeholder="Enter your Name" BackColor="SkyBlue" BorderColor="Blue" BorderStyle="Solid" ForeColor="White" Width="152px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Valid Name" ForeColor="Red" ValidationExpression="[A-Z a-z]+"></asp:RegularExpressionValidator>
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Email" BackColor="SkyBlue" BorderColor="Blue" BorderStyle="Solid" Height="20px" style="margin-bottom: 2px" ForeColor="White" Width="152px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Email Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Valid Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <br />
                    <br />
                    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Button1_Click" BackColor="#999999" BorderColor="#66FF33" BorderStyle="Solid" ForeColor="White" Height="33px" style="margin-left: 29px" Width="96px" />
                     &nbsp;<br />
                    <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                <ProgressTemplate>
                    Please Wait...
                </ProgressTemplate>
            </asp:UpdateProgress>

        </div>
    </form>
</body>
</html>
