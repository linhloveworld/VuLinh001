<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BTL_Nhom03_aspnet_TrangTinTuc.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang dang nhap cho admin</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
     .style1{
         width:120px;
         height:20px;
     }
     .style2{
         width:280px;
         height:20px;
     }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br /><br />
        </div>
        <table style="align-content:center;" class="TableCenter">
            <tr>
                <td colspan="2" class="divframe_head" style="text-align:center">
                    Dang nhap
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height:30px"></td>
            </tr>
            <tr>
                <td style="text-align:left; padding-left:10px" class="style1">Ten dang nhap</td>
                <td style="text-align:left" class="style2">
                    <asp:TextBox ID="txtUsername" CssClass="textboxLogin" Width="150px" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:left; padding-left:10px" class="style1">Mat khau</td>
                <td style="text-align:left" class="style1>
                    <asp:TextBox ID="txtpassword" TextMode="Password" 
                        CssClass="textboxLogin" Width="150px" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:left;height:38px;vertical-align:bottom;" colspan="2">
                    <asp:Button ID="btnlogin" CssClass="Login" runat="server" Text="Dang nhap" OnClick="btnlogin_Click" />
                </td>
            </tr>
            <tr>
                <td style="width:120px;text-align:left">&nbsp;</td>
                <td style="width:280px;text-align:left">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
