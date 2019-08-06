<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SampleWebUserControl.ascx.cs"
    Inherits="TutorialDay15.UserControls.SampleWebUserControl" %>

<asp:TextBox ID="txtSample" runat="server"></asp:TextBox>
<asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" />

<br />
<asp:Label ID="lblMessage" runat="server"></asp:Label>
