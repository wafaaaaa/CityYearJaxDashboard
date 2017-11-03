using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DCPSRevenueManagement.Models;

namespace DCPSRevenueManagement.Controllers
{
    public class DCPSRevenueTablesController : Controller
    {
        private DCPSRevenueManagementEntities db = new DCPSRevenueManagementEntities();

        // GET: DCPSRevenueTables
        public ActionResult Index()
        {
            return View(db.DCPSRevenueTables.ToList());
        }

        // GET: DCPSRevenueTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DCPSRevenueTable dCPSRevenueTable = db.DCPSRevenueTables.Find(id);
            if (dCPSRevenueTable == null)
            {
                return HttpNotFound();
            }
            return View(dCPSRevenueTable);
        }

        // GET: DCPSRevenueTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DCPSRevenueTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Quarter1,Quarter2,Quarter3,Quarter4,Quarter5")] DCPSRevenueTable dCPSRevenueTable)
        {
            if (ModelState.IsValid)
            {
                db.DCPSRevenueTables.Add(dCPSRevenueTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dCPSRevenueTable);
        }

        // GET: DCPSRevenueTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DCPSRevenueTable dCPSRevenueTable = db.DCPSRevenueTables.Find(id);
            if (dCPSRevenueTable == null)
            {
                return HttpNotFound();
            }
            return View(dCPSRevenueTable);
        }

        // POST: DCPSRevenueTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Quarter1,Quarter2,Quarter3,Quarter4,Quarter5")] DCPSRevenueTable dCPSRevenueTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dCPSRevenueTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dCPSRevenueTable);
        }

        // GET: DCPSRevenueTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DCPSRevenueTable dCPSRevenueTable = db.DCPSRevenueTables.Find(id);
            if (dCPSRevenueTable == null)
            {
                return HttpNotFound();
            }
            return View(dCPSRevenueTable);
        }

        // POST: DCPSRevenueTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DCPSRevenueTable dCPSRevenueTable = db.DCPSRevenueTables.Find(id);
            db.DCPSRevenueTables.Remove(dCPSRevenueTable);
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
