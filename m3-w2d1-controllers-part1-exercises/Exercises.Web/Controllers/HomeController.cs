using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Order()
        {
            return View();
        }

        public ActionResult OrderResult()
        {
            Person person = new Models.Person();

            if (Request.Params["First"] != null && Request.Params["Middle"] != null && Request.Params["Last"] != null)
            {

                person.FirstName = Request.Params["First"];
                person.Middle = Request.Params["Middle"];
                person.LastName = Request.Params["Last"];
            }


            if (Request["Order"] != null)
            {
                string orderType = Request["Order"];
                if (orderType == "FML")
                {
                    person.OrderedName = person.FirstName + " " + person.Middle + " " + person.LastName;
                }
                else if (orderType == "FL")
                {
                    person.OrderedName = person.FirstName + " " + person.LastName;
                }
                else if (orderType == "LFM")
                {
                    person.OrderedName = person.LastName + ", " + person.FirstName + " " + person.Middle;
                }
                else if (orderType == "LF")
                {
                    person.OrderedName = person.LastName + ", " + person.FirstName;
                }
            }

            return View(person);
        }

        public ActionResult ColorName()
        {
            return View();
        }

        public ActionResult ColorNameResult()
        {
            Person person = new Models.Person();
            List<string> colors = new List<string>();

            if (Request.Params["First"] != null && Request.Params["Last"] != null)
            {

                person.FirstName = Request.Params["First"];
                person.LastName = Request.Params["Last"];
            }

            if (Request["Red"] != null && Request["Red"].Contains("true"))
            {
                colors.Add("red");
            }
            if (Request["Blue"] != null && Request["Blue"].Contains("true"))
            {
                colors.Add("blue");
            }
            if (Request["Green"] != null && Request["Green"].Contains("true"))
            {
                colors.Add("green");
            }

            person.ColorsForName = colors;

            return View(person);
        }

        public ActionResult FizzBuzz()
        {
            return View();
        }

        public ActionResult FizzBuzzResult()
        {
            List<string> result = new List<string>();

            if (!String.IsNullOrEmpty(Request["Divisor1"]) && !String.IsNullOrEmpty(Request["Divisor2"]))
            {
                int divisor1 = int.Parse(Request["Divisor1"]);
                int divisor2 = int.Parse(Request["Divisor2"]);
                string fizz = "";
                string buzz = "";

                result.Add(divisor1.ToString());
                result.Add(divisor2.ToString());

                if (!String.IsNullOrEmpty(Request["Fizz"]) && !String.IsNullOrEmpty(Request["Buzz"]))
                {
                    fizz = Request["Fizz"];
                    buzz = Request["Buzz"];
                }
                else
                {
                    fizz = "Fizz";
                    buzz = "Buzz";
                }

                result.Add(fizz);
                result.Add(buzz);

                for (int i = 1; i < 6; i++)
                {
                    if (!String.IsNullOrEmpty(Request["Number" + i]))
                    {
                        result.Add(Request["Number" + i]);
                        if (int.Parse(Request["Number" + i]) % divisor1 == 0)
                        {
                            result[3 + i] += fizz;
                        }

                        if (int.Parse(Request["Number" + i]) % divisor2 == 0)
                        {
                            result[3 + i] += buzz;
                        }
                    }
                }
            }

            return View(result);
        }

        public ActionResult LastTwo()
        {
            return View();
        }

        public ActionResult LastTwoResult()
        {
            List<string> result = new List<string>();
            for (int i = 1; i < 11; i++)
            {
                if (!String.IsNullOrEmpty(Request["Word" + i]))
                {
                    string word = Request["Word" + i];
                    result.Add(word);

                    string wordWithLastTwoReversed = word.Substring(0, word.Length - 2) + word.Last().ToString() + word.ElementAt(word.Length - 2).ToString();
                    result.Add(wordWithLastTwoReversed);
                }
            }
            return View(result);
        }

        public ActionResult BabyLotto()
        {
            return View();
        }

        public ActionResult BabyLottoResult()
        {
            List<string> result = new List<string>();

            for (int i = 1; i < 6; i++)
            {
                if (!String.IsNullOrEmpty(Request["Ticket" + i]))
                {

                    string ticketNumbers = Request["Ticket" + i];
                    result.Add(ticketNumbers);

                    string[] numbers = ticketNumbers.Split(',');

                    if (numbers[0] == numbers[1] && numbers[0] == numbers[2])
                    {
                        result.Add("green");
                    }
                    else if (numbers[0] == numbers[1] || numbers[0] == numbers[2])
                    {
                        result.Add("silver");
                    }
                    else
                    {
                        result.Add("black");
                    }
                }
            }

            return View(result);
        }

        public ActionResult CigarParty()
        {
            return View();
        }

        public ActionResult CigarPartyResult()
        {
            bool isSuccessful = false;
            if (!String.IsNullOrEmpty(Request["Squirrels"]) && Request["isWeekend"].Contains("true"))
            {
                isSuccessful = (int.Parse(Request["Squirrels"]) >= 40) ? true : false;

            }
            else if (!String.IsNullOrEmpty(Request["Squirrels"]))
            {
                isSuccessful = (int.Parse(Request["Squirrels"]) >= 40 && int.Parse(Request["Squirrels"]) <= 60) ? true : false;
            }
            return View(isSuccessful);
        }
    }
}