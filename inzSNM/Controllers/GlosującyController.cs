using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using inzSNM.Models;

namespace inzSNM.Controllers
{
    public class GlosującyController : Controller
    {
        private inzSNMEntities db = new inzSNMEntities();

        // GET: Glosujący
        public ActionResult Index()
        {
            var glosujący = db.Glosujący.Include(g => g.Narodowosc).Include(g => g.Plec).Include(g => g.Wiek);
            return View(glosujący.ToList());
        }

        // GET: Glosujący/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Glosujący glosujący = db.Glosujący.Find(id);
            if (glosujący == null)
            {
                return HttpNotFound();
            }
            return View(glosujący);
        }

        // GET: Glosujący/Create
        public ActionResult Create()
        {
            ViewBag.Id_Narod = new SelectList(db.Narodowosc, "Id_Narod", "Narodowosc1");
            ViewBag.Id_Plec = new SelectList(db.Plec, "Id_Plec", "Plec1");
            ViewBag.Id_Wiek = new SelectList(db.Wiek, "Id_Wiek", "Wiek1");
            return View();
        }

        // POST: Glosujący/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Osoba,Email,Id_Narod,Id_Wiek,Id_Plec")] Glosujący glosujący)
        {
            if (ModelState.IsValid)
            {
                db.Glosujący.Add(glosujący);
                db.SaveChanges();
                return RedirectToAction("Index"); //zrobić przekieowanie na ankietę !!!
            }

            ViewBag.Id_Narod = new SelectList(db.Narodowosc, "Id_Narod", "Narodowosc1", glosujący.Id_Narod);
            ViewBag.Id_Plec = new SelectList(db.Plec, "Id_Plec", "Plec1", glosujący.Id_Plec);
            ViewBag.Id_Wiek = new SelectList(db.Wiek, "Id_Wiek", "Wiek1", glosujący.Id_Wiek);
            return View(glosujący);
        }

        // GET: Glosujący/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Glosujący glosujący = db.Glosujący.Find(id);
            if (glosujący == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Narod = new SelectList(db.Narodowosc, "Id_Narod", "Narodowosc1", glosujący.Id_Narod);
            ViewBag.Id_Plec = new SelectList(db.Plec, "Id_Plec", "Plec1", glosujący.Id_Plec);
            ViewBag.Id_Wiek = new SelectList(db.Wiek, "Id_Wiek", "Wiek1", glosujący.Id_Wiek);
            return View(glosujący);
        }

        // POST: Glosujący/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Osoba,Email,Id_Narod,Id_Wiek,Id_Plec")] Glosujący glosujący)
        {
            if (ModelState.IsValid)
            {
                db.Entry(glosujący).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Narod = new SelectList(db.Narodowosc, "Id_Narod", "Narodowosc1", glosujący.Id_Narod);
            ViewBag.Id_Plec = new SelectList(db.Plec, "Id_Plec", "Plec1", glosujący.Id_Plec);
            ViewBag.Id_Wiek = new SelectList(db.Wiek, "Id_Wiek", "Wiek1", glosujący.Id_Wiek);
            return View(glosujący);
        }

        // GET: Glosujący/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Glosujący glosujący = db.Glosujący.Find(id);
            if (glosujący == null)
            {
                return HttpNotFound();
            }
            return View(glosujący);
        }

        // POST: Glosujący/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Glosujący glosujący = db.Glosujący.Find(id);
            db.Glosujący.Remove(glosujący);
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
