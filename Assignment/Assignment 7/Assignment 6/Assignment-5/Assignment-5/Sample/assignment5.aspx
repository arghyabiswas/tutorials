<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignment5.aspx.cs" Inherits="Assignment_5.Sample.assignment5" MasterPageFile="~/assignment6.Master"%>


       <asp:Content ID="Content1" ContentPlaceHolderID="FooterContentPlaceHolder" runat="server"> 
    <div>
     <h1>Registration Form</h1>
    
    <asp:Table ID="Table1" runat="server" Width ="100%">
             <asp:TableRow>
                 <asp:TableCell>
                     <asp:Label ID="Label1" runat="server">First Name</asp:Label>
                 </asp:TableCell>
                 <asp:TableCell>
                     <asp:TextBox ID="FirstNameE" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="FirstName" ControlToValidate="FirstNameE" runat="server" ForeColor="Red" ErrorMessage=" Please fill the box.It is a required field." Display="Dynamic"></asp:RequiredFieldValidator>
                 </asp:TableCell>
             </asp:TableRow>
        
             <asp:TableRow>
                 <asp:TableCell>
                     <asp:Label ID="Label2" runat="server">Last Name</asp:Label>
                 </asp:TableCell>   
                 <asp:TableCell>
                     <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                 </asp:TableCell>
             </asp:TableRow>
        
             <asp:TableRow>
                 <asp:TableCell>
                     <asp:Label ID="Label3" runat="server">Department</asp:Label>
                 </asp:TableCell>
                 <asp:TableCell>
                    <asp:DropDownList ID="DropDownList" runat="server">

                    <asp:ListItem Value="">---Please Select---</asp:ListItem>  
                    <asp:ListItem Value="Computer Science">Computer Science </asp:ListItem>  
                    <asp:ListItem Value="Chemical">Chemical</asp:ListItem>  
                    <asp:ListItem Value="Electrical">Electrical</asp:ListItem>  
                    <asp:ListItem Value="Electrical">MCA</asp:ListItem> 
                    <asp:ListItem Value="Automobile">Automobile</asp:ListItem>  
                    
                    </asp:DropDownList>
                 </asp:TableCell>
             </asp:TableRow>
        
            <asp:TableRow>
                 <asp:TableCell>
                     <asp:Label ID="Label4" runat="server">E-Mail</asp:Label>
                 </asp:TableCell>
                 <asp:TableCell> <asp:TextBox ID="EMailE" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="EmailE" ForeColor="Red" ErrorMessage=" Please enter the email.It is a required field." Display="Dynamic"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ForeColor="Red" ErrorMessage=" Invalid email address." ControlToValidate="EmailE" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
                      </asp:TableCell>
             </asp:TableRow>
    
                <asp:TableRow>
                 <asp:TableCell>
                     <asp:Label ID="Label5" runat="server">Password</asp:Label>
                 </asp:TableCell>
                 <asp:TableCell> 
                     <asp:TextBox ID="PasswordE" runat="server" TextMode="Password"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="Password" ControlToValidate="PasswordE" runat="server" ForeColor="Red" ErrorMessage=" Please enter a Password.It is a required field." Display="Dynamic"></asp:RequiredFieldValidator>
                 </asp:TableCell>
             </asp:TableRow>

        <asp:TableRow>
                 <asp:TableCell>
                     <asp:Label ID="Label6" runat="server">Confirm Password</asp:Label>
                 </asp:TableCell>
                 <asp:TableCell> <asp:TextBox ID="ConfirmPasswordE" TextMode="Password" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="ConfirmPasswordE" runat="server" ForeColor="Red" ErrorMessage=" Please enter the Password. It is a required field." Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="ConfirmPassword" ControlToCompare="PasswordE" runat="server" ControlToValidate="ConfirmPasswordE" ForeColor="Red" ErrorMessage=" Password do not Match. Please enter the Password again." Display="Dynamic" ></asp:CompareValidator>
                 </asp:TableCell>
             </asp:TableRow>
        
    </asp:Table>
    
        <br/><asp:Button ID="Button1" Text="Click me" runat="server" OnClick="OnClick"/>
        <br/>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="True" ForeColor="Red" ShowSummary="True" />
        <br/>
        <asp:Label ID="Result" runat="server" Text=""></asp:Label>
         
    </div>
           </asp:Content>
   