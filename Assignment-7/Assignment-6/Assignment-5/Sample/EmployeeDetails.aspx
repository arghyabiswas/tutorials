<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="Assignment_5.Sample.EmployeeDetails"  %>
<asp:Content runat="server" ID="asg5" ContentPlaceHolderID="MainContent">

    <asp:Table ID="Table1" runat="server" Width="100%" HorizontalAlign="center">
        <asp:TableRow>
            <asp:TableCell Width="50%">NAME</asp:TableCell>
            <asp:TableCell Width="50%">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell Width="50%">EMAIL</asp:TableCell>
            <asp:TableCell Width="50%">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell Width="50%">EMPLOYEE ID</asp:TableCell>
            <asp:TableCell Width="50%">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell Width="50%">REPORTING MANAGER</asp:TableCell>
            <asp:TableCell Width="50%">
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

    </asp:Table>
</asp:Content>
