using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QFGreenBean.Models;

namespace QFGreenBean.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            StudentScheduleGenerator generator = new StudentScheduleGenerator();

            return View(generator);
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