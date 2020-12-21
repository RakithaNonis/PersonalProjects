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
    public class CheckinController : Controller
    {
        private DataEntities db = new DataEntities();

        // GET: Checkin
        public ActionResult Index()
        {
            var checkins = db.Checkins.Include(c => c.Entrance).Include(c => c.Guest).Include(c => c.Hotel);
            return View(checkins.ToList());
        }

        // GET: Checkin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Checkin checkin = db.Checkins.Find(id);
            if (checkin == null)
            {
                return HttpNotFound();
            }
            return View(checkin);
        }













        // GET: Checkin/Create
        public ActionResult Create()
        {
            //ViewBag.EntranceId = new SelectList(db.Entrances, "EntranceId", "EntranceName");

            //ViewBag.HotelCode = new SelectList(db.Hotels, "HotelCode", "HotelName");
            return View();
        }







        // POST: Checkin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CheckinId,CheckinDate,HotelCode,PhoneNumber,EntranceId")] Checkin checkin)
        {
            if (ModelState.IsValid)
            {
                checkin.PhoneNumber = (string)TempData["PhoneNumber"];
                checkin.EntranceId = (int)TempData["EntranceId"];
                checkin.HotelCode = (string)TempData["HotelCode"];
                // checkin.GuestSymptoms
                db.Checkins.Add(checkin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.EntranceId = new SelectList(db.Entrances, "EntranceId", "EntranceName", checkin.EntranceId);

            //ViewBag.HotelCode = new SelectList(db.Hotels, "HotelCode", "HotelName", checkin.HotelCode);
            return View(checkin);
        }

        // GET: Checkin/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Checkin checkin = db.Checkins.Find(id);
            if (checkin == null)
            {
                return HttpNotFound();
            }
            ViewBag.EntranceId = new SelectList(db.Entrances, "EntranceId", "EntranceName", checkin.EntranceId);
            ViewBag.PhoneNumber = new SelectList(db.Guests, "PhoneNumber", "Name", checkin.PhoneNumber);
            ViewBag.HotelCode = new SelectList(db.Hotels, "HotelCode", "HotelName", checkin.HotelCode);
            return View(checkin);
        }

        // POST: Checkin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CheckinId,CheckinDate,HotelCode,PhoneNumber,EntranceId")] Checkin checkin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(checkin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EntranceId = new SelectList(db.Entrances, "EntranceId", "EntranceName", checkin.EntranceId);
            ViewBag.PhoneNumber = new SelectList(db.Guests, "PhoneNumber", "Name", checkin.PhoneNumber);
            ViewBag.HotelCode = new SelectList(db.Hotels, "HotelCode", "HotelName", checkin.HotelCode);
            return View(checkin);
        }

        // GET: Checkin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Checkin checkin = db.Checkins.Find(id);
            if (checkin == null)
            {
                return HttpNotFound();
            }
            return View(checkin);
        }

        // POST: Checkin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Checkin checkin = db.Checkins.Find(id);
            db.Checkins.Remove(checkin);
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
