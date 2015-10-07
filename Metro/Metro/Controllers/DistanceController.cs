using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using Metro.Models;



namespace Metro.Controllers
{
    public class DistanceController : Controller
    {

        // GET: /Distance/
        [HttpGet]
        public ActionResult distance()
        {
            return View();
        }

        [HttpPost]
        public ActionResult distance(List<string> Stanice)
        {

            int duljina;

            //Mapa metro = new Mapa(null,null,"ZagrebMetro");
            var metro = TempData["Metro"] as Mapa;

                //duljina = (int)metro.DuljinaPuta(Stanice);

            if (Stanice != null)
            {
                
                List<Kvart> stations = new List<Kvart>(Stanice.Count);

                Stanice.ForEach((item) =>
                {
                    stations.Add(new Kvart(item));
                });
;
                metro.duljina = (int)metro.DuljinaPuta(stations);
            }

            if (metro != null)
                return View("Pogled2");

                //return RedirectToAction("Distance", new Mapa(metro.Kvartovi,metro.Rute,metro.ImeMetroa) {}); 


            else return View("Pogled2");
         }



      
       


        
    }
}
