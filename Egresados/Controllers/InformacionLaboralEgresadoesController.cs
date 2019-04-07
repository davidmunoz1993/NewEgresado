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
    public class InformacionLaboralEgresadoesController : Controller
    {
        private EgresadosContext db = new EgresadosContext();

        // GET: InformacionLaboralEgresadoes
        public ActionResult Index()
        {
            return View(db.InformacionLaborals.ToList());
        }

        // GET: InformacionLaboralEgresadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionLaboral informacionLaboral = db.InformacionLaborals.Find(id);
            if (informacionLaboral == null)
            {
                return HttpNotFound();
            }
            return View(informacionLaboral);
        }

        // GET: InformacionLaboralEgresadoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InformacionLaboralEgresadoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InformacionLaboralID,trabajaActualmente,nombresJefeLaboral,apellidoJefeLaboral,telefonoJefeLaboral,nombreEmpresaLaboral,direccionEmpresaLaboral,cargoOcupacionLaboral,fechaIngresoLaboral,fechaEgresoLaboral")] InformacionLaboralEgresado informacionLaboralEgresado)
        {
            if (ModelState.IsValid)
            {
                db.InformacionLaboralEgresadoes.Add(informacionLaboralEgresado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(informacionLaboralEgresado);
        }

        // GET: InformacionLaboralEgresadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionLaboral informacionLaboral = db.InformacionLaborals.Find(id);
            if (informacionLaboral == null)
            {
                return HttpNotFound();
            }
            return View(informacionLaboral);
        }

        // POST: InformacionLaboralEgresadoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InformacionLaboralID,trabajaActualmente,nombresJefeLaboral,apellidoJefeLaboral,telefonoJefeLaboral,nombreEmpresaLaboral,direccionEmpresaLaboral,cargoOcupacionLaboral,fechaIngresoLaboral,fechaEgresoLaboral")] InformacionLaboral informacionLaboral)
        {
            if (ModelState.IsValid)
            {
                db.Entry(informacionLaboral).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(informacionLaboral);
        }

        // GET: InformacionLaboralEgresadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionLaboralEgresado informacionLaboralEgresado = db.InformacionLaboralEgresadoes.Find(id);
            if (informacionLaboralEgresado == null)
            {
                return HttpNotFound();
            }
            return View(informacionLaboralEgresado);
        }

        // POST: InformacionLaboralEgresadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InformacionLaboralEgresado informacionLaboralEgresado = db.InformacionLaboralEgresadoes.Find(id);
            db.InformacionLaboralEgresadoes.Remove(informacionLaboralEgresado);
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
