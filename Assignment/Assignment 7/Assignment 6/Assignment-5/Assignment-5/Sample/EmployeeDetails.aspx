<%@ Page Title="" Language="C#" MasterPageFile="~/assignment6.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="Assignment_5.Sample.EmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 524px;
        }
        .auto-style2 {
            width: 524px;
            height: 21px;
        }
        .auto-style3 {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterContentPlaceHolder" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Name" runat="server" Text="Name"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LabelName" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Email" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelEmail" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="EmployeeID" runat="server" Text="EmployeeID"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelEmployeeID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="ReportingManager" runat="server" Text="Reporting Manager"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelReportingManager" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
