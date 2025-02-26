using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Visitalia.Data;

namespace Visitalia.Controllers
{
    public class HomeController : Controller
    {
        private VisitaliaContext db = new VisitaliaContext();

        public ActionResult Index()
        {
            var Tours = db.Tours.ToList();
            return View(Tours);
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

        public ActionResult TourList()
        {
            var Tours = db.Tours.ToList();
            return View(Tours);
        }

        public ActionResult TourInfo(int id)
        {
            if (id <= 0)
            {
                ViewBag.ErrorMessage = "Invalid Tour ID.";
                return View("Error");
            }
            var Tours = db.Tours.FirstOrDefault(c => c.ID == id);
            if (Tours == null)
            {
                ViewBag.ErrorMessage = "Tour information could not be found.";
                return View("Error");
            }
            return View(Tours);
        }
    }
}