using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcValidationExamples.Models;

namespace MvcValidationExamples.Controllers
{ 
    public class PersonController : Controller
    {
        private ValDataContext db = new ValDataContext();

        //
        // GET: /Person/

        public ViewResult Index()
        {
            return View(db.People.ToList());
        }

        //
        // GET: /Person/Details/5

        public ViewResult Details(int id)
        {
            Person person = db.People.Find(id);
            return View(person);
        }

        //
        // GET: /Person/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Person/Create

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(person);
        }
        
        //
        // GET: /Person/Edit/5
 
        public ActionResult Edit(int id)
        {
            Person person = db.People.Find(id);
            return View(person);
        }

        //
        // POST: /Person/Edit/5

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        //
        // GET: /Person/Delete/5
 
        public ActionResult Delete(int id)
        {
            Person person = db.People.Find(id);
            return View(person);
        }

        public ActionResult Example()
        {
            return View();
        }

        public ActionResult Loader()
        {
            return PartialView();
        }

        //
        // POST: /Person/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Person person = db.People.Find(id);
            db.People.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SampleJsonResponse()
        {
            int mynumber = 7689;
            return Json(mynumber, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}