using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part16.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            TempData["myKey"] = "Data from index method";
            return View();
        }

        public ActionResult Index2() {
            //ViewBag.MyKey = TempData["myKey"];
            ViewBag.MyKey = TempData.Peek("myKey");
            TempData.Keep();
            return View();
        }

        public ActionResult Index3() {
            ViewBag.MyKey = TempData["myKey"];
            return View();
        }
    }
}