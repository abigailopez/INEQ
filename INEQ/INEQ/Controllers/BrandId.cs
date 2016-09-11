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
    public class BrandId
    {
        // READ ALL
        public ActionResult List()
        {
            return View(dc.BrandsId.ToList());
        }
        //READ SINGLE
        public ActionResult Details(int id = 0)
        {
            return View(dc.BrandsId.Find(id));
        }
        //CREATE
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(BrandId br)
        {
            using (dc)
            {
                dc.Brands.Add(br);
                dc.SaveChanges();

            }
            return RedirectToAction("List");
        }
        //UPDATE
        public ActionResult Edit(int id = 0)
        {
            return View(dc.BrandsId.Find(id));
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(BrandId br)
        {
            dc.Entry(br).State = EntityState.Modified;
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
            BrandId br = dc.BrandIds.Find(id);
            dc.BrandId.Remove(eq);
            dc.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
}