using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewReview()
        {
            return View();
        }

        public ActionResult SeeAllReviews()
        {
            List<Review> results = new List<Review>();

            IReviewDAL dal = new ReviewSqlDAL();
            
            if (!String.IsNullOrEmpty(Request["username"]) && !String.IsNullOrEmpty(Request["rating"])
                && !String.IsNullOrEmpty(Request["title"]) && !String.IsNullOrEmpty(Request["message"]))
            {
                Review r = new Review();
                r.Username = Request["username"];
                r.Rating = int.Parse(Request["rating"]);
                r.Title = Request["title"];
                r.Message = Request["message"];

                dal.SaveReview(r);
            }

            results = dal.GetAllReviews();

            return View(results);
        }
    }
}