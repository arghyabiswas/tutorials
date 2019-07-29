<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment 5.aspx.cs" Inherits="Assignment_5.Sample.Assignment_5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center"><h1> Registration Form </h1></div>

    <div>
    <asp:Table ID="StudTable" runat="server" BorderStyle="Dashed" Width="100%">
       
        <asp:TableRow>
            <asp:TableCell Text="First Name"></asp:TableCell>
            <asp:TableCell><asp:TextBox Id="textbox1" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textbox1" ErrorMessage="Please Enter FirstName"  ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="Last Name"></asp:TableCell>
            <asp:TableCell><asp:TextBox Id="textbox2" runat="server" /></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="Email"></asp:TableCell>
            <asp:TableCell><asp:TextBox Id="textbox3" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textbox3"  Display="Dynamic" ErrorMessage="Please Enter Email Id" ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server" ControlToValidate="textbox3" Display="Dynamic" ErrorMessage="Please Enter Valid Email Id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ForeColor="Red" Font-Italic="true"></asp:RegularExpressionValidator></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow> 
            <asp:TableCell Text="Password"></asp:TableCell>
            <asp:TableCell><asp:TextBox Id="textbox4" TextMode="Password" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="textbox4" ErrorMessage="Please Enter Password"  ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="Confirm Password"></asp:TableCell>
            <asp:TableCell><asp:TextBox Id="textbox5" TextMode="Password" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="textbox5"  Display="Dynamic" ErrorMessage="Please Re-enter Password" ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator" runat="server" ControlToCompare="textbox4" ControlToValidate="textbox5" Display="Dynamic" ErrorMessage="Password Mismatch" ForeColor="Red" Font-Italic="true" ></asp:CompareValidator></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" /></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="button1" runat="server" text="SUBMIT" Font-Bold="true" />
            </asp:TableCell>
        </asp:TableRow>

    </asp:Table>
    </div>
    </form>
</body>
</html>
