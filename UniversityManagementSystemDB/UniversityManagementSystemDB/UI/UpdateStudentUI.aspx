<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStudentUI.aspx.cs" Inherits="UniversityManagementSystemDB.UI.UpdateStudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Update Student</h1>
        <table>
            <h4><td><asp:Label ID="notificationLabel" runat="server" Text=""></asp:Label></td></h4>
            <tr>
                <td>Reg. No: </td>
                <td>
                    <asp:TextBox ID="regNoTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" /></td>
            </tr>
            <tr>
                <td>Name: </td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email: </td>
                <td>
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Address: </td>
                <td>
                    <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Department: </td>
                <td>
                    <asp:TextBox ID="departmentTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" /></td>
            </tr>
            

        </table>
    </div>
    </form>
</body>
</html>
