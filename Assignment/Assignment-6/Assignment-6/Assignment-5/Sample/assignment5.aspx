<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignment5.aspx.cs" Inherits="Assignment_5.Assignment_5" MasterPageFile="~/Assignment6.Master" %>

<asp:Content runat="server" ID="asg5" ContentPlaceHolderID="ContentPlaceHolder1">

    <form id="form1" runat="server">
        <div>
            <h2 style="text-align: center">REGISTRATION FORM</h2>
        </div>
        <div>
            <h2 style="text-align: center">ALL *FIELDS ARE MANDATORY</h2>
        </div>
        <div></div>
        <div>
            <asp:Table ID="Table1" runat="server" Width="100%" HorizontalAlign="center">

                <asp:TableHeaderRow HorizontalAlign="center">
                    <asp:TableHeaderCell HorizontalAlign="Center" Text="Field label" BackColor="Blue" ForeColor="White"></asp:TableHeaderCell>
                    <asp:TableHeaderCell HorizontalAlign="Center" Text="Input" BackColor="Blue" ForeColor="White"></asp:TableHeaderCell>
                </asp:TableHeaderRow>


                <asp:TableRow>
                    <asp:TableCell Width="50%">FIRST NAME*</asp:TableCell>

                    <asp:TableCell Width="50%">
                        <asp:TextBox runat="server" ID="tb1" placeholder="Enter First Name">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="tb1" runat="server" ForeColor="Red" Font-Names="Comic Sans MS" ErrorMessage="First name can't be empty">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>LAST NAME</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="tb2" placeholder="Enter Last Name">
                        </asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>DEPARTMENT</asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList runat="server" ID="dd">
                            <asp:ListItem Text="Computer Science" Value="a"></asp:ListItem>
                            <asp:ListItem Text="Chemical" Value="b"></asp:ListItem>
                            <asp:ListItem Text="Electrical" Value="c"></asp:ListItem>
                            <asp:ListItem Text="Automobile" Value="d"></asp:ListItem>
                            <asp:ListItem Text="MCA" Value="e"></asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>EMAIL*</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="tb3" placeholder="Enter Email">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator" ControlToValidate="tb3" runat="server" ErrorMessage="Email Field is Required" ForeColor="Red" Display="Dynamic" Font-Names="Comic Sans MS"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RequiredFieldValidator2" ControlToValidate="tb3" runat="server" ForeColor="Red"
                            Font-Names="Comic Sans MS" ErrorMessage="*Email is not Valid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                        </asp:RegularExpressionValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>PASSWORD*</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="tb4" TextMode="Password" placeholder="Enter PassWord">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="tb4" runat="server" ErrorMessage="Password Field is Required" ForeColor="Red" Display="Dynamic" Font-Names="Comic Sans MS"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>CONFIRM PASSWORD*</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="tb5" TextMode="Password" placeholder="Enter Confirm PassWord">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="tb5" runat="server" ErrorMessage="Confirm Password Field is Required" ForeColor="Red" Display="Dynamic" Font-Names="Comic Sans MS"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="PassWord Not Matched" ControlToValidate="tb5" ControlToCompare="tb4" ForeColor="Red" Font-Names="Comic Sans MS" Display="Dynamic"></asp:CompareValidator>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>

        </div>
        <div>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="SUBMIT" Style="margin-top: 26px; margin-left: 650px" OnClick="Button1_Click" />
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" Font-Names="Comic Sans MS" Style="margin-top: 26px; margin-left: 650px" />
    </form>

</asp:Content>

