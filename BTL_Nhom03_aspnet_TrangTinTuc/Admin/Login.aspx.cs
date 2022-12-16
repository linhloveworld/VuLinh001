using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Web.UI.HtmlControls;

namespace BTL_Nhom03_aspnet_TrangTinTuc.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Mahoa a = new Mahoa();
            txtUsername.Text = a.Encrypt("tk6se", "11111");
        }
        protected void btnlogin_Click(object sender,EventArgs e)
        {
            Mahoa a = new Mahoa();
            User b = new User();
            int dangnhap = 0;
            DataTable dtDn = new DataTable();
            dtDn = b.User_Dangnhap(txtUsername.Text.Trim() +
                "",a.Encrypt("tk6se",txtpassword.Text.Trim()+""));
            if (dtDn.Rows.Count >= 0)
            {
                dangnhap = int.Parse("0" + dtDn.Rows[0]["KetQua"]);
                switch (dangnhap)
                {
                    case 0:
                        Session["UserName"] = txtUsername.Text.ToUpper();
                        Session["Password"] = txtpassword.Text + "";
                        Response.Redirect("Default.aspx");
                        break;
                    case 1:
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Thong bao!", "alert('Ten dang nhap khong dung')", true);
                        break;
                    case 2:
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Thong bao!", "alert('Sai mat khau');", true);
                        break;
                    case 3:
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Thong bao!", "alert('Tai khoan bi khoa!');", true);
                        break;
                }
            }
            a = null;
            b = null;
        }
    }
}