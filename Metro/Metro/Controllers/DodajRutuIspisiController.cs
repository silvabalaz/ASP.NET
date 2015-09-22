using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Metro.Models;

namespace Metro.Controllers
{
    public class DodajRutuIspisiController : Controller
    {
        //
        // GET: /DodajRutuIspisi/

        public ActionResult Index()
        {
            Kvart ObjektKvart1 = new Kvart("Maksimir");
            Kvart ObjektKvart2 = new Kvart("Siget");

            Ruta ObjektRuta = new Ruta(ObjektKvart1,ObjektKvart2,5);

            return View();
        }

        //
        // GET: /DodajRutuIspisi/Details/

        public ActionResult Details()
        {

            Kvart ObjektKvart1 = new Kvart("Maksimir");
            Kvart ObjektKvart2 = new Kvart("Siget");

            Ruta ObjektRuta = new Ruta(ObjektKvart1, ObjektKvart2, 5);

            return View(ObjektRuta);
        }

        //
        // GET: /DodajRutuIspisi/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DodajRutuIspisi/Create

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
        // GET: /DodajRutuIspisi/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DodajRutuIspisi/Edit/5

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
        // GET: /DodajRutuIspisi/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DodajRutuIspisi/Delete/5

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
