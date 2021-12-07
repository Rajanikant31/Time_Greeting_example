using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string strTempData = Convert.ToString(TempData["FortheFullRequest"]);
            string str2Session = Session["Session1"].ToString();
            string str3ViewData = Convert.ToString(ViewData["MyData"]);
            string str4ViewBag = ViewBag.MyBag;
            return View();
        }

  
    }
}