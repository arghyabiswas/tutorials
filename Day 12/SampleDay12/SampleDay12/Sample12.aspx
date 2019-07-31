<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sample12.aspx.cs" Inherits="SampleDay12.Sample12" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:TextBox id="txtName" runat="server"></asp:TextBox>
    <asp:Button ID="btnSubmit" runat="server" Text="SUBMIT" OnClick="btnSubmit_Click" />
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <input type="hidden" id="h1" />
</asp:Content>
