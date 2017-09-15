﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MDCDeslogado()
        {
            return View();
        }

        public ActionResult MDCSoMenu()
        {
            return View();
        }

        public ActionResult MDC2Nivel()
        {
            return View();
        }

        public ActionResult MDCCompleto()
        {
            return View();
        }
    }
}