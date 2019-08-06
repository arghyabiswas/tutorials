﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assignment_5.WebForm1" MasterPageFile="~/Assignment-6.Master" %>

<asp:Content ID="asg5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="table1" runat="server" Width="100%" HorizontalAlign="Center">
                <asp:TableHeaderRow>
                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true" Font-Underline="true">REGISTRATION FORM</asp:TableCell>
                </asp:TableHeaderRow>

                <%--Enter first name which is a compulsory field--%>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="labelFirstName" runat="server" Text="First Name" Font-Bold="true"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextboxFirstName" runat="server" placeholder="Enter First Name"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=" First Name Required" ControlToValidate="TextboxFirstName" ForeColor="Red"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <%--Enter last name--%>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label1" runat="server" Text="Last Name" Font-Bold="true"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextboxLastname" runat="server" placeholder="Enter Last Name"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <%--Department Selection--%>
                <asp:TableRow>
                    <asp:TableCell><asp:Label runat="server" Text="Department" Font-Bold="true"></asp:Label></asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="Dropdown1" runat="server">
                            <asp:ListItem Enabled="true" Text="Select Department" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="Computer Science"></asp:ListItem>
                            <asp:ListItem Text="Chemical"></asp:ListItem>
                            <asp:ListItem Text="Electrical"></asp:ListItem>
                            <asp:ListItem Text="Automobile"></asp:ListItem>
                            <asp:ListItem Text="MCA"></asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <%--Enter Email which has to be a valid email address--%>
                <asp:TableRow>
                    <asp:TableCell><asp:Label runat="server" Text="Email" Font-Bold="true"></asp:Label></asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextboxEmail" runat="server" placeholder="Enter Your Email"></asp:TextBox>
                        <asp:RegularExpressionValidator runat="server" ErrorMessage=" Enter Valid Email Address" ControlToValidate="TextboxEmail" ForeColor="Red" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" Email Required" ControlToValidate="TextboxEmail" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <%--Enter Password--%>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label2" runat="server" Text="Password" Font-Bold="true"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxPassword" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage=" Password Required" ControlToValidate="TextBoxPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <%--Confirm Password which has to match the previously entered password--%>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label3" runat="server" Text="Confirm Password" Font-Bold="true"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxConfirmPassword" runat="server" placeholder="Re-enter Password" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword" runat="server" ErrorMessage=" Password Required" Display="Dynamic" ControlToValidate="TextBoxConfirmPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage=" Password Mismatch" ForeColor="Red" Display="Dynamic" ControlToValidate="TextBoxConfirmPassword" ControlToCompare="TextBoxPassword"></asp:CompareValidator>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <%--Submit Details--%>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Submit" Font-Bold="true" BorderColor="#3366FF" BorderStyle="Solid" Width="83px" ForeColor="#3333CC" OnClick="Button1_Click" />
        </div>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="false" ForeColor="Red" Font-Underline="true" />
    </form>
</asp:Content>