using System;
using System.Net;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using monolithsvc.Models;
using Microsoft.Extensions.Configuration; 

namespace monolithsvc.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        } 

        public IActionResult Index()
        {
            ViewBag.internalVer = _configuration["internalVer"];
            ViewBag.hostname = Environment.MachineName;
            ViewBag.dotnetver = EnvironmentUtils.GetFrameworkDescription();

            return View();
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
