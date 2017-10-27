<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudentUI.aspx.cs" Inherits="UniversityManagementSystemDB.UI.AddStudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Student Form: </h1>
        <table>
            <tr>
                <td>Name :  <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Reg No :    <asp:TextBox ID="regNoTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email : <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Address :   <asp:TextBox ID="addreassTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Department :    <asp:DropDownList ID="departmentDropDownList" runat="server"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="addButton" runat="server" Text="Add Student" OnClick="addButton_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
