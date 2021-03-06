﻿using System.Web.Mvc;

namespace La_Piazzetta.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "La Piazzetta";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.Message = "Menu.";

            return View();
        }

        public ActionResult Stock()
        {
            ViewBag.Message = "Stock.";
            return View();
        }
        public ActionResult Loyality()
        {
            ViewBag.Message = "Loyality.";

            return View();
        }

        public ActionResult BA()
        {
            ViewBag.Message = "BA.";

            return View();
        }

        public ActionResult Help()
        {
            ViewBag.Message = "Help.";

            return View();
        }
    }
}