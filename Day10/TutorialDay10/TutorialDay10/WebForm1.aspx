<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TutorialDay10.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          

            
           
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Literal ID="Literal1" runat="server">
            <span>Test Literal- text</span>
            
        </asp:Literal>
        <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            <span>Test Place Holder- text</span>
        </asp:PlaceHolder>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:Literal ID="Literal2" runat="server">
        </asp:Literal>
        <br />
        <asp:PlaceHolder ID="PlaceHolder2" runat="server">
            <asp:Table ID="Table1" runat="server" Width="100%" BorderWidth="1">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell Text="Header 1"></asp:TableHeaderCell>
                    <asp:TableHeaderCell Text="Header 2"></asp:TableHeaderCell>
                    <asp:TableHeaderCell Text="Header 3"></asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell>Cell 1 - 1</asp:TableCell>
                    <asp:TableCell>Cell 1 - 2</asp:TableCell>
                    <asp:TableCell>Cell 1 - 3</asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell>Cell 2 - 1</asp:TableCell>
                    <asp:TableCell>Cell 2 - 2</asp:TableCell>
                    <asp:TableCell>Cell 2 - 3</asp:TableCell>
                </asp:TableRow>
                <asp:TableFooterRow>
                    <asp:TableHeaderCell>Footer 1</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Footer 2</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Footer 3</asp:TableHeaderCell>
                </asp:TableFooterRow>
            </asp:Table>
            <asp:Button runat="server" ID="button_Submit" Text="SUBMIT" />
        </asp:PlaceHolder>

        <label>Text 1</label>
        <asp:Label runat="server" ID="l1" Text="Text 2"> </asp:Label>
        <asp:Label ID="Label3" runat="server" Text="&lt;span style='color:red;'&gt;*&lt;/span&gt;This is a label">        </asp:Label>
         <asp:Label ID="Label4" runat="server" >             <span style="color:red;">*</span>             This is a label        </asp:Label>

        <label ID="l2" runat="server">Text 1</label>

    </form>
</body>
</html>
