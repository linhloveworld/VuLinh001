using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTL_asp.net_nhom3.Models
{
    public class AdminMaster : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public class Admin
    {
        public string AdminID { get; set; }
        public string AdminName { get; set; }
    }
}
