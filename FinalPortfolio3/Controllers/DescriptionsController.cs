using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalPortfolio3.Models;

namespace FinalPortfolio3.Controllers
{
    public class DescriptionsController : Controller
    {
        private FinalPortfolio2Entities db = new FinalPortfolio2Entities();

        // GET: Descriptions
        public ActionResult Index()
        {
            var descriptions = db.Descriptions.Include(d => d.Screenshot);
            return View(descriptions.ToList());
        }

        // GET: Descriptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Description description = db.Descriptions.Find(id);
            if (description == null)
            {
                return HttpNotFound();
            }
            return View(description);
        }

        // GET: Descriptions/Create
        public ActionResult Create()
        {
            ViewBag.ScreenshotID = new SelectList(db.Screenshots, "ScreenshotID", "Screenshot1");
            return View();
        }

        // POST: Descriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ScreenshotID,ProjectDescriptionID,ProjectDescription")] Description description)
        {
            if (ModelState.IsValid)
            {
                db.Descriptions.Add(description);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ScreenshotID = new SelectList(db.Screenshots, "ScreenshotID", "Screenshot1", description.ScreenshotID);
            return View(description);
        }

        // GET: Descriptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Description description = db.Descriptions.Find(id);
            if (description == null)
            {
                return HttpNotFound();
            }
            ViewBag.ScreenshotID = new SelectList(db.Screenshots, "ScreenshotID", "Screenshot1", description.ScreenshotID);
            return View(description);
        }

        // POST: Descriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ScreenshotID,ProjectDescriptionID,ProjectDescription")] Description description)
        {
            if (ModelState.IsValid)
            {
                db.Entry(description).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ScreenshotID = new SelectList(db.Screenshots, "ScreenshotID", "Screenshot1", description.ScreenshotID);
            return View(description);
        }

        // GET: Descriptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Description description = db.Descriptions.Find(id);
            if (description == null)
            {
                return HttpNotFound();
            }
            return View(description);
        }

        // POST: Descriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Description description = db.Descriptions.Find(id);
            db.Descriptions.Remove(description);
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
