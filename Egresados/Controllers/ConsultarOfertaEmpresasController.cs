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
    public class ConsultarOfertaEmpresasController : Controller
    {
        private EgresadosContext db = new EgresadosContext();

        // GET: ConsultarOfertaEmpresas
        public ActionResult Index()
        {
            return View(db.AgregarOfertas.ToList());
        }

        // GET: ConsultarOfertaEmpresas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultarOfertaEmpresa consultarOfertaEmpresa = db.ConsultarOfertaEmpresas.Find(id);
            if (consultarOfertaEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(consultarOfertaEmpresa);
        }

        // GET: ConsultarOfertaEmpresas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConsultarOfertaEmpresas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AgregarOfertaID,FechaInicio,FechaFinal,Asunto,PerfilRequerido,Descripcion")] ConsultarOfertaEmpresa consultarOfertaEmpresa)
        {
            if (ModelState.IsValid)
            {
                db.ConsultarOfertaEmpresas.Add(consultarOfertaEmpresa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consultarOfertaEmpresa);
        }

        // GET: ConsultarOfertaEmpresas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgregarOferta agregarOferta = db.AgregarOfertas.Find(id);
            if (agregarOferta == null)
            {
                return HttpNotFound();
            }
            return View(agregarOferta);
        }

        // POST: ConsultarOfertaEmpresas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AgregarOfertaID,FechaInicio,FechaFinal,Asunto,PerfilRequerido,Descripcion")] AgregarOferta agregarOferta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agregarOferta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agregarOferta);
        }

        // GET: ConsultarOfertaEmpresas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultarOfertaEmpresa consultarOfertaEmpresa = db.ConsultarOfertaEmpresas.Find(id);
            if (consultarOfertaEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(consultarOfertaEmpresa);
        }

        // POST: ConsultarOfertaEmpresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConsultarOfertaEmpresa consultarOfertaEmpresa = db.ConsultarOfertaEmpresas.Find(id);
            db.ConsultarOfertaEmpresas.Remove(consultarOfertaEmpresa);
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
