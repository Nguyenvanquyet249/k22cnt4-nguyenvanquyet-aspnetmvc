using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.message = "xin chao Nguyen Van Quyet";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.message = "Day la trang About";
            return View();
        }
    }
}