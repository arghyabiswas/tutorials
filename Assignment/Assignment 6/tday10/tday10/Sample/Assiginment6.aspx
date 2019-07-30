<%@ Page Title="" Language="C#" MasterPageFile="~/Assignment6.Master" AutoEventWireup="true" CodeBehind="Assiginment6.aspx.cs" Inherits="tday10.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <asp:Table ID="Loginform" runat="server" HorizontalAlign="Center" rules="all" Height="400px" Width="100%" BackColor="Black" Font-Names="Times New Roman" Font-Overline="True" ForeColor="White">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell Text=" Login Fields " HorizontalAlign="Center" Width="50%" Height="30px" Font-Bold="True" ForeColor="Maroon"></asp:TableHeaderCell>
                <asp:TableHeaderCell Text=" Login Input " HorizontalAlign="Center" Height="30"></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell Text=" First Name" HorizontalAlign="Center" Height="25px"></asp:TableCell>
                <asp:TableCell HorizontalAlign="Center" Height="45 ">
                  <asp:Label runat="server" ID="fname"></asp:Label>
                     
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Text=" Last Name" HorizontalAlign="Center" Height="25px"></asp:TableCell>
                <asp:TableCell HorizontalAlign="Center" Height="45 ">
                     <asp:Label runat="server" ID="lname"></asp:Label>
                     
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Text=" Department" HorizontalAlign="Center" Height="25px"></asp:TableCell>
                <asp:TableCell  HorizontalAlign="Center" ><asp:Label ID="dept" runat="server"></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Text="  Email " HorizontalAlign="Center" Height="25px"></asp:TableCell>
                <asp:TableCell HorizontalAlign="Center" Height="45 "><asp:Label ID="email" runat="server" ></asp:Label>
                    
                    <br />
                    <br />
                    
                </asp:TableCell>
            </asp:TableRow>
             

        </asp:Table>



</asp:Content>
 