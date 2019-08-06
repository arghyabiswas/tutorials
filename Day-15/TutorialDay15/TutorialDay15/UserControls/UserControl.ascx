<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="TutorialDay15.UserControls.UserControl" %>


<asp:TextBox ID="TextBoxControl" runat="server"></asp:TextBox>
<br />
<asp:Button ID="ButtonSubmit" runat="server" Text="Say Hello" OnClick="ButtonSubmit_Click" />
<br />
<asp:Label ID="LabelResult" runat="server"></asp:Label>