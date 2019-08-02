<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignment6.aspx.cs" Inherits="Assignment_5.Sample.assignment6" MasterPageFile="~/Assignment6.Master" %>


<asp:Content runat="server" ID="asg5" ContentPlaceHolderID="ContentPlaceHolder1">

    <asp:Table ID="Table1" runat="server" Width="100%" HorizontalAlign="center">
        <asp:TableRow>
            <asp:TableCell Width="50%">FIRST NAME</asp:TableCell>
            <asp:TableCell Width="50%">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell Width="50%">LAST NAME</asp:TableCell>
            <asp:TableCell Width="50%">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell Width="50%">DEPARTMENT</asp:TableCell>
            <asp:TableCell Width="50%">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell Width="50%">EMAIL</asp:TableCell>
            <asp:TableCell Width="50%">
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

    </asp:Table>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <asp:Button ID="Button1" runat="server" Text="Go Back" OnClick="ButtonGo_Click" />
        </div>
    </form>
</asp:Content>

