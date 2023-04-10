<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project_Manager.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 106px;
        }
        .auto-style2 {
            width: 43%;
        }
        .auto-style3 {
            width: 109px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style1">User Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtUsername" runat="server" OnTextChanged="TextBox1_TextChanged" Width="236px"></asp:TextBox>
                </td>                
            </tr>

            <tr>
                <td class="auto-style1">Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" Width="236px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
