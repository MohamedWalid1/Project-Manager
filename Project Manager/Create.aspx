<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Project_Manager.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 170px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>Create New Project</b></div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Project Code</td>
                <td>
                    <asp:TextBox ID="TxtCode" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Project Name</td>
                <td>
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Project Status</td>
                <td>
                    <asp:DropDownList ID="DDStatus" runat="server">
                        <asp:ListItem>New</asp:ListItem>
                        <asp:ListItem Enabled="False">Active</asp:ListItem>
                        <asp:ListItem Enabled="False">Suspended</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="BtnCreate" runat="server" OnClick="BtnCreate_Click" Text="Create" />
        <asp:Button ID="BtnProjects" runat="server" OnClick="BtnProjects_Click" Text="My Projects" />
    </form>
</body>
</html>
