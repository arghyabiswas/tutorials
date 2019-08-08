<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxContactUs.aspx.cs" Inherits="TutorialDay17.AjaxContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:ScriptManager ID="ScriptManagerOne" runat="server"></asp:ScriptManager>

            <asp:UpdatePanel ID="UpdatePanelTest" runat="server">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-md-offset-4">
                            <asp:TextBox ID="TextBoxName" CssClass="form-control"
                                runat="server" placeholder="Enter your Name">
                            </asp:TextBox>

                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorName"
                                runat="server" ErrorMessage="Only alphabets are allowed for Name."
                                ControlToValidate="TextBoxName" Display="Dynamic"
                                ForeColor="Red" ValidationExpression="[A-Z a-z]+">
                            </asp:RegularExpressionValidator>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorName"
                                runat="server" ErrorMessage="Name is required."
                                ControlToValidate="TextBoxName" Display="Dynamic"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>

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


                            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit"
                                CssClass="btn btn-primary" OnClick="ButtonSubmit_Click" />

                            <br />
                            <br />
                            <asp:Label ID="LabelResult" runat="server" CssClass="control-label">

                            </asp:Label>


                        </div>
                    </div>


                </ContentTemplate>

            </asp:UpdatePanel>
            <asp:UpdateProgress ID="UpdateProgressDisplay" runat="server"
                AssociatedUpdatePanelID="UpdatePanelTest">

                <ProgressTemplate >
                    Loading...
                </ProgressTemplate>

            </asp:UpdateProgress>

        </div>
    </form>
</body>
</html>
