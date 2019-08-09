<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AjaxContactUs.aspx.cs" Inherits="TutorialDay17.AjaxContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div style="margin-top:30vh; margin-left: 33vw; margin-bottom: 20vh">
       
        <asp:UpdatePanel ID="UpdatePanelTest" runat="server">

            <ContentTemplate>

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

            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgressDisplay" runat="server"
            AssociatedUpdatePanelID="UpdatePanelTest">

            <ProgressTemplate>
                Loading...
            </ProgressTemplate>

        </asp:UpdateProgress>
    </div>
</asp:Content>
