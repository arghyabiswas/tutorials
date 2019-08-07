<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TutorialDay16.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
      <table align="center">

          <tr>
              <td><asp:Label ID="userName" runat="server" Text="Username"></asp:Label></td>
              <td><asp:TextBox ID="UsernameE" runat="server" Text=""> </asp:TextBox></td>
              </tr>
          <tr>
              <td><asp:Label ID="passWord" runat="server" Text="Password"></asp:Label></td>
              <td><asp:TextBox ID="PasswordE" runat="server" Text="" TextMode="Password"> </asp:TextBox></td>
          </tr>
           <tr>
              <td><asp:Label ID="RememberMe" runat="server" Text="Remeber Me"></asp:Label></td>
              <td><asp:CheckBox ID="chkboxPersist" runat="server" /> </td>
          </tr>
         
      </table>
        
       <center> <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
           <br / ><asp:Label ID="msg" runat="server" Text=""></asp:Label>
           </center> 
   
</asp:Content>
