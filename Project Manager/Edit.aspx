<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Project_Manager.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 38px;
        }
        .auto-style2 {
            width: 170px;
        }
        .auto-style3 {
            height: 38px;
            width: 170px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>Edit Project</b></div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">Project Code</td>
                <td>
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Project Name</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style2">Project Status</td>
                <td>
                    <asp:DropDownList ID="DDStatus" runat="server">
                        <asp:ListItem>New</asp:ListItem>
                        <asp:ListItem>Active</asp:ListItem>
                        <asp:ListItem>Suspended</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
        <asp:Button ID="BtnProjects" runat="server" Text="My Projects" OnClick="BtnProjects_Click" />
    </form>
</body>
</html>
