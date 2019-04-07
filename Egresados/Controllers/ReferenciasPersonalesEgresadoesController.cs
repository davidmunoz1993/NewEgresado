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
    public class ReferenciasPersonalesEgresadoesController : Controller
    {
        private EgresadosContext db = new EgresadosContext();

        // GET: ReferenciasPersonalesEgresadoes
        public ActionResult Index()
        {
            return View(db.ReferenciasPersonales.ToList());
        }

        // GET: ReferenciasPersonalesEgresadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasPersonalesEgresado referenciasPersonalesEgresado = db.ReferenciasPersonalesEgresadoes.Find(id);
            if (referenciasPersonalesEgresado == null)
            {
                return HttpNotFound();
            }
            return View(referenciasPersonalesEgresado);
        }

        // GET: ReferenciasPersonalesEgresadoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferenciasPersonalesEgresadoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "referenciasPersonalesID,NombresReferencia,PrimerApellidoReferencia,SegundoApellidoReferencia,CargoReferencia,TelefonoFijoReferencia,ExtTelefonoReferencia,TelefonoMovilReferencia")] ReferenciasPersonalesEgresado referenciasPersonalesEgresado)
        {
            if (ModelState.IsValid)
            {
                db.ReferenciasPersonalesEgresadoes.Add(referenciasPersonalesEgresado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referenciasPersonalesEgresado);
        }

        // GET: ReferenciasPersonalesEgresadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasPersonales referenciasPersonales = db.ReferenciasPersonales.Find(id);
            if (referenciasPersonales == null)
            {
                return HttpNotFound();
            }
            return View(referenciasPersonales);
        }

        // POST: ReferenciasPersonalesEgresadoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "referenciasPersonalesID,NombresReferencia,PrimerApellidoReferencia,SegundoApellidoReferencia,CargoReferencia,TelefonoFijoReferencia,ExtTelefonoReferencia,TelefonoMovilReferencia")] ReferenciasPersonales referenciasPersonales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referenciasPersonales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referenciasPersonales);
        }

        // GET: ReferenciasPersonalesEgresadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasPersonalesEgresado referenciasPersonalesEgresado = db.ReferenciasPersonalesEgresadoes.Find(id);
            if (referenciasPersonalesEgresado == null)
            {
                return HttpNotFound();
            }
            return View(referenciasPersonalesEgresado);
        }

        // POST: ReferenciasPersonalesEgresadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferenciasPersonalesEgresado referenciasPersonalesEgresado = db.ReferenciasPersonalesEgresadoes.Find(id);
            db.ReferenciasPersonalesEgresadoes.Remove(referenciasPersonalesEgresado);
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
