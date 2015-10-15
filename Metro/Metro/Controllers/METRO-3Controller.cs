using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Metro.Models;




namespace Metro.Controllers
{
    public class METRO_3Controller : Controller
    {
        
         //GET

        public ActionResult metro3()
        {
            return View();

        }
        
        [HttpGet]
        public JsonResult metro3Get(Kvart request)
        {

            string ulaznaDatoteka = (string)TempData["Metro"];
            // Mapa metro = new Mapa("ZagrebMetro", ulaznaDatoteka);


            List<Ruta> Lista = new List<Ruta>()
            { 

                new Ruta(new Kvart("MAKSIMIR"), new Kvart("SIGET"),5), 
                new Ruta(new Kvart("SIGET"),new Kvart("SPANSKO"),4), 
                new Ruta(new Kvart("SPANSKO"),new Kvart("MEDVESCAK"),8),
                new Ruta(new Kvart("MEDVESCAK"),new Kvart("SPANSKO"), 8), 
                new Ruta(new Kvart("MEDVESCAK"),new Kvart("DUBRAVA"),6), 
                new Ruta(new Kvart("MAKSIMIR"), new Kvart("MEDVESCAK"),5), 
                new Ruta(new Kvart("SPANSKO"),new Kvart("DUBRAVA"), 2), 
                new Ruta(new Kvart("DUBRAVA"),new Kvart("SIGET"),3), 
                new Ruta(new Kvart("MAKSIMIR"),new Kvart("DUBRAVA"),7) 
            };

            //List<Ruta> Lista = metro.KonstrukcijaRuta();
            List<Ruta> r = new List<Ruta>();
            foreach (Ruta ru in Lista)
            { r.Add(ru); }



            MyModel3 model = new MyModel3() { roudtrips = new string[] { "" }, count=0 };

            model.PutCiklus(request,Lista);
     



            //return View("zagrebPost");

            return Json(model, JsonRequestBehavior.AllowGet);
          
     


        }
    }
}
