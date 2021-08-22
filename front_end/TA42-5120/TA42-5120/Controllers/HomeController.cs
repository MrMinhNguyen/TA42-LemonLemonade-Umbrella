using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TA42_5120.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult Data()
        {
            ViewBag.Title = "UV Data";
            return View();
        }

        public ActionResult Educate()
        {
            ViewBag.Title = "Education";
            return View();
        }

        public ActionResult Recommend()
        {
            ViewBag.Title = "Recommendation";
            return View();
        }
    }
}