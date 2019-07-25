<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Assignment4.Admin.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 184px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            Write Name Here:</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" BackColor="White" BorderColor="#003366" Height="40px" OnTextChanged="TextBox1_TextChanged" Width="211px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#66FF66" Height="30px" OnClick="Button1_Click" Text="Say Hello" Width="215px" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
