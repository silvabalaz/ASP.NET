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

        [HttpPost]
        public ActionResult Pogled2()
        {
            ViewBag.Message = "Isprobavam  ViewBag.Message";
            var serial ="SILVA";
            //return Json(new { name = "SILVA", value = serial}, JsonRequestBehavior.AllowGet);
            return View();
        
        }


        // This action handles the form POST and the upload
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                var fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                file.SaveAs(path);
            }
            // redirect back to the index action to show the form once again
            return RedirectToAction("Index");
        }


    }
  
}
