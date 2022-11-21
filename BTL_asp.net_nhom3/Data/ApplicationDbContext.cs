using BTL_asp.net_nhom3.Controllers.admin;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BTL_asp.net_nhom3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public IActionResult Index()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }

        public ApplicationDbContext(DbContextOption<ApplicationDbContext> option) : base(option)
        {
            public DbSet<AdminMaster> Admins { get; set;  }
        }
            
    }
}
