using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FixSystem.Models;

namespace FixSystem.Controllers
{
    public class FixTestsController : Controller
    {
        private FixSystemContext db = new FixSystemContext();

        // GET: FixTests
        public ActionResult Index()
        {
            return View(db.FixTests.ToList());
        }

        // GET: FixTests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FixTest fixTest = db.FixTests.Find(id);
            if (fixTest == null)
            {
                return HttpNotFound();
            }
            return View(fixTest);
        }

        // GET: FixTests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FixTests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Building,Floor,Room,Details")] FixTest fixTest)
        {
            if (ModelState.IsValid)
            {
                db.FixTests.Add(fixTest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fixTest);
        }

        // GET: FixTests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FixTest fixTest = db.FixTests.Find(id);
            if (fixTest == null)
            {
                return HttpNotFound();
            }
            return View(fixTest);
        }

        // POST: FixTests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Building,Floor,Room,Details")] FixTest fixTest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fixTest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fixTest);
        }

        // GET: FixTests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FixTest fixTest = db.FixTests.Find(id);
            if (fixTest == null)
            {
                return HttpNotFound();
            }
            return View(fixTest);
        }

        // POST: FixTests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FixTest fixTest = db.FixTests.Find(id);
            db.FixTests.Remove(fixTest);
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
