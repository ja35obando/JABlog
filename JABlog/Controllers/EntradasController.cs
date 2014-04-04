using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JABlog.Models;

namespace JABlog.Controllers
{
    public class EntradasController : Controller
    {
        private JABlogDbContext db = new JABlogDbContext();

        //
        // GET: /Entradas/

        public ActionResult Index()
        {
            return View(db.Entradas.ToList());
        }

        //
        // GET: /Entradas/Details/5

        public ActionResult Details(int id = 0)
        {
            Entradas entradas = db.Entradas.Find(id);
            if (entradas == null)
            {
                return HttpNotFound();
            }
            return View(entradas);
        }

        //
        // GET: /Entradas/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Entradas/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Entradas entradas)
        {
            //entradas.Fecha = "03/04/2014 12:00:00 a:m";
            if (ModelState.IsValid)
            {
                db.Entradas.Add(entradas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entradas);
        }

        //
        // GET: /Entradas/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Entradas entradas = db.Entradas.Find(id);
            if (entradas == null)
            {
                return HttpNotFound();
            }
            return View(entradas);
        }

        //
        // POST: /Entradas/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Entradas entradas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entradas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entradas);
        }

        //
        // GET: /Entradas/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Entradas entradas = db.Entradas.Find(id);
            if (entradas == null)
            {
                return HttpNotFound();
            }
            return View(entradas);
        }

        //
        // POST: /Entradas/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entradas entradas = db.Entradas.Find(id);
            db.Entradas.Remove(entradas);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}