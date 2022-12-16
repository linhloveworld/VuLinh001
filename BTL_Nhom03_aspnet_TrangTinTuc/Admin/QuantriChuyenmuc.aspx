<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuantriChuyenmuc.aspx.cs" Inherits="BTL_Nhom03_aspnet_TrangTinTuc.Admin.QuantriChuyenmuc" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quan tri chuyen muc</title>
    <style type="text/css">
        .style6{
            width:330px;
            background-color:lightyellow;
        }
        .style7{
            height:28px;
        }
        .style100{
          background-color:#00ff90;
        }
        .style101{
            width:325px;
            background-color:aquamarine;
        }
    </style>
    <table style="background-color:chartreuse;width:100%;">
        <tr>
            <td colspan="2" class="style100">
                <asp:HiddenField ID="hidAction" runat="server"></asp:HiddenField>
                <asp:HiddenField ID="hiUser" runat="server"></asp:HiddenField>
                <asp:HiddenField ID="hiCateID" runat="server"></asp:HiddenField>
                <asp:HiddenField ID="hiSearch" runat="server"></asp:HiddenField>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:center;background-color:aqua;color:#FFFFFF;font-weight:bold;" class="style7">
                Quan tri he thong: Quan ly chuyen muc
            </td>
        </tr>
        <tr>
            <td colspan="2" class="style6">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style100">
                <asp:DropDownList ID="drChuyenmucChaEdit" runat="server" width="205px"
                    AppendDataBoundItems="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style101" style="text-align:right">
                Ten chuyen muc
            </td>
            <td class="style100">
                <asp:TextBox ID="txtTenChuyenMuc" runat="server" width="200px">
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align:center;border:1px solid #DEDEDE" colspan="2" class="style100">
                <asp:LinkButton ID="lbtnThoat" runat="server" PostBackUrl="~/Admin/Default.aspx"
                    onClick="lbtnThoat_"
            </td>
        </tr>
    </table>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
