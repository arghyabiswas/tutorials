<%@ Page Title="" Language="C#" MasterPageFile="~/assignment6.Master" AutoEventWireup="true" CodeBehind="assignment6.aspx.cs" Inherits="Assignment_5.Sample.assignment6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterContentPlaceHolder" runat="server">
   <asp:Table ID="Table1" runat="server" Width ="100%">
    <asp:TableRow>
                 <asp:TableCell>
                     <asp:Label ID="Label1" runat="server">First Name</asp:Label>
                 </asp:TableCell>
                 <asp:TableCell>
                     <asp:Label ID="FirstName" runat="server" Text=""></asp:Label>                     
                 </asp:TableCell>
        </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
                     <asp:Label ID="Label2" runat="server">Last Name</asp:Label>
                 </asp:TableCell>
                 <asp:TableCell>
                     <asp:Label ID="LastName" runat="server" Text=""></asp:Label>                     
                 </asp:TableCell>
     </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
                     <asp:Label ID="Label3" runat="server">Course</asp:Label>
                 </asp:TableCell>
                 <asp:TableCell>
                     <asp:Label ID="course" runat="server" Text=""></asp:Label>                     
                 </asp:TableCell>
     </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
                     <asp:Label ID="Label4" runat="server">Email</asp:Label>
                 </asp:TableCell>
                 <asp:TableCell>
                     <asp:Label ID="Email" runat="server" Text=""></asp:Label>                     
                 </asp:TableCell>

             </asp:TableRow>
        </asp:Table>
    <asp:Button ID="GoBack" runat="server" OnClick="GoBack_Click" Text="Go Back"/>
</asp:Content>
