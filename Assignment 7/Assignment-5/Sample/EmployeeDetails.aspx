<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="Assignment_5.Sample.EmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
