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
            

            string ulaznaDatoteka  = (string)TempData["Metro"];
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



                MyModel1 model = new MyModel1() { stations = new string[] { "" } };

                model.stations = request.stations;


                MyModel2 model2 = new MyModel2() { distance = 0 };
                model2.distance = model.DuljinaPuta(r);



        
                //return View("zagrebPost");

                return Json(model2 ,JsonRequestBehavior.AllowGet);
          

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
