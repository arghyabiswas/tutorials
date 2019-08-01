<%@ Page Title="" Language="C#" MasterPageFile="~/Assignment 6.Master" AutoEventWireup="true" CodeBehind="Assignment 6.aspx.cs" Inherits="Assignment_5.Sample.Assignment_6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Width="100%">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="Label1" runat="server" Text="First Name :" Font-Bold="true"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TextBox1" runat="server" Font-Italic="true" ></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="Label2" runat="server" Text="Last Name :" Font-Bold="true"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TextBox2" runat="server" Font-Italic="true" ></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="Label3" runat="server" Text="Department :" Font-Bold="true"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TextBox3" runat="server" Font-Italic="true"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="Label4" runat="server" Text="Email :" Font-Bold="true" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TextBox4" runat="server" Font-Italic="true"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Button ID="Button1" runat="server" Text="Go Back" Font-Size="Medium" Font-Bold="true" BackColor="White" style="margin-left: 257px" OnClick="Button1_Click" />
    </form>
</asp:Content>
