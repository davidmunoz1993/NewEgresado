using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Egresados.Models;

namespace Egresados.Controllers
{
    public class PublicacionesEnEsperas1Controller : Controller
    {
        private EgresadosContext db = new EgresadosContext();

        // GET: PublicacionesEnEsperas1
        public ActionResult Index()
        {
            return View(db.PublicacionesEnEsperas.ToList());
        }

        // GET: PublicacionesEnEsperas1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublicacionesEnEspera publicacionesEnEspera = db.PublicacionesEnEsperas.Find(id);
            if (publicacionesEnEspera == null)
            {
                return HttpNotFound();
            }
            return View(publicacionesEnEspera);
        }

        // GET: PublicacionesEnEsperas1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PublicacionesEnEsperas1/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PublicacionEnEspera,FechaInicio,FechaFinalizacion,Asunto,Informacion,EstadoPublicacion")] PublicacionesEnEspera publicacionesEnEspera)
        {
            if (ModelState.IsValid)
            {
                db.PublicacionesEnEsperas.Add(publicacionesEnEspera);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(publicacionesEnEspera);
        }

        // GET: PublicacionesEnEsperas1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublicacionesEnEspera publicacionesEnEspera = db.PublicacionesEnEsperas.Find(id);
            if (publicacionesEnEspera == null)
            {
                return HttpNotFound();
            }
            return View(publicacionesEnEspera);
        }

        // POST: PublicacionesEnEsperas1/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PublicacionEnEspera,FechaInicio,FechaFinalizacion,Asunto,Informacion,EstadoPublicacion")] PublicacionesEnEspera publicacionesEnEspera)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publicacionesEnEspera).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publicacionesEnEspera);
        }

        // GET: PublicacionesEnEsperas1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublicacionesEnEspera publicacionesEnEspera = db.PublicacionesEnEsperas.Find(id);
            if (publicacionesEnEspera == null)
            {
                return HttpNotFound();
            }
            return View(publicacionesEnEspera);
        }

        // POST: PublicacionesEnEsperas1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PublicacionesEnEspera publicacionesEnEspera = db.PublicacionesEnEsperas.Find(id);
            db.PublicacionesEnEsperas.Remove(publicacionesEnEspera);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
