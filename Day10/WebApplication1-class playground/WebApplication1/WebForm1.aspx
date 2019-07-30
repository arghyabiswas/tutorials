<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">

        <asp:Table ID="Table1" runat="server" rules="all" Width="50%" Height="50%" BorderWidth="1px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell Text="Header1"></asp:TableHeaderCell>
                <asp:TableHeaderCell Text="Header2"></asp:TableHeaderCell>
                <asp:TableHeaderCell Text="Header2"></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell>CELL1</asp:TableCell>
                <asp:TableCell>CELL2</asp:TableCell>
                <asp:TableCell>CELL3</asp:TableCell>
            </asp:TableRow>
            <asp:TableFooterRow>
                <asp:TableCell>fOOTER1</asp:TableCell>
                <asp:TableCell>fOOTER2</asp:TableCell>
                <asp:TableCell>fOOTER3</asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>
                <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="This is a label">
        </asp:Label>
        <br />
        <br />
        <br />
        <asp:Literal ID="Literal1" runat="server" Text="This is a literal" >
        </asp:Literal>
        <br />
        <br />
        <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            <asp:Button ID="Button4" runat="server" text="submit"></asp:Button>
        </asp:PlaceHolder>

        <br />
        <br />
        <br />

    </form>
</body>
</html>
