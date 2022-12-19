﻿using Backery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Backery.Data;

namespace Backery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDB db;

        public HomeController(ApplicationDB context)
        {
            db = context;
        }
        
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Cart()
        {
            ViewBag.Data = db.Products.ToArray();
            ViewBag.Res = db.Reservations.ToArray();
            return View();
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
