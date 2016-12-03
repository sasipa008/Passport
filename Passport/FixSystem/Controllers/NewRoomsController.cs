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
    public class NewRoomsController : Controller
    {
        private FixSystemContext db = new FixSystemContext();

        // GET: NewRooms
        public ActionResult Index()
        {
            return View(db.NewRooms.ToList());
        }

        // GET: NewRooms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewRoom newRoom = db.NewRooms.Find(id);
            if (newRoom == null)
            {
                return HttpNotFound();
            }
            return View(newRoom);
        }

        // GET: NewRooms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewRooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,room,NameBuild,Floor")] NewRoom newRoom)
        {
            if (ModelState.IsValid)
            {
                db.NewRooms.Add(newRoom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newRoom);
        }

        // GET: NewRooms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewRoom newRoom = db.NewRooms.Find(id);
            if (newRoom == null)
            {
                return HttpNotFound();
            }
            return View(newRoom);
        }

        // POST: NewRooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,room,NameBuild,Floor")] NewRoom newRoom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newRoom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newRoom);
        }

        // GET: NewRooms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewRoom newRoom = db.NewRooms.Find(id);
            if (newRoom == null)
            {
                return HttpNotFound();
            }
            return View(newRoom);
        }

        // POST: NewRooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewRoom newRoom = db.NewRooms.Find(id);
            db.NewRooms.Remove(newRoom);
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
