<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxContactUs.aspx.cs" Inherits="Tutorial17.AjaxContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AjaxContactUs</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;color:darkslateblue">
            <h1>WELCOME TO AJAXCONATCT WEB PAGE</h1>
        </div>
        <div></div>
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
          <ContentTemplate>
              <asp:Table runat="server" ID="table1" HorizontalAlign="Center">

                  <asp:TableRow>
                      <asp:TableHeaderCell Width="40%">
                          Name :
                      </asp:TableHeaderCell>

                      <asp:TableCell Width="60%">
                          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" 
                              runat="server" ErrorMessage="USER NAME REQUIRED" Font-Italic="true" ForeColor="#ff3300">
                          </asp:RequiredFieldValidator>
                      </asp:TableCell>

                  </asp:TableRow>

                  <asp:TableRow>

                      <asp:TableHeaderCell Width="40%">
                          Email :
                      </asp:TableHeaderCell>

                      <asp:TableCell Width="60%">
                          <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                              ErrorMessage="EMAIL CAN'T BE EMPTY" Font-Italic="true" ForeColor="Red" ControlToValidate="TextBox2" Display="Dynamic">
                          </asp:RequiredFieldValidator>
                          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                               ErrorMessage="EMAIL IS NOT IN EXACT PATTERN" Display="Dynamic" 
                              Font-Italic="true" ForeColor="Red" 
                              ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ControlToValidate="TextBox2">
                          </asp:RegularExpressionValidator>
                      </asp:TableCell>
                  </asp:TableRow>

              </asp:Table>
              <br />
              <br />
              <div style="text-align:center">
                  <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
              </div>
              <br />
              <br />
              <div style="text-align:center;color:darkorchid">
                  <asp:Label ID="Label1" runat="server"></asp:Label> 
              </div>
          </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            <ProgressTemplate>
                <div style="text-align:center;color:purple">
                    Loading.......!!!!!!!!!!!!!!!!!
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>
    </div>
    </form>
</body>
</html>
