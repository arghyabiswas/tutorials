<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignment_5.aspx.cs" Inherits="assignment_5.assignment_5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Table ID="Table1" runat="server" Height="36px" Width="710px">
              <asp:TableRow>
                <asp:TableCell>
                    First Name
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="Textbox1" runat ="server"> </asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat ="server" ControlToValidate="Textbox1" ErrorMessage="required field is mandatory"> </asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>
             
                    
            <asp:TableRow> 
                 <asp:TableCell>
                    Last Name 
                </asp:TableCell>
                 <asp:TableCell>
                      <asp:TextBox ID="Textbox2" runat ="server"> </asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
                   
                    
             <asp:TableRow>
                <asp:TableCell>
                    Department
                </asp:TableCell>
               
                  <asp:TableCell>
                    <asp:DropDownList ID="Dropdown1"  runat="server" >
                        <asp:ListItem Enabled="true" Text="Select Department" Value="-1"></asp:ListItem>
                        <asp:ListItem Text ="Computer Science"></asp:ListItem>
                        <asp:ListItem Text="Chemical"></asp:ListItem>
                        <asp:ListItem Text="Electrical"></asp:ListItem>
                        <asp:ListItem Text="Automobile"></asp:ListItem>
                        <asp:ListItem Text="MCA"></asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>

                   
             <asp:TableRow>
                <asp:TableCell>
                    Email
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="Textbox4" runat ="server"> </asp:TextBox>
                </asp:TableCell>
                 <asp:TableCell>
                   
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat ="server" ControlToValidate="Textbox4" Display="Dynamic" ErrorMessage="required field is mandatory"> </asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server" ControlToValidate="Textbox4" Display="Dynamic" ErrorMessage="please enter valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                
                 </asp:TableCell>
            </asp:TableRow>

                   
             <asp:TableRow>
                <asp:TableCell>
                    Password
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="Textbox5" TextMode="Password" runat ="server">  </asp:TextBox>
                </asp:TableCell>
                 <asp:TableCell>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat ="server" ControlToValidate="Textbox5" Display="Dynamic" ErrorMessage="required field is mandatory"> </asp:RequiredFieldValidator>
                 </asp:TableCell>
            </asp:TableRow>
                

             <asp:TableRow>
                <asp:TableCell>
                    Confirm password
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="Textbox6" TextMode="Password" runat ="server">   </asp:TextBox>
                </asp:TableCell>
                  <asp:TableCell>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat ="server" ControlToValidate="Textbox6" Display="Dynamic" ErrorMessage="required field is mandatory"> </asp:RequiredFieldValidator>
                 </asp:TableCell>
                 
                 <asp:TableCell>
                      <asp:CompareValidator ID="ConfirmPassword" ControlToCompare="Textbox5" runat="server" ControlToValidate="Textbox6"  ErrorMessage=" Password do not Match. Please enter the Password again." Display="Dynamic" ></asp:CompareValidator>
                 </asp:TableCell>
            </asp:TableRow>
        </asp:Table>  
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

          <asp:Button ID="Button1" runat="server" Text="Submit"  />
    </div>

          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:ValidationSummary ID="ValidationSummary1" runat="server"  />
    </form>
                     
                   
    

</body>
</html>
