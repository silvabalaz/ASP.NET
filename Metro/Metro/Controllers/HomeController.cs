using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Metro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pogled1()
        {
            return View("MyHomePage");
        }

        public ActionResult Pogled2()
        {
            var serial ="SILVA";
            return Json(new { name = "SILVA", value = serial}, JsonRequestBehavior.AllowGet);
        }



    }
  
}
