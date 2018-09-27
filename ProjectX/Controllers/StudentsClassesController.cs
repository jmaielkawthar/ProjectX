using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectX.Models;

namespace ProjectX.Controllers
{
    public class StudentsClassesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StudentsClasses
        public ActionResult Index()
        {
            var studentsClasses = db.StudentsClasses.Include(s => s.student);
            return View(studentsClasses.ToList());
        }

        // GET: StudentsClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentsClasses studentsClasses = db.StudentsClasses.Find(id);
            if (studentsClasses == null)
            {
                return HttpNotFound();
            }
            return View(studentsClasses);
        }

        // GET: StudentsClasses/Create
        public ActionResult Create()
        {
            ViewBag.StudentID = new SelectList(db.Students, "ID", "name");
            ViewBag.ClassID = new SelectList(db.Classes, "ID", "Classestring");
            return View();
        }

        // POST: StudentsClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,ClassID")] StudentsClasses studentsClasses)
        {
            if (ModelState.IsValid)
            {
                db.StudentsClasses.Add(studentsClasses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentID = new SelectList(db.Students, "ID", "name", studentsClasses.StudentID);
            return View(studentsClasses);
        }

        // GET: StudentsClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentsClasses studentsClasses = db.StudentsClasses.Find(id);
            if (studentsClasses == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentID = new SelectList(db.Students, "ID", "name", studentsClasses.StudentID);
            return View(studentsClasses);
        }

        // POST: StudentsClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentID,ClassID")] StudentsClasses studentsClasses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentsClasses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentID = new SelectList(db.Students, "ID", "name", studentsClasses.StudentID);
            return View(studentsClasses);
        }

        // GET: StudentsClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentsClasses studentsClasses = db.StudentsClasses.Find(id);
            if (studentsClasses == null)
            {
                return HttpNotFound();
            }
            return View(studentsClasses);
        }

        // POST: StudentsClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentsClasses studentsClasses = db.StudentsClasses.Find(id);
            db.StudentsClasses.Remove(studentsClasses);
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
