using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using demo.Models;

namespace demo.Controllers
{
    public class TemperatureController : Controller
    {
        private DataEntities db = new DataEntities();

        // GET: Temperature
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Index(Temperature temperature )
        {

            
            temperature.TemperatureValue = temperature.IsCheked;
              temperature.CheckinId =(int) TempData["check"];
            
            db.Temperatures.Add(temperature);
            db.SaveChanges();
            //return Content("IsFemale: " + temperature.IsCheked);
            return RedirectToAction("Index","Guest");
        }
        public ActionResult Indexexist()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Indexexist(Temperature temperature)
        {
            temperature.TemperatureValue = temperature.IsCheked;
            temperature.TableNumber = temperature.IsSelected;
              temperature.CheckinId =(int) TempData["check1"];
           
            db.Temperatures.Add(temperature);
            db.SaveChanges();
            //return Content("IsFemale: " + temperature.IsCheked);
            return RedirectToAction("Index", "Guest");
        
        }


        public ActionResult dataexist()
        {
            return View();
        }


        [HttpPost]
        public ActionResult dataexist(Temperature temperature)
        {
            temperature.TemperatureValue = temperature.IsCheked;
            temperature.TableNumber = temperature.IsSelected;
            temperature.CheckinId = (int)TempData["Tphn"];

            db.Temperatures.Add(temperature);
            db.SaveChanges();
            //return Content("IsFemale: " + temperature.IsCheked);
            return RedirectToAction("Index", "Guest");

        }








        public ActionResult data()
        {
            return View();
        }





        [HttpPost]
        public ActionResult data(Temperature temperature)
        {
            temperature.TemperatureValue = temperature.IsCheked;
          
            temperature.CheckinId = (int)TempData["Ephn"];

            db.Temperatures.Add(temperature);
            db.SaveChanges();
            //return Content("IsFemale: " + temperature.IsCheked);
            return RedirectToAction("Index", "Guest");
          
        }



















        // GET: Temperature/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Temperature temperature = db.Temperatures.Find(id);
            if (temperature == null)
            {
                return HttpNotFound();
            }
            return View(temperature);
        }

        // GET: Temperature/Create
        public ActionResult Create()
        {
            ViewBag.CheckinId = new SelectList(db.Checkins, "CheckinId", "HotelCode");
            return View();
        }

        // POST: Temperature/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TemperatureId,TableNumber,TemperatureValue,CheckinId")] Temperature temperature)
        {
            if (ModelState.IsValid)
            {
                db.Temperatures.Add(temperature);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CheckinId = new SelectList(db.Checkins, "CheckinId", "HotelCode", temperature.CheckinId);
            return View(temperature);
        }

        // GET: Temperature/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Temperature temperature = db.Temperatures.Find(id);
            if (temperature == null)
            {
                return HttpNotFound();
            }
            ViewBag.CheckinId = new SelectList(db.Checkins, "CheckinId", "HotelCode", temperature.CheckinId);
            return View(temperature);
        }

        // POST: Temperature/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TemperatureId,TableNumber,TemperatureValue,CheckinId")] Temperature temperature)
        {
            if (ModelState.IsValid)
            {
                db.Entry(temperature).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CheckinId = new SelectList(db.Checkins, "CheckinId", "HotelCode", temperature.CheckinId);
            return View(temperature);
        }

        // GET: Temperature/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Temperature temperature = db.Temperatures.Find(id);
            if (temperature == null)
            {
                return HttpNotFound();
            }
            return View(temperature);
        }

        // POST: Temperature/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Temperature temperature = db.Temperatures.Find(id);
            db.Temperatures.Remove(temperature);
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
