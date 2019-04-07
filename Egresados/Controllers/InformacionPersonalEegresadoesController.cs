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
    public class InformacionPersonalEegresadoesController : Controller
    {
        private EgresadosContext db = new EgresadosContext();

        // GET: InformacionPersonalEegresadoes
        public ActionResult Index()
        {
            return View(db.InformacionPersonalEgresadoes.ToList());
        }

        // GET: InformacionPersonalEegresadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionPersonalEegresado informacionPersonalEegresado = db.InformacionPersonalEegresadoes.Find(id);
            if (informacionPersonalEegresado == null)
            {
                return HttpNotFound();
            }
            return View(informacionPersonalEegresado);
        }

        // GET: InformacionPersonalEegresadoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InformacionPersonalEegresadoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InformacionPersonalEgresadosID,NombresEgresado,PrimerApellidoEgresado,SegundoApellidoEgresado,FechaNacimientoEgresado,NumeroDocumentoEgresado,FechaExpedicionDocumento,SexoEgresado,correoEgresado,DireccionResidenciaEgresado,TelefonoMovilEgresado,TelefonoFijoEgresado,ExtencionTelefonoEgresado,NumeroActaGrado,FotoEgresado,EstadoEgresado,contraseñaEgresado")] InformacionPersonalEegresado informacionPersonalEegresado)
        {
            if (ModelState.IsValid)
            {
                db.InformacionPersonalEegresadoes.Add(informacionPersonalEegresado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(informacionPersonalEegresado);
        }

        // GET: InformacionPersonalEegresadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionPersonalEgresado informacionPersonalEgresado = db.InformacionPersonalEgresadoes.Find(id);
            if (informacionPersonalEgresado == null)
            {
                return HttpNotFound();
            }
            return View(informacionPersonalEgresado);
        }

        // POST: InformacionPersonalEegresadoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InformacionPersonalEgresadosID,NombresEgresado,PrimerApellidoEgresado,SegundoApellidoEgresado,FechaNacimientoEgresado,NumeroDocumentoEgresado,FechaExpedicionDocumento,SexoEgresado,correoEgresado,DireccionResidenciaEgresado,TelefonoMovilEgresado,TelefonoFijoEgresado,ExtencionTelefonoEgresado,NumeroActaGrado,FotoEgresado,EstadoEgresado,contraseñaEgresado")] InformacionPersonalEegresado informacionPersonalEegresado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(informacionPersonalEegresado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(informacionPersonalEegresado);
        }

        // GET: InformacionPersonalEegresadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionPersonalEgresado informacionPersonalEgresado = db.InformacionPersonalEgresadoes.Find(id);
            if (informacionPersonalEgresado == null)
            {
                return HttpNotFound();
            }
            return View(informacionPersonalEgresado);
        }

        // POST: InformacionPersonalEegresadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            // InformacionPersonalEegresado informacionPersonalEgresado = db.InformacionPersonalEgresadoes.Find(id);
            InformacionPersonalEgresado informacionPersonalEgresado = db.InformacionPersonalEgresadoes.Find(id);

            db.InformacionPersonalEgresadoes.Remove(informacionPersonalEgresado);
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
