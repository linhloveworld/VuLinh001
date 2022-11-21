using BTL_asp.net_nhom3.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using Ubiety.Dns.Core;

namespace BTL_asp.net_nhom3.Controllers.admin
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public partial class admin_Default 
    {
        public object Session { get; private set; }

        /*protected void Page_Load(object sender, EventArgs e, object Label1)
        {
            if (Session['Username'] != null)
            {
                Label1.contextmenu = "ban da dang nhap voi Username la: " + Session["Username"].ToString();
            }
            else
            {
                RedirectToAction(nameof("Login.cshtml"));
            }
        }*/
    }
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        private bool AdminExists(string username)
        {
            return _context.Admin.Any(e => e.)
        }
        public async Task<IActionResult> 
    }
}
