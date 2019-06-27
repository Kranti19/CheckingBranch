using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckingGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.name = "Kranti";
            ViewBag.age = "26";
            ViewBag.address = "Hyd";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.name = "Kranti";
            ViewBag.age = "26";
            ViewBag.address = "Hyd";
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