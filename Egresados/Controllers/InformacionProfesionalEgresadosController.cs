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
    public class InformacionProfesionalEgresadosController : Controller
    {
        private EgresadosContext db = new EgresadosContext();

        // GET: InformacionProfesionalEgresados
        public ActionResult Index()
        {
            return View(db.InformacionProfesionals.ToList());
        }

        // GET: InformacionProfesionalEgresados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionProfesionalEgresados informacionProfesionalEgresados = db.InformacionProfesionalEgresados.Find(id);
            if (informacionProfesionalEgresados == null)
            {
                return HttpNotFound();
            }
            return View(informacionProfesionalEgresados);
        }

        // GET: InformacionProfesionalEgresados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InformacionProfesionalEgresados/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InformacionProfesionalID,estudiaActualmente,fechaTerminacionProfesional,duracionProfesional")] InformacionProfesionalEgresados informacionProfesionalEgresados)
        {
            if (ModelState.IsValid)
            {
                db.InformacionProfesionalEgresados.Add(informacionProfesionalEgresados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(informacionProfesionalEgresados);
        }

        // GET: InformacionProfesionalEgresados/Edit/5
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

        // POST: InformacionProfesionalEgresados/Edit/5
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

        // GET: InformacionProfesionalEgresados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionProfesionalEgresados informacionProfesionalEgresados = db.InformacionProfesionalEgresados.Find(id);
            if (informacionProfesionalEgresados == null)
            {
                return HttpNotFound();
            }
            return View(informacionProfesionalEgresados);
        }

        // POST: InformacionProfesionalEgresados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InformacionProfesionalEgresados informacionProfesionalEgresados = db.InformacionProfesionalEgresados.Find(id);
            db.InformacionProfesionalEgresados.Remove(informacionProfesionalEgresados);
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
