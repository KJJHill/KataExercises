using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechElevator.Web.Models;

namespace TechElevator.Web.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Page1()
        {
            return View();
        }
        public ActionResult Page2()
        {
            if (!String.IsNullOrEmpty(Request["color"]))
            {
                Session["color"] = Request["color"];
            }

            return View();
        }

        public ActionResult Page3()
        {
            if (!String.IsNullOrEmpty(Request["food"]))
            {
                Session["food"] = Request["food"];
            }

            return View();
        }

        public ActionResult Summary()
        {
            if (!String.IsNullOrEmpty(Request["season"]))
            {
                Session["season"] = Request["season"];
            }

            FavoriteThings fv = new FavoriteThings();
            fv.Color = Session["color"].ToString();
            fv.Food = Session["food"].ToString();
            fv.Season = Session["season"].ToString();

            return View(fv);
        }
    }
}