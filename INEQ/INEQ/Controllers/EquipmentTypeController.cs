using INEQ.DAL;
using INEQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace INEQ.Controllers
{
    public class EquipmentTypeController : Controller
    {
        INEQContext dc = new INEQContext();

        // READ ALL
        public ActionResult List()
        {
            return View(dc.EquipmentTypes.ToList());
        }

        //READ BY ID
        public ActionResult Details(int id = 0)
        {
            return View(dc.EquipmentTypes.Find(id));
        }

        //CREATE
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(EquipmentType eqt)
        {
            using (dc)
            {
                dc.EquipmentTypes.Add(eqt);
                dc.SaveChanges();
            }
            return RedirectToAction("List");

        }

        //UPDATE
        public ActionResult Edit(int id = 0)
        {
            return View(dc.EquipmentTypes.Find(id));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(EquipmentType eqt)
        {
            dc.Entry(eqt).State = EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("List");
        }

        //DELETE
        public ActionResult Delete(int id = 0)
        {
            return View(dc.EquipmentTypes.Find(id));
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult delete_conf(int id)
        {
           EquipmentType eqt = dc.EquipmentTypes.Find(id);
            dc.EquipmentTypes.Remove(eqt);
            dc.SaveChanges();
            return RedirectToAction("List");
        }
    }
}