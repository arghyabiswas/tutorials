<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsEmployeeUnderManager.aspx.cs" Inherits="Assignment_5.DetailsEmployeeUnderManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView HorizontalAlign="Center" ID="GridView1" runat="server" AutoGenerateColumns="False" Width="50%">
        <Columns>
            <asp:BoundField DataField="Employeeid" HeaderText="Employee Id">
            <HeaderStyle BackColor="White" BorderStyle="Solid" ForeColor="Black" HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="Name">
            <ControlStyle ForeColor="Black" />
            <HeaderStyle BackColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle BorderStyle="Solid" HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Email" HeaderText="Email Id">
            <HeaderStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <div style="text-align:center"><asp:Button ID="Button1" Text="Go Back To Manager" runat="server" OnClick="Button1_Click" /></div>
</asp:Content>
