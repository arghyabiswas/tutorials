<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxContactUs.aspx.cs" Inherits="TutorialDay17.AjaxContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" autocomplete="off">
        <div style="text-align: center; color: blue">
            <h1>Welcome to AJAX Login Page </h1>
        </div>
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Table ID="table" HorizontalAlign="Center" runat="server">
                        <asp:TableRow>
                            <asp:TableCell>
                            Name:&nbsp;&nbsp;
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="nametxt" Font-Italic="true" ForeColor="Red" runat="server" ErrorMessage="Name is Required">
                                </asp:RequiredFieldValidator>
                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow>
                            <asp:TableCell>
                            Email:&nbsp;&nbsp;
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="emailtxt" Font-Italic="true" Display="Dynamic" ForeColor="Red" runat="server" ErrorMessage="Email is Required">
                                </asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Font-Italic="true" ForeColor="Red" Display="Dynamic" ControlToValidate="emailtxt" runat="server" ErrorMessage="Please Enter Valid Email"></asp:RegularExpressionValidator>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <br />
                    <div style="text-align: center">
                        <asp:Button ID="submit" Text="SUBMIT" OnClick="submit_Click1" runat="server" />
                    </div>
                    <br />
                    <br />
                    <div style="text-align: center; color:crimson">
                        <asp:Label ID="lbl" runat="server"></asp:Label>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdateProgress ID="updateprogress" runat="server">
                <ProgressTemplate>
                    <div style="text-align:center;color:darkslategray">
                        Loading...
                    </div>
                </ProgressTemplate>

            </asp:UpdateProgress>
        </div>
    </form>
</body>
</html>
