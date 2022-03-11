using AspNetCsharp03.Models;
using AspNetCsharp03.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IActionResult> Index()
        {
            var vM = new HomeVM
            {
                Categories = await dbContext.Categories.ToListAsync(),
                Sliders = await dbContext.Sliders.ToListAsync()
            };

            return View(vM);
        }

        public IActionResult About()
        {
            return View();
        }
       
    }
}
