using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linkit__NoBlock_IDE_WebApp.Controllers
{
    public class BlueprintController : Controller
    {

        private readonly ILogger<HomeController> logger;

        public BlueprintController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            logger.LogInformation("Skurt :D");
            return View();
        }
    }
}
