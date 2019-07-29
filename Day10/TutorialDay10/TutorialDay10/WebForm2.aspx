<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TutorialDay10.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="First Name is required." ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
             <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Email is not in  correct format." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Email is required."></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPsssword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPsssword" ErrorMessage="Password is required."></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="txtPasswordConfirm" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPsssword" ControlToValidate="txtPasswordConfirm" ErrorMessage="Password mismatching."></asp:CompareValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC3300" />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Age"></asp:Label>
            <asp:TextBox ID="txtAge" runat="server" TextMode="Number"></asp:TextBox>
            
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Allowed value between 0 to 100" ControlToValidate="txtAge" MaximumValue="100" MinimumValue="0"></asp:RangeValidator>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">Item 1</asp:ListItem>
                <asp:ListItem Value="2">Item 2</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            
        </div>
    </form>
</body>
</html>
