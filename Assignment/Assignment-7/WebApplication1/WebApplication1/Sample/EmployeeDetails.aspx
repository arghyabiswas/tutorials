<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="WebApplication1.Sample.EmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <asp:Table ID="Table1" runat="server" CssClass="table table-responsive table-bordered">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Name" runat="server" Text="Name"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="LabelName" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Email" runat="server" Text="Email"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="LabelEmail" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="EmployeeId" runat="server" Text="Employee ID"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="LabelEmployeeId" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="ReportingManager" runat="server" Text="Reporting Manager"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="LabelReportingManager" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

</asp:Content>
