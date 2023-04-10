<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="Project_Manager.Projects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 100%;
            margin-right: 0px;
        }
        .auto-style4 {
            width: 150px;
        }
        .auto-style5 {
            width: 150px;
        }
        .auto-style6 {
            width: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>My Projects<br />
            <asp:Button ID="BtnNew" runat="server" OnClick="BtnNew_Click" Text="Create New Project" />
            </b></div>
        <table class="auto-style3" border =" 1">
        <tr>
            <td class="auto-style4"><b>Project Code</b></td>
            <td class="auto-style5"><b>Project Name</b></td>
            <td class="auto-style6"><b>Project Status</b></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
        </tr>
        </table>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

        
    </form>
    </body>
</html>
