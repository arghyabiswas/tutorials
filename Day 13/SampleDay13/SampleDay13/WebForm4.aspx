<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="SampleDay13.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView AllowSorting="true" ID="gvEmployee" runat="server" AutoGenerateColumns="False" Width="100%" OnSorting="gvEmployee_Sorting">
        <Columns>
            <asp:CheckBoxField DataField="IsManager" HeaderText="Select" SortExpression="IsManager" ReadOnly="True" />
            <asp:BoundField DataField="Employeeid"  HeaderText="Employee Id" />
            <asp:HyperLinkField DataTextField="Name" SortExpression="Employeeid" HeaderText="Name" />
            <asp:HyperLinkField DataTextField="Email" SortExpression="Email" HeaderText="Email" />
            <asp:BoundField DataField="Salary" HeaderText="Salary" />
        </Columns>

    </asp:GridView>
</asp:Content>
