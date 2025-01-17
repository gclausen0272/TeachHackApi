﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using qrattend.Models;

namespace qrattend.Controllers
{
    ///homecontroller 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ///home controller 
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        ///okay
        public IActionResult Index()
        {
            return View();
        }

        ///okay 
        public IActionResult Privacy()
        {
            return View();
        }

        ///sure
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
