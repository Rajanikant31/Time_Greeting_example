using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB_3.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 5 && hour < 12)
                ViewBag.Greeting = "Good Morning!";
            else if (hour >= 12 && hour < 16)
                ViewBag.Greeting = "Good Afternoon!";
            else if (hour >= 16 && hour < 20)
                ViewBag.Greeting = "Good Evening!";
            else
                ViewBag.Greeting = "It's Late, Please go to sleep ";
            return View();
        }
        public ActionResult CheckDifference()
        {
            Session["Session1"] = "Until Browser Closes";
            TempData["FortheFullRequest"] = "For the Full Request";
            ViewData["MyData"] = "ControllertoView";
            ViewBag.MyBag = "SingleRequest Either ControllertoView or ControllertoController";
            return RedirectToAction("Index", "Home");
        }
    }
}