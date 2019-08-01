<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SampleGridView.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView ID="gvEmployee" PageSize="5" AllowPaging="True" AllowSorting="True" runat="server" AutoGenerateColumns="False" OnSorting="gvEmployee_Sorting" OnPageIndexChanging="gvEmployee_PageIndexChanging" OnRowCancelingEdit="gvEmployee_RowCancelingEdit" OnRowDeleting="gvEmployee_RowDeleting" OnRowEditing="gvEmployee_RowEditing" OnRowUpdating="gvEmployee_RowUpdating" OnSelectedIndexChanging="gvEmployee_SelectedIndexChanging" Width="100%" OnRowDataBound="gvEmployee_RowDataBound" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Employeeid" HeaderText="Employee Id" SortExpression="Employeeid" ReadOnly="True" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />

            <asp:TemplateField HeaderText="Manager">
                <ItemTemplate>
                    <%# Eval("ReportingManager.Name") %>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:HiddenField ID="hidEmployeeId" runat="server" Value='<%#Eval("Employeeid") %>' />
                    <asp:DropDownList ID="ddlManager" runat="server"></asp:DropDownList>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:CommandField ButtonType="Button" HeaderText="#" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />

        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerSettings Mode="NextPreviousFirstLast" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
</asp:Content>
