using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

using Metro.Models;

namespace Metro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {

            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var dataFile = Server.MapPath("~/Datoteka");
                var path = Path.Combine(dataFile, fileName);
                file.SaveAs(path);
                string userData = new StreamReader(file.InputStream).ReadToEnd(); 
                Mapa metro = new Mapa("ZagrebMetro", userData );
                TempData["Metro"] = userData;
                TempData["M"] = metro;

                var Lista = metro.KonstrukcijaRuta();

                MyModel1 model = new MyModel1() { stations = new string[] { "maksimir","Siget","Spansko" } };
               
                List<Ruta> r = new List<Ruta>();
                foreach (Ruta ru in Lista)
                { r.Add(ru); }

                int duljina = model.DuljinaPuta(r);
                 ViewBag.Message = duljina;
                 //Mapa metro2 = TempData.Peek("Metro");
                //TempData.Keep("Metro");
                //return View(Rute);
                //return RedirectToAction("zagrebPost", "zagrebmetro");
                return View("Pogled2");
            }
            else throw new HttpException(404, "File not found");
        }


       
             
 }

 }
    


