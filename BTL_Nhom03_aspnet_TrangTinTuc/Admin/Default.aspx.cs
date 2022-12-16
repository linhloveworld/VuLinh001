using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_Nhom03_aspnet_TrangTinTuc.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Label1.Text = "Ban da dang nhap voi Username la: " + Session["Username"].ToString();
            }
            else
            {
                Response.Redirect("Logina.aspx");
            }
        }
    }
}