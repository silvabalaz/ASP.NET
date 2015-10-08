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
       
       

      // GET: /Distance/
        [HttpGet]
        public ActionResult zagreb()
        {
            return View();
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
        
        [HttpPost]
        public JsonResult zagrebPost(Put[] stanice)
        {
            
            return Json(stanice, "json");
        }
    }
}
