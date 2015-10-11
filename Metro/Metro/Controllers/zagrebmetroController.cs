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
    public class zagrebmetroController : Controller
    {
        //GET

        public ActionResult zagreb()
        {
            return View();

        }

        [HttpPost]
        public JsonResult zagrebPost(MyModel1 request)
        {
            

            string ulaznaDatoteka  =(string)TempData["Metro"];
            Mapa metro = new Mapa("ZagrebMetro", ulaznaDatoteka);
            var Lista = metro.KonstrukcijaRuta();

            MyModel1 model = new MyModel1() { stations = new string[] { "maksimir", "Siget", "Spansko" } };

            List<Ruta> r = new List<Ruta>();
            foreach (Ruta ru in Lista)
            { r.Add(ru); }

            MyModel2 model2 = new MyModel2() { distance = 0 };
            model2.distance = model.DuljinaPuta(r);
          
      

            ViewBag.Message = model2.distance;
            //return View("Pogled2");

            return Json(model2, JsonRequestBehavior.AllowGet);

        }



        /*
        [HttpPost]
        public ActionResult zagrebPost(string[] stations) //List<string> Stanice)
        {
            
            if (Stanice != null)
            {

                List<Kvart> stations = new List<Kvart>(Stanice.Count);

                Stanice.ForEach((item) =>
                {
                   //stations.Add(new Kvart(item));
                    stations.Add(new Kvart(item));
                });
                ;
              


                return View((object)stations);
            }  

         

            return View((object)stations);
        }  */
        
       
    }
}
