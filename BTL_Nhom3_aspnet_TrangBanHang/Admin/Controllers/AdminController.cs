using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Owin.Security;
using System;
using System.Threading.Tasks;
using AuthenticationManager = Microsoft.AspNetCore.Server.HttpSys.AuthenticationManager;

namespace BTL_Nhom3_aspnet_TrangBanHang.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Logoff()
        {
            AuthenticationManager.Signout();
            return RedirectToAction("Login");
        }
        public ActionResult Login(String returnUrl)
        {
            if (returnUrl != null)
            {
                if (returnUrl.Contains("/Admin/"))
                {
                    Response.Redirect("/Admin/Account/Login?returnUrl=" + returnUrl);
                }
                ViewBag.ReturnUrl = returnUrl;
            }
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(String Username, String Password, string returnUrl)
        {
            var user = await UserManager.FindAsync(Username, Password);
            if(user != null)
            {
                await SignInAsync(user, false);
                if (returnUrl == null || returnUrl == "")
                {
                    returnUrl = "/Admin/Master";
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect(returnUrl);
                }
            }
            else
            {
                ModelState.AddModelError(" ", "Invalid username or password");
            }
            return View();
        }
        private AuthenticationManager AuthenticationMannager => HttpContext.GetOwinContext().Authentication;
        private async Task SignInAsync(ApplicationUser user, bool isPersistent)
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            var identity = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, identity);
        }
    }
}
