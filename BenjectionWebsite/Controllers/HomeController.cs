using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BenjectionWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Stats()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "The best place to get ahold of me.";
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Cheddar()
        {
            return View();
        }

        public ActionResult RnR()
        {
            return View();
        }

        public ActionResult WOW()
        {
            return View();
        }
    }
}