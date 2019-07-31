<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee Details.aspx.cs" Inherits="Assignment_5.Employee_Details" MasterPageFile="~/Site.Master" %>

<asp:Content ID="content2" ContentPlaceHolderID="MainContent" runat="server">
   <h4><table border="1"">
       
        <tr>
            <td>ID:</td>
            <td>
                <asp:Label ID="Label" Text="" runat="server" />
            </td>
        </tr>

        <tr>
            <td>
                Name:
            </td>
            <td>
                <asp:Label ID="Label1" Text="" runat="server" />
            </td>
        </tr>

        <tr>
            <td>
                Email:
            </td>
            <td>
                <asp:Label ID="Label2" Text="" runat="server" />
            </td>
        </tr>

        <tr>
            <td>
                Reporting Manager:
            </td>
            <td>
                <asp:Label ID="Label3" Text="" runat="server" />
            </td>
        </tr>

       
    </table>
      </h4>
       
      
</asp:Content>