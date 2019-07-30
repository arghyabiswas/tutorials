<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignment5.aspx.cs" Inherits="Assignment_5.Sample.assignment5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/MyStyle.css" rel="stylesheet" />
    <script src="../scripts/jquery-1.10.2.js"></script>
    <script src="../scripts/jquery.unobtrusive-ajax.js"></script>
    <title>Assignment-5 | Page Validator</title>
</head>
<body>
    <form id="form1" runat="server" class="form-group">
        <div class="container" style="margin-top: 20px;">

            <asp:Table ID="TableRegistration" runat="server" CssClass="table-hover table-responsive" Width="100%" Height="450px">

                <%--Registration Section--%>
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell Font-Underline="true" CssClass="text-center h2 text-success" ColumnSpan="2" Font-Bold="true">Registration Form</asp:TableHeaderCell>
                </asp:TableHeaderRow>

                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" CssClass="text-center">
                        <asp:Label ID="LabelHint" runat="server" CssClass="h5 text-danger" Text="All * fields are required !"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>

                <%-- Firstname Area--%>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right" VerticalAlign="Middle">
                        <asp:Label ID="LabelFirstname" runat="server" Text="First Name<span class='text-danger'>*</span> :" CssClass="control-label" Font-Bold="true"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxFirstname" CssClass="form-control" runat="server" placeholder="Enter your firstname"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorFirstname" runat="server" ErrorMessage="Only alphabets are allowed for Firstname." ControlToValidate="TextBoxFirstname" Display="Dynamic" ForeColor="Red" ValidationExpression="[A-Za-z]+"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstname" runat="server" ErrorMessage="Firstname is required." ControlToValidate="TextBoxFirstname" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <%-- Lastname Area--%>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right" VerticalAlign="Middle">
                        <asp:Label ID="LabelLastname" runat="server" Text="Last Name:" CssClass="control-label" Font-Bold="true"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxLastname" CssClass="form-control"
                            runat="server" placeholder="Enter your lastname">

                        </asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorLastname"
                            runat="server" ErrorMessage="Only alphabets are allowed for Lastname."
                            ControlToValidate="TextBoxLastname" Display="Dynamic"
                            ForeColor="Red" ValidationExpression="[A-Za-z]+">

                        </asp:RegularExpressionValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <%-- DropDown Section--%>


                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right" VerticalAlign="Middle">
                        <asp:Label ID="Label1" runat="server" Text="Department:"
                            CssClass="control-label" Font-Bold="true">
                        </asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                            <asp:ListItem Value="0">--Select Your Department--</asp:ListItem>
                            <asp:ListItem Value="1">Computer Science</asp:ListItem>
                            <asp:ListItem Value="2">Chemical</asp:ListItem>
                            <asp:ListItem Value="3">Electical</asp:ListItem>
                            <asp:ListItem Value="4">Automobile</asp:ListItem>
                            <asp:ListItem Value="5">MCA</asp:ListItem>
                        </asp:DropDownList>

                    </asp:TableCell>
                </asp:TableRow>

                <%-- Email Area--%>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right" VerticalAlign="Middle">
                        <asp:Label ID="LabelEmail" runat="server"
                            Text="Email<span class='text-danger'>*</span> :"
                            CssClass="control-label" Font-Bold="true">

                        </asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxEmail" CssClass="form-control" runat="server"
                            placeholder="Enter your Email" TextMode="Email">

                        </asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail"
                            runat="server" ErrorMessage="Try with a correct email."
                            ControlToValidate="TextBoxEmail" Display="Dynamic"
                            ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">

                        </asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail"
                            runat="server" ErrorMessage="Email is required."
                            ControlToValidate="TextBoxEmail" Display="Dynamic"
                            ForeColor="Red">

                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>


                <%-- Password Area--%>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right" VerticalAlign="Middle">
                        <asp:Label ID="LabelPassword" runat="server"
                            Text="Password<span class='text-danger'>*</span> :"
                            CssClass="control-label" Font-Bold="true"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxPassword" CssClass="form-control"
                            runat="server" placeholder="Enter your Password"
                            TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword"
                            runat="server" ErrorMessage="Password is required."
                            ControlToValidate="TextBoxPassword" ForeColor="Red"
                            Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>


                <%--Confirm Password Area--%>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right" VerticalAlign="Middle">
                        <asp:Label ID="LabelConfirmPassword" runat="server"
                            Text="Confirm-Password<span class='text-danger'>*</span> :"
                            CssClass="control-label" Font-Bold="true"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxConfirmPassword" CssClass="form-control"
                            runat="server" placeholder="Confirm your Password"
                            TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword"
                            runat="server" ErrorMessage="Confirm Password is required."
                            ControlToValidate="TextBoxConfirmPassword" ForeColor="Red"
                            Display="Dynamic">
                        </asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidatorConfirmPassword"
                            runat="server" ErrorMessage="Password mis-match try again."
                            ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxConfirmPassword"
                            ForeColor="Red" Display="Dynamic">
                        </asp:CompareValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <%-- Submit Button--%>

                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="center" VerticalAlign="Middle">
                        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit"
                            CssClass="btn btn-primary" OnClick="ButtonSubmit_Click" />
                    </asp:TableCell>
                </asp:TableRow>
                <%--Validation Summary --%>

                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                        <asp:ValidationSummary ID="ValidationSummaryRegistation"
                            runat="server" DisplayMode="List" Font-Bold="True" ForeColor="Red" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>





        </div>


    </form>
</body>
</html>
