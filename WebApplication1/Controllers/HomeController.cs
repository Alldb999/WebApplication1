﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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
        public ActionResult MyAction1() {
            ViewBag.Message = "这是我的第一个action";
            ViewBag.Xinxi = "ckz201831980214";
            return View();
        }
        public ActionResult MyAction2()
        {
            ViewBag.Message = "大音希声";
            ViewBag.Xinxi = "大象无形";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}