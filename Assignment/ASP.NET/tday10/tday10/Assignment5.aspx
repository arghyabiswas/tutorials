<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment5.aspx.cs" Inherits="tday10.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>


<body>
    <form id="form1" runat="server">
        <asp:Table ID="Loginform" runat="server" HorizontalAlign="Center" rules="all" Height="400px" Width="100%">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell Text=" Login Fields " HorizontalAlign="Center" Width="50%" Height="30px" Font-Bold="True" ForeColor="Maroon"></asp:TableHeaderCell>
                <asp:TableHeaderCell Text=" Login Input " HorizontalAlign="Center" Height="30"></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell Text=" First Name" HorizontalAlign="Center" Height="25px"></asp:TableCell>
                <asp:TableCell HorizontalAlign="Center" Height="45 ">
                    <asp:TextBox runat="server" ID="firstname" Height="20px" Width="180px" Font-Names="Times New Roman" Font-Italic="True" ForeColor="Fuchsia"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server"  ForeColor="Red" ControlToValidate ="firstname" ID ="nofirstname" ErrorMessage ="First name is a necessary field." ></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Text=" Last Name" HorizontalAlign="Center" Height="25px"></asp:TableCell>
                <asp:TableCell HorizontalAlign="Center" Height="45 ">
                    <asp:TextBox runat="server" ID="lastname" Height="20px" Width="180px" Font-Italic="True" Font-Names="Times New Roman" ForeColor="#9900CC"></asp:TextBox>
                     <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate ="lastname" ID ="nolastname" ErrorMessage ="Last name is a necessary field." ></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Text=" Department" HorizontalAlign="Center" Height="25px"></asp:TableCell>
                <asp:TableCell HorizontalAlign="Center" Height="45 "> <asp:DropDownList runat="server" > <asp:ListItem Text="Computer Science" Value="a"></asp:ListItem>
                            <asp:ListItem Text="Chemical" Value="b"></asp:ListItem>
                            <asp:ListItem Text="Electrical" Value="c"></asp:ListItem>
                            <asp:ListItem Text="Automobile" Value="d"></asp:ListItem>
                            <asp:ListItem Text="MCA" Value="e"></asp:ListItem></asp:DropDownList> </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Text="  Email " HorizontalAlign="Center" Height="25px"></asp:TableCell>
                <asp:TableCell HorizontalAlign="Center" Height="45 ">
                    <asp:TextBox runat="server" ID="email" Height="20px" Width="180px" TextMode="Email" Font-Bold="True" ></asp:TextBox>
                     <asp:RequiredFieldValidator runat="server"  ForeColor="Red" ControlToValidate ="email" ID ="RequiredFieldValidator1" ErrorMessage ="Email is a necessary field." ></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <asp:RegularExpressionValidator ID="expressionchecker" ForeColor="Red" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="email" ErrorMessage="Invalid Email Format"></asp:RegularExpressionValidator>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Text="Password: " HorizontalAlign="Center"></asp:TableCell>
                <asp:TableCell HorizontalAlign="Center">
                    <asp:TextBox runat="server" ID="password" Height="20px" Width="180px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" ControlToValidate="password" ID="passwordentry" ErrorMessage="Password is a mandatory field"></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Text="Confirm password: " HorizontalAlign="Center"></asp:TableCell>
                <asp:TableCell HorizontalAlign="Center">
                    <asp:TextBox runat="server" ID="pswdcnfm" Height="20px" Width="180px" TextMode="Password" ></asp:TextBox>
                    <asp:CompareValidator ID="pswdmtch" ControlToValidate="pswdcnfm" ControlToCompare="password" ForeColor="Red" runat="server" ErrorMessage="Password does not match"    ValueToCompare ="password"></asp:CompareValidator>
                    
                </asp:TableCell>
            </asp:TableRow>

        </asp:Table>
        <br />
        <br />
        <br />
        <asp:ValidationSummary ForeColor="Red" ID ="summary" HeaderText="Error Summary" runat="server" />
        <br />
        <asp:Button runat="server" Text="Submit" />

    </form>
</body>
</html>
