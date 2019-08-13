<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TutorialDay16.Sample.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Table ID="Table1" runat="server" style="margin-top: 15vh;">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell ColumnSpan="2" style="text-align: center; padding-left:50vh;"><h1 style="font-weight:500;">Login Page</h1></asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell CssClass="leftCell">
                <asp:Label ID="username" runat="server" Text="Username :- "></asp:Label>
            </asp:TableCell>
            <asp:TableCell CssClass="rightCell">
                <asp:TextBox ID="UserNameInput" CssClass="inputField" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
          <asp:TableRow>
            <asp:TableCell CssClass="leftCell">
                 <asp:Label ID="password" runat="server" Text="Password :-"></asp:Label>
            </asp:TableCell>
            <asp:TableCell CssClass="rightCell">
                <asp:TextBox ID="UserPassword" CssClass="inputField" runat="server" TextMode="Password"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableFooterRow>
            <asp:TableCell ColumnSpan="2">
                  <asp:Button ID="ButtonLogin" CssClass="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="Login" />
                <br />
                <asp:Label ID="Error" runat="server" CssClass="ErrorLabel"></asp:Label>
            </asp:TableCell>
        </asp:TableFooterRow>
    </asp:Table>

</asp:Content>
