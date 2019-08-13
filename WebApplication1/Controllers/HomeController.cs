using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //GET /home/index
        public ActionResult Index()
        {
            return View();
        }
        //GET /home/about
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

        /// <summary>
        /// url path way returning string: letterCase
        /// </summary>
        /// <param name="letterCase"></param>
        /// <returns></returns>
        public ActionResult Serial(string letterCase)
        {
            ViewBag.Message = "Your contact page.";
            var serial = "this is the serial mock up";
            if (letterCase == "upper")
            {
                return Content(serial.ToUpper());
            }
            return Content(serial);
        }
    }
}