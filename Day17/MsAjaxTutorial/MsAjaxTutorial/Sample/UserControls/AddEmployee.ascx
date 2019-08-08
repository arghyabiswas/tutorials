<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.ascx.cs" Inherits="MsAjaxTutorial.Sample.UserControls.AddEmployee" %>
<asp:Table ID="Table1" runat="server">
    <asp:TableRow>
        <asp:TableCell>Name:</asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqName" runat="server"
                ForeColor="Red" ErrorMessage="Name is required." ControlToValidate="txtName"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>Email :</asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqEmail" runat="server"
                ForeColor="Red" Display="Dynamic" ErrorMessage="Email is required." ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regEmail" runat="server"
                ForeColor="Red" ErrorMessage="Invalid Email format" ControlToValidate="txtEmail"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>Reporting Manager :</asp:TableCell>
        <asp:TableCell>
            <asp:DropDownList ID="ddlManager" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="reqManager" runat="server"
                ForeColor="Red" ControlToValidate="ddlManager" ErrorMessage="Manager is required."></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>
<p>
    <asp:ValidationSummary ID="ValidationSummary1" ForeColor="Red" runat="server" />
</p>
