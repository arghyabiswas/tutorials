<%@ Page Title="" Language="C#" MasterPageFile="~/Assignment6.Master" AutoEventWireup="true" CodeBehind="Assignment6Data.aspx.cs" Inherits="Assignment_5.Sample.Assignment6Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderAssignment" runat="server">

    <div class="container">
        <asp:Table ID="Table1" runat="server" CssClass="table table-bordered table-hover table-responsive">

            <asp:TableRow>
                <asp:TableCell>Firstname</asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="LabelFirstname" runat="server"></asp:Label>

                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Lastname</asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="LabelLastname" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Email</asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="LabelEmail" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Department</asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="LabelDepartment" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                    <form runat="server">
                        <asp:Button ID="ButtonGoBack" runat="server" Text="Go Back" CssClass="btn btn-danger" Enabled="True" OnClick="ButtonGoBack_Click" />

                    </form>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>

    </div>
</asp:Content>
