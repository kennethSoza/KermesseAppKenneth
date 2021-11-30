using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KermesseApp.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace KermesseApp.Controllers
{
    public class HomeController : Controller
    {
        KERMESSEEntities db = new KERMESSEEntities();
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

    }
}