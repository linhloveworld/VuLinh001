using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTL_asp.net_nhom3.Controllers.admin
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
