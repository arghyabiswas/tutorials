<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment 5.aspx.cs" Inherits="Assignment_5.Sample.Assignment_5" MasterPageFile="~/Assignment 6.Master" %>

 <asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="Content1" >
    
    <div style="text-align:center; color:red"><h1> Registration Form </h1></div>
    
    <div>
       
    <asp:Table ID="StudTable" runat="server" BorderStyle="Dashed" HorizontalAlign="Center">
       
        <asp:TableRow>
            <asp:TableCell Text="First Name" Font-Size="X-Large" ></asp:TableCell>
            <asp:TableCell><asp:TextBox Id="textbox1" runat="server" Font-Size="Large" /></asp:TableCell>
            <asp:TableCell><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textbox1" ErrorMessage="Please Enter FirstName"  ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell Text="Last Name"  Font-Size="X-Large"></asp:TableCell>
            <asp:TableCell><asp:TextBox Id="textbox2" runat="server" Font-Size="Large"  /></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell Text="Department" Font-Size="X-Large"></asp:TableCell>
            <asp:TableCell><asp:DropDownList ID="dropdownlist" runat="server" Font-Size="Large" Width="100%">
            <asp:ListItem Value="1" Text="Computer Science"></asp:ListItem>
            <asp:ListItem Value="2" Text="Chemical"></asp:ListItem>
            <asp:ListItem Value="3" Text="Electrical"></asp:ListItem>
            <asp:ListItem Value="4" Text="Automobile"></asp:ListItem>
            <asp:ListItem Value="5" Text="MCA"></asp:ListItem>
            </asp:DropDownList></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell Text="Email"  Font-Size="X-Large" ></asp:TableCell>
            <asp:TableCell><asp:TextBox Id="textbox3" runat="server"  Font-Size="Large" /></asp:TableCell>
            <asp:TableCell><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textbox3"  Display="Dynamic" ErrorMessage="Please Enter Email Id" ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server" ControlToValidate="textbox3" Display="Dynamic" ErrorMessage="Please Enter Valid Email Id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ForeColor="Red" Font-Italic="true"></asp:RegularExpressionValidator></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow> 
            <asp:TableCell Text="Password"  Font-Size="X-Large"></asp:TableCell>
            <asp:TableCell><asp:TextBox Id="textbox4" TextMode="Password" runat="server" Font-Size="Large" /></asp:TableCell>
            <asp:TableCell><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="textbox4" ErrorMessage="Please Enter Password"  ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell Text="Confirm Password"  Font-Size="X-Large" ></asp:TableCell>
            <asp:TableCell><asp:TextBox Id="textbox5" TextMode="Password" runat="server" Font-Size="Large" /></asp:TableCell>
            <asp:TableCell><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="textbox5"  Display="Dynamic" ErrorMessage="Please Re-enter Password" ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator" runat="server" ControlToCompare="textbox4" ControlToValidate="textbox5" Display="Dynamic" ErrorMessage="Password Mismatch" ForeColor="Red" Font-Italic="true" ></asp:CompareValidator></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell><asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" /></asp:TableCell>
        </asp:TableRow>
        
        
    </asp:Table>
       <div style="text-align:center"><asp:Button ID="Button1" Text="Submit" OnClick="Button1_Click" runat="server" BackColor="Black" Font-Size="X-Large" ForeColor="White"  /></div> 
            
    </div>
     
    
</asp:Content>
