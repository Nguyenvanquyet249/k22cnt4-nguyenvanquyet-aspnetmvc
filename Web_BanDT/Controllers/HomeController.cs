using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_BanDT.Data;

namespace Web_BanDT.Controllers
{
    public class HomeController : Controller
    {
        private Web_BanDTContext db = new Web_BanDTContext();
        public ActionResult Index()
        {
            var featuredProducts = db.Products.Take(5).ToList();
            return View(featuredProducts);
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