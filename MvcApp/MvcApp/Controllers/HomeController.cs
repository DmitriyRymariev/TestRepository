﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "YEEEEEEEEEE!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
