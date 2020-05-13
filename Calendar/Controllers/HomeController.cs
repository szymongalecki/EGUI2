using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalendarEGUIc1.Models;
using Microsoft.VisualBasic;

namespace CalendarEGUIc1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? year, int? month)
        {
            return StartView(year, month);
        }

        public IActionResult StartView(int? year, int? month)
        {
            if (!year.HasValue || !month.HasValue)
            {
                return Default();
            }

            var date = new DateTime(year.Value, month.Value, 1);

            ViewData["Year"] = date.Year;
            ViewData["Month"] = date.Month;
            ViewData["Days"] = DateTime.DaysInMonth(year.Value, month.Value);
            ViewData["Shift"] = (int)date.DayOfWeek;
            ViewData["CurrDay"] = DateTime.Now.Day;

            return View();
        }

        public IActionResult Default()
        {
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;

            return StartView(year, month);
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
