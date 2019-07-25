<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Assignment_4.Admin.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <title>MyWeb-Page</title>
</head>
<body class="container">
    <form id="form1" runat="server" class="form-group">
        <div class="row">
            <div class="col-md-6">
                <asp:Label runat="server" ID="LabelText" For="TextBoxResult" CssClass="text-primary h3 .px-2">Enter Text Here :</asp:Label>
                <br />
                <asp:TextBox ID="TextBoxResult" runat="server" CssClass="form-control .px-2"></asp:TextBox>
                <br />
                <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" Text="Say Hello" CssClass=".px-2 btn btn-danger" />
                <br />
                <br />
                <br />
            </div>
        </div>
        <div class="row">
            <div class="container">
                <asp:Label runat="server" ID="LabelResult" CssClass="text-info h3" OnLoad="Page_Load"></asp:Label>
            </div>
        </div>

    </form>
</body>
</html>
