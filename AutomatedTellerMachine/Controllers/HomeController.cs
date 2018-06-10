using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        // Attribute is not specified afer MyLoggingFilter because LoggingFilter.cs file is executing that method
        [MyLoggingFilter]
        public ActionResult Index()
        {
            //throw new StackOverflowException();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having Trouble? Send us a message";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            //TODO: Send message to HQ
            ViewBag.TheMessage = "Thanks we got your message";

            return View();
        }


        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVCATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

           // return Content(serial);

            return Json(new { name = "Serial", value = serial }, JsonRequestBehavior.AllowGet);
        }
    }
}