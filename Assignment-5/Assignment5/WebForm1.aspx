<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assignment5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server" HorizontalAlignment="Center" Height="239px" Width="499px">
                <asp:TableHeaderRow>

                    <asp:TableHeaderCell Font-Bold="true" Font-Size="X-Large">Registration_Form</asp:TableHeaderCell>

                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <br />
                        <asp:Label ID="LabelFirstName" runat="server" Text="FirstName"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxFirstName" runat="server" placeholder="Enter FirstName"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <%--field can't be empty--%>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" ControlToValidate="TextBoxFirstName" ErrorMessage="FirstName Field can't be Empty" ForeColor="Red"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LabelLastName" runat="server" Text="LastName"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxLastName" runat="server" placeholder="Enter FirstName"></asp:TextBox>
                    </asp:TableCell>

                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LabelDepartment" runat="server" Text="Department"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <%--drop down list options--%>
                        <asp:DropDownList ID="DropDownListDept" runat="server">
                            <asp:ListItem>Select Department</asp:ListItem>
                            <asp:ListItem>Computer Science</asp:ListItem>
                            <asp:ListItem>Chemical</asp:ListItem>
                            <asp:ListItem>Electrical</asp:ListItem>
                            <asp:ListItem>Automobile</asp:ListItem>
                            <asp:ListItem>MCA</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <%--field can't be empty--%>
                        <%--it should in something@xyz.com--%>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Emailid is required" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Invalid Email id, it should look like something@xyz.com" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>

                    </asp:TableCell>

                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <%--field can't be empty--%>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Password Field can't be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                    </asp:TableCell>

                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LabelConfirmPassword" runat="server" Text="Confirm Password"></asp:Label>

                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxConfirmPassword" runat="server"></asp:TextBox>
                    </asp:TableCell>

                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Password Field can't be empty" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidatorPassword" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxConfirmPassword" ErrorMessage="Password, Confirm Password not matching" ForeColor="Red"></asp:CompareValidator>
                    </asp:TableCell>
                </asp:TableRow>


            </asp:Table>
        </div>











        <p>

            <asp:Button ID="ButtonSubmit" runat="server" BackColor="#3366FF" ForeColor="White" Text="Submit" BorderStyle="Inset" Height="35px" Width="86px" />

        </p>




















        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />




















    </form>
</body>
</html>
