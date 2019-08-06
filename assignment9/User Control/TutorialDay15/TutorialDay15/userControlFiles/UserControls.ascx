<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControls.ascx.cs" Inherits="TutorialDay15.UserControls" %>
<br />
<asp:TextBox ID="Text" runat="server"></asp:TextBox>
<asp:Button ID="Submit" runat="server" Text="Say Hello" OnClick="Submit_Click" />
<br />
<asp:Label ID="Result" runat="server" Text=""></asp:Label>