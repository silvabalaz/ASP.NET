using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

using Metro.Models;



namespace Metro.Controllers
{
    public class DistanceController : Controller
    {
        //
        // GET: /Distance/

        [HttpPost]
        //public JsonResult distance(string[] stations)
        public ActionResult distance(string[] stations)
        {
            Mapa metro = TempData["Metro"] as Mapa;

            List<Ruta> Rute = new List<Ruta>();
            Put put = new Put(metro);


            // int duljina = (int)put.DuljinaPuta(stations);


            // var model = new { distance = duljina};
            // return Json(model, JsonRequestBehavior.AllowGet);
            return View(metro);
        }

        //
        // GET: /Distance/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Distance/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Distance/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Distance/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Distance/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Distance/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Distance/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
