﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Assignment 7.aspx.cs" Inherits="Assignment_5.Sample.Assignment_7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div style="text-align:center">    
               <h4> <asp:Label ID="Label1" runat="server" Text="Employees : "></asp:Label>
            
              <asp:DropDownList ID="dropdown" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropdown_SelectedIndexChanged" ></asp:DropDownList></h4></div> 
    
</asp:Content>
