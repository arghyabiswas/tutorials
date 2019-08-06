<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Tutorial.Sample.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        AllowPaging="True" PageSize="5" OnPageIndexChanging="GridView1_PageIndexChanging"
        AllowSorting="True" OnSorting="GridView1_Sorting" OnRowEditing="GridView1_RowEditing">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Student Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Email" HeaderText="Email " />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" 
                ShowEditButton="True" />
        </Columns>

        <PagerSettings FirstPageText="First" LastPageText="Last"
            Mode="NextPreviousFirstLast" NextPageText="Next" PreviousPageText="Previous" />

    </asp:GridView>
</asp:Content>
