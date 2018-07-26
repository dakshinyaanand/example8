<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookieExample.aspx.cs" Inherits="StatemanagementAndcaching.cookieExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>enter username</td>
                <td>
                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">enter password</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnaddcookie" runat="server" OnClick="btnaddcookie_Click" Text="Add Cookie" />
                </td>
                <td>
                    <asp:Button ID="btnreadcookie" runat="server" OnClick="btnreadcookie_Click" Text="Read Cookie" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
