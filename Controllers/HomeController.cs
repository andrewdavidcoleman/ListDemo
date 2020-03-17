using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListDemo.Models;

namespace ListDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieList(string searchText)
        {
            return ViewComponent("MovieList", new { searchText });
        }

        public IActionResult MovieDetail(string id)
        {
            return ViewComponent("MovieDetail", new { id });
        }
    }
}
