using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
//using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System;

namespace BTL_asp.net_nhom3.Controllers.admin
{
    public class AdminMaster : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public partial class admin_AdminMaster: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
