<%@ Page Title="" Language="C#" MasterPageFile="~/Assignment6.Master" AutoEventWireup="true" CodeBehind="Assignment6.aspx.cs" Inherits="Assignment5.Sample.Assignment6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Firstname"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="LabelFirstname" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="Lastname"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="LabelLastname" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="LabelEmail" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label4" runat="server" Text="Department"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="LabelDepartment" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2" HorizontalAlign="Center" >
                <form runat="server">
                    <asp:Button ID="ButtonGoBack" runat="server" OnClick="ButtonGoBack_Click" Text="Go Back" />
                </form>
                
            </asp:TableCell>
        </asp:TableRow>

    </asp:Table>
    
</asp:Content>
