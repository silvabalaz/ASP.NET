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
        public ActionResult zagrebPost(MyModel request)
        {

            MyModel stanice = new MyModel() { stations = new string[] {"Item1", "Item2", "Item3", "Item4"}, distance = 0 };

            stanice.stations[0] = request.stations[0];

            return View(request);
            //return Json(stanice, JsonRequestBehavior.AllowGet);

        }


        /*
        public ActionResult zagreb(MyModel request)
        {

            
        }
        */

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
