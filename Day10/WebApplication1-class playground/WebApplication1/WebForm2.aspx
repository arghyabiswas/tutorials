<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
        <asp:TextBox ID="TextBoxFirstName" runat="server" style="margin-bottom: 2px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxFirstName" ErrorMessage="FirstName is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label6" runat="server" Text="LastName"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </br>
        <p>
            Email:<asp:TextBox ID="TextBoxEmail" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Wrong Email Format, it should end with @xyz.com" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorPassword" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Password Field can't be empty" ForeColor="Red"></asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Conifirm Password"></asp:Label>
            <asp:TextBox ID="TextBoxConfirmPassword" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxConfirmPassword" ErrorMessage="Passwor Mismatch" ForeColor="Red"></asp:CompareValidator>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Department"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="cs">Computer Science</asp:ListItem>
                <asp:ListItem>Chemical</asp:ListItem>
                <asp:ListItem>Electrical</asp:ListItem>
                <asp:ListItem>Automobile</asp:ListItem>
                <asp:ListItem>MCA</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" BackColor="Lime" BorderColor="Black" BorderStyle="Solid" ForeColor="Black" />
        </p>
        <p>
            </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
