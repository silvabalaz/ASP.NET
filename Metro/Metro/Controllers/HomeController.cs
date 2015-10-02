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

        /*
        public ActionResult Unos()
        {
            //Stvoriti Metro
            Metro<Kvartovi,Rute, ZagrebMetro> ZgM= new Metro<Ruta>();
            // napraviti prvi element , tj. prvu Rutu u ZagrebMetro
            Ruta Prva = new Ruta
            {
                Start = "MAKSIMIR",
                Kraj = "SIGET",
                Duljina = 5

            };


            return View();
        }
        
        [HttpPost]
        public ActionResult Pogled2()
        {
            ViewBag.Message = "Isprobavam  ViewBag.Message";
            var serial ="SILVA";
            //return Json(new { name = "SILVA", value = serial}, JsonRequestBehavior.AllowGet);
            return View();
        
        }
        */

        // This action handles the form POST and the upload

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
                List<Ruta> Rute = new List<Ruta>();
                List<Kvart> Kvartovi = new List<Kvart>();

                string[] sp = userData.Split(',');

                foreach (string dataItem in sp)
                {

                    var results = dataItem.Split('-');

                    string a = results[0];
                    string a1 = a.ToLower();
                    string b = results[1];
                    var dot = b.Split(':');
                    string c = dot[0];
                    var d = dot[1];
                    string c2 = c[0] + c.Substring(1).ToLower();
                    char[] s = a1.ToCharArray();
                    s[0] = char.ToUpper(s[0]);
                    string a2 = new string(s);
                    int duljina = Int32.Parse(d);
                    Kvart kvart1 = new Kvart(a2);
                    Kvart kvart2 = new Kvart(c2);

                    Kvartovi.Add(kvart1);
                    Kvartovi.Add(kvart2);

                    Ruta temp = new Ruta(kvart1, kvart2, duljina);
                    Rute.Add(temp);
                  
                   
                }
                 Mapa metro = new Mapa(Kvartovi,Rute,"ZagrebMetro");

                //treba mi metro za koji mi trebaju popis ovih ruta, da bi mogla racunati ostalo.
                TempData["Metro"] = metro;
               
                return View(Rute);
               
            }
            else throw new HttpException(404, "File not found");
        }

 }

 }
    


