<%@ Page Title="" Language="C#" MasterPageFile="~/assignment6.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assignment_5.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FooterContentPlaceHolder" runat="server">
    This is web form 1 content<br />
    <br />
&nbsp;<asp:Label ID="employeeList" runat="server" Text="Select the employee from the table:"></asp:Label>
    
      <asp:DropDownList ID="DropDownListEmployee" runat="server" 
                        AutoPostBack="True"  
                        OnSelectedIndexChanged="DropDownListEmployee_SelectedIndexChanged" ></asp:DropDownList>
    
</asp:Content>
