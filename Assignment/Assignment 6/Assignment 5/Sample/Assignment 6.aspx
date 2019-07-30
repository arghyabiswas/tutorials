<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment 6.aspx.cs" Inherits="Assignment_5.Assignment_61" MasterPageFile="~/Assignment 6.Master" %>

<asp:Content ID="con" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:label text="Firstname" runat="server" />
                </asp:TableCell><asp:TableCell>
                    <asp:Label ID="LabelFirstname" runat="server" Text="Label"></asp:Label>
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                    <asp:label text="Lastname" runat="server" />
                </asp:TableCell><asp:TableCell>
                    <asp:Label ID="LabelLastname" runat="server" Text="Label"></asp:Label>
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                    <asp:label text="Email" runat="server" />
                </asp:TableCell><asp:TableCell>
                    <asp:Label ID="LabelEmail" runat="server" Text="Label"></asp:Label>
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                    <asp:label text="Department" runat="server" />
                </asp:TableCell><asp:TableCell>
                    <asp:Label ID="LabelDepartment" runat="server" Text="Label"></asp:Label>
                </asp:TableCell></asp:TableRow></asp:Table>
        <asp:Button Text="Go Back" runat="server" id="btn" OnClick="btn_Click" /></div>

</asp:Content>
