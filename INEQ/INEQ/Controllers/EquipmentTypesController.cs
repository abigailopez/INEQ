using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using INEQ.DAL;
using INEQ.Models;

namespace INEQ.Controllers
{
    public class EquipmentTypesController : Controller
    {
        private INEQContext db = new INEQContext();

        // GET: EquipmentTypes
        public ActionResult Index()
        {
            return View(db.EquipmentTypes.ToList());
        }

        // GET: EquipmentTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentType equipmentType = db.EquipmentTypes.Find(id);
            if (equipmentType == null)
            {
                return HttpNotFound();
            }
            return View(equipmentType);
        }

        // GET: EquipmentTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipmentTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Description,UsefulLife,GuaranteeDuration,Active")] EquipmentType equipmentType)
        {
            if (ModelState.IsValid)
            {
                db.EquipmentTypes.Add(equipmentType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipmentType);
        }

        // GET: EquipmentTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentType equipmentType = db.EquipmentTypes.Find(id);
            if (equipmentType == null)
            {
                return HttpNotFound();
            }
            return View(equipmentType);
        }

        // POST: EquipmentTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Description,UsefulLife,GuaranteeDuration,Active")] EquipmentType equipmentType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipmentType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipmentType);
        }

        // GET: EquipmentTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentType equipmentType = db.EquipmentTypes.Find(id);
            if (equipmentType == null)
            {
                return HttpNotFound();
            }
            return View(equipmentType);
        }

        // POST: EquipmentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EquipmentType equipmentType = db.EquipmentTypes.Find(id);
            db.EquipmentTypes.Remove(equipmentType);
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
