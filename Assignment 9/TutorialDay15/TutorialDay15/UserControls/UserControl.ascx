<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="TutorialDay15.UserControls.UserControl" %>
<asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Text"></asp:TextBox>
<asp:Button ID="Button1" runat="server" Text="Say Hello" OnClick="Button1_Click" />

<p>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</p>


