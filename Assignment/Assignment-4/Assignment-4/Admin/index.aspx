<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Assignment_4.Admin.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       #TextBox1{
           height:50px;
           font-size:27px;
           width: 50vw;
           margin-left:25vw;
           margin-top: 20vh;
           text-align:center;
           border: groove 2px darkgrey;
       }
       #Button1{
           font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
           font-size: 23px;
           background-color:lightgreen;
           margin-top: 10vh;
           margin-left: 43vw;
           width:14vw;
           padding:5px;
           border:dashed 2px black; 
       }
       #Label1{
           font-family:'Times New Roman', Times, serif;
           font-size:50px;
           font-weight:600;
           width:100vw;
           text-align:center;
           height: 60px;
       }
       #div1{
           width:100vw;
           text-align:center;
           margin-top:10vh;
       }
       *{
           margin:0px;
       }
       body{
           background-color:azure;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter your name here!"></asp:TextBox>
        </div>

        <div id="div1">
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" BorderColor="#FFCC66" Font-Names="Comic Sans MS"> </asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>

        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Say Hello" OnClick="Button1_Click" BackColor="#CCCCFF" BorderColor="#00FFCC" BorderStyle="Ridge" Font-Bold="True" Font-Names="Times New Roman" ForeColor="#3366FF" />
        </div>

    </form>
</body>
</html>
