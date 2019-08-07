<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="TutorialDay15.UserControls.UserControl" %>


<asp:TextBox ID="TextBoxInput" runat="server" style="font-size:24px; border:groove 2px black; width:20vw;"></asp:TextBox>
<br />
<asp:Button ID="ButtonSubmit" runat="server" Text="Say Hello" OnClick="ButtonSubmit_Click" style ="width:10vw; border: groove 3px grey; font-size: 23px;background-color:whitesmoke; margin-left: 5vw; margin-top: 4vh;"/>
<br />
<asp:Label ID="LabelDisplayResult" runat="server" style ="  font-size: 23px; padding-top: 10vh;"></asp:Label>