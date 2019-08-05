<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Assignment8.aspx.cs" Inherits="WebApplication1.Sample.Assignment8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container">
        <div class="row">
            <h3 class="text-center text-primary">Select One Employee from the Drop-Down Bellow</h3>
            <div class="col-sm-4 col-md-offset-4">
                <div class="margin-top30">
                    <asp:DropDownList ID="DropDownListManager" runat="server" 
                        AutoPostBack="True" CssClass="form-control"
                        OnSelectedIndexChanged="DropDownListManager_SelectedIndexChanged">

                    </asp:DropDownList>
                </div>
            </div>
        </div>


    </div>
</asp:Content>
