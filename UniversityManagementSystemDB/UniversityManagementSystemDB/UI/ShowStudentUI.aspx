<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowStudentUI.aspx.cs" Inherits="UniversityManagementSystemDB.UI.ShowStudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Show Student</h1>
        <asp:GridView ID="showStudentGridView" runat="server" AutoGenerateColumns="False">
            <columns>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("StudentName") %>'>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Reg. No">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("RegNo") %>'>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Email") %>'>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Address">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Address") %>'>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Department">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("DeptName") %>'>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:HyperLink runat="server" Text="Update" NavigateUrl='<%#Eval("StudentId","UpdateStudentUI.aspx?id={0}") %>'></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                
            </columns>
        </asp:GridView>

    </div>
    </form>
</body>
</html>
