using Linkit__NoBlock_IDE_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Linkit__NoBlock_IDE_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id, string test)
        {
            _logger.Log(LogLevel.Information, "This is a test message comming from Index: " + id);
            _logger.LogInformation("test = " + test);
            return View();
        }

        public IActionResult Privacy(int id)
        {
            _logger.Log(LogLevel.Information, "This is a test message comming from Privacy : " + id);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
