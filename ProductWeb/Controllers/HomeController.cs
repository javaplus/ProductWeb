using Microsoft.AspNetCore.Mvc;
using ProductWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWeb.Controllers
{
    public class HomeController : Controller
    {

        private ProductWeb.Services.BibleService _bibleService = new ProductWeb.Services.BibleService();
        public IActionResult Index()
        {
            BibleVerse bibleVerse = _bibleService.getJohn316();
            return View(bibleVerse);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
