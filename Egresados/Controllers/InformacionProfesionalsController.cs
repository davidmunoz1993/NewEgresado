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
    public class InformacionProfesionalsController : Controller
    {
        private EgresadosContext db = new EgresadosContext();

        // GET: InformacionProfesionals
        public ActionResult Index()
        {
            return View(db.InformacionProfesionals.ToList());
        }

        // GET: InformacionProfesionals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionProfesional informacionProfesional = db.InformacionProfesionals.Find(id);
            if (informacionProfesional == null)
            {
                return HttpNotFound();
            }
            return View(informacionProfesional);
        }

        // GET: InformacionProfesionals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InformacionProfesionals/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InformacionProfesionalID,estudiaActualmente,fechaTerminacionProfesional,duracionProfesional")] InformacionProfesional informacionProfesional)
        {
            if (ModelState.IsValid)
            {
                db.InformacionProfesionals.Add(informacionProfesional);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(informacionProfesional);
        }

        // GET: InformacionProfesionals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionProfesional informacionProfesional = db.InformacionProfesionals.Find(id);
            if (informacionProfesional == null)
            {
                return HttpNotFound();
            }
            return View(informacionProfesional);
        }

        // POST: InformacionProfesionals/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InformacionProfesionalID,estudiaActualmente,fechaTerminacionProfesional,duracionProfesional")] InformacionProfesional informacionProfesional)
        {
            if (ModelState.IsValid)
            {
                db.Entry(informacionProfesional).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(informacionProfesional);
        }

        // GET: InformacionProfesionals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionProfesional informacionProfesional = db.InformacionProfesionals.Find(id);
            if (informacionProfesional == null)
            {
                return HttpNotFound();
            }
            return View(informacionProfesional);
        }

        // POST: InformacionProfesionals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InformacionProfesional informacionProfesional = db.InformacionProfesionals.Find(id);
            db.InformacionProfesionals.Remove(informacionProfesional);
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
