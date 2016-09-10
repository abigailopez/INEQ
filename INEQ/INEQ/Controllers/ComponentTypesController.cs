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
    public class ComponentTypesController : Controller
    {
        INEQContext dc = new INEQContext();

      //READ
        public ActionResult List()
        {
            return View(dc.ComponentTypes.ToList());
        }
        //READ SINGLE
        public ActionResult Details(int id = 0)
        {
            return View(dc.ComponentTypes.Find(id));
        }

        //CREATE
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(ComponentType ctp)
        {
            using (dc)
            {
                dc.ComponentTypes.Add(ctp);
                dc.SaveChanges();
            }
            return RedirectToAction("List");

        }

        //UPDATE
        public ActionResult Edit(int id = 0)
        {
            return View(dc.ComponentTypes.Find(id));
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Edit(ComponentType ctp)
        {
            dc.Entry(ctp).State = EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("List");
        }
    }
}