using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Summer_School_Jan20.Controllers
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

        public ActionResult MovieSummary()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TicketBooking()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Cast()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MediaGallery()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}