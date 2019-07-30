<%@ Page Title="" Language="C#" MasterPageFile="~/Assignment6.Master" AutoEventWireup="true" CodeBehind="Assignment6.aspx.cs" Inherits="Assignment_5.Sample.Assignment6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color: #FFFF00; font-family: Consolas;">
    <asp:Table ID="Table1" runat="server" Width="100%" Height="60%" HorizontalAlign="Center" BorderWidth="1px" BorderStyle="Solid" BorderColor="Black" GridLines="Both" Font-Names="Consolas">
        <asp:TableRow>
            <asp:TableCell Text="First name: " HorizontalAlign="Center" Width="50%" Height="40px"></asp:TableCell>
            <asp:TableCell HorizontalAlign="Center" Width="50%" Height="40px">
                <asp:Label ID="lbl1" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="Last name: " HorizontalAlign="Center" Width="50%" Height="40px"></asp:TableCell>
            <asp:TableCell HorizontalAlign="Center" Width="50%" Height="40px">
                <asp:Label ID="lbl2" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="Department: " HorizontalAlign="Center" Width="50%" Height="40px"></asp:TableCell>
            <asp:TableCell HorizontalAlign="Center" Width="50%" Height="40px">
                <asp:Label ID="lbl3" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="Email: " HorizontalAlign="Center" Width="50%" Height="40px"></asp:TableCell>
            <asp:TableCell HorizontalAlign="Center" Width="50%" Height="40px">
                <asp:Label ID="lbl4" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
    <br />
    <div style="text-align: center">
        <asp:LinkButton ID="lb1" runat="server" Text="Go back" OnClick="lb1_Click" Style="text-align: center"></asp:LinkButton>
    </div>
    </div>
</asp:Content>
