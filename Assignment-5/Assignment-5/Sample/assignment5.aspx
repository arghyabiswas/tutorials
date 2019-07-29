<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignment5.aspx.cs" Inherits="Assignment_5.Sample.assignment5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server" Width="100%" Height="60%" rules="all" HorizontalAlign="Center" BorderWidth="1px" BorderStyle="Solid" BorderColor="Black">
                <asp:TableHeaderRow HorizontalAlign="Center">
                    <asp:TableHeaderCell HorizontalAlign="Center" Text="Field label" Width="50%" Height="40px" BackColor="Blue" ForeColor="White"></asp:TableHeaderCell>
                    <asp:TableHeaderCell HorizontalAlign="Center" Text="Input" Width="50%"  Height="40px" BackColor="Blue" ForeColor="White"></asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell Text="First name: " HorizontalAlign="Center" Height="40px"></asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center"  Height="40px">
                        <asp:TextBox runat="server" ID="tb1" Height="20px" Width="250px">
                        </asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="tb1" runat="server" ForeColor="Red" Font-Names="Comic Sans MS" ErrorMessage="*First name can't be empty"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Text="Last name: " HorizontalAlign="Center"  Height="40px"></asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center"  Height="40px">
                        <asp:TextBox runat="server" ID="tb2" Height="20px" Width="250px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Text="Department: " HorizontalAlign="Center"  Height="40px"></asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center"  Height="40px">
                        <asp:DropDownList runat="server">
                            <asp:ListItem Text="Computer Science" Value="a"></asp:ListItem>
                            <asp:ListItem Text="Chemical" Value="b"></asp:ListItem>
                            <asp:ListItem Text="Electrical" Value="c"></asp:ListItem>
                            <asp:ListItem Text="Automobile" Value="d"></asp:ListItem>
                            <asp:ListItem Text="MCA" Value="e"></asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Text="Email: " HorizontalAlign="Center"  Height="40px"></asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center"  Height="40px">
                        <asp:TextBox runat="server" ID="tb3" Height="20px" Width="250px" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" Font-Names="Comic Sans MS" runat="server" ControlToValidate="tb3" ErrorMessage="*email can't be empty"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Text="Password: " HorizontalAlign="Center"  Height="40px"></asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center"  Height="40px">
                        <asp:TextBox runat="server" ID="tb4" Height="20px" Width="250px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" Font-Names="Comic Sans MS" ErrorMessage="*password is a required field" ControlToValidate="tb4"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Text="Confirm password: " HorizontalAlign="Center"  Height="40px"></asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center"  Height="40px">
                        <asp:TextBox runat="server" ID="tb5" Height="20px" Width="250px" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" ForeColor="Red" Font-Names="Comic Sans MS"  runat="server" ErrorMessage="*No match" ControlToValidate="tb5" ControlToCompare="tb4"></asp:CompareValidator>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Names="Comic Sans MS" ForeColor="Red" Visible="True"/>
            <br />
            <asp:Button runat="server" HorizontalAlign="Right" Text="Submit" ID="btn1" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" Height="35px" Width="80px" />
        </div>
    </form>
</body>
</html>
