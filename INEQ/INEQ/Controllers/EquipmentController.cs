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

    public class EquipmentController : Controller
    {
       
        INEQContext dc = new INEQContext();

        //READ ALL
        public ActionResult List()
        {
            return View(dc.Equipments.ToList());
        }
        //READ SINGLE
        public ActionResult Details(int id = 0)
        {
            return View(dc.Equipments.Find(id));
        }

        //CREATE
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(Equipment eq)
        {
            using (dc)
            {
                dc.Equipments.Add(eq);
                dc.SaveChanges();
            }
            return RedirectToAction("List");
        }

        //UPDATE
        public ActionResult Edit(int id = 0)
        {
            return View(dc.Equipments.Find(id));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Equipment eq)
        {
            dc.Entry(eq).State = EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("List");
        }

        //DELETE
        public ActionResult Delete(int id = 0)
        {
            return View(dc.ComponentTypes.Find(id));
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult delete_conf(int id)
        {
            Equipment eq = dc.Equipments.Find(id);
            dc.Equipments.Remove(eq);
            dc.SaveChanges();
            return RedirectToAction("List");
        }
    }
}