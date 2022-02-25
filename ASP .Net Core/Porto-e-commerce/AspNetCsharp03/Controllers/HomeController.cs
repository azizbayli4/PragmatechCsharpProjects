using AspNetCsharp03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCsharp03.Controllers
{
    public class HomeController : Controller
    {
        private readonly PortoDbContext dbContext;

        public HomeController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult Index()
        {
            var category= dbContext.Categories.ToList();

            return View(category);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
