﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DatosJson.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string ruta = Server.MapPath("/");
            Console.Read();
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
    }
}