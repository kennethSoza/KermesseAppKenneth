using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KermesseApp.Models;
using System.Data.Entity;
using System.Web.Mvc;
namespace KermesseApp.Controllers
{
    public class ReporteriaController : Controller
    {
        KERMESSEEntities db = new KERMESSEEntities();
        // GET: Reporteria
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult areaReportes()
        {
            ViewBag.reportes = reportes();
            return View();
        }

        public List<SelectListItem> reportes()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Reporte de lista precio",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Text = "PlaceHolder",
                    Value = "2"
                },
                new SelectListItem()
                {
                    Text = "PlaceHolder",
                    Value = "3"
                }
            };
        }

        [HttpPost]
        public ActionResult redirigir(String Reportes)
        {

            
            String Controller = "Home";
            String Action = "Index";
            int id = Int32.Parse(Reportes);
            if (id == 1 )
            {
                Controller = "Tbl_listaprecio";
                Action = "VistaRptListaPrecio";
                return RedirectToAction("VistaRptListaPrecio", "Tbl_listaprecio");
            }

            return RedirectToAction(Controller, Action);
        }
    }
}