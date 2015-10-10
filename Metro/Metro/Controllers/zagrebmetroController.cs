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
        public ActionResult zagrebPost(MyModel1 request)
        {

            var m = TempData["Metro"] as Mapa;    
            
            MyModel1 model = new MyModel1() { stations = new string[] {"bla"}};

          

            model.stations = new string[request.stations.Length];
            request.stations.CopyTo(model.stations, 0);


            //List<Ruta> r = new List<Ruta>();
            //var List = m.KonstrukcijaRuta();
            /*
            foreach(Ruta ru in List)
            { r.Add(ru); }
           int duljina = model.DuljinaPuta(r);
            */


            return View(request);
            //return Json(r, JsonRequestBehavior.AllowGet);

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
