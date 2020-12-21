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
    public class GuestController : Controller
    {
        private DataEntities db = new DataEntities();

        // GET: Guest

        public ActionResult Report()
        {
            var guests = db.Guests.Include(g => g.Country).Include(g => g.Title).ToList();

            return View(guests);
        }
        public ActionResult Exist(string id)
        {

            Guest guest = db.Guests.Find(id);
            return View(guest);
        }
        public ActionResult Index()
        {
            ViewBag.EntranceId = new SelectList(db.Entrances, "EntranceId", "EntranceName");
            ViewBag.HotelCode = new SelectList(db.Hotels, "HotelCode", "HotelName");
            ViewBag.SymptomId = new SelectList(db.Symptoms, "SymptomId", "SymptomName");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ViewModel viewModel)
        {
            Checkin checkin = new Checkin();
           


                var isExists = db.Guests.Any(x => x.PhoneNumber == viewModel.guestList.PhoneNumber);
                if (isExists)
                {
                    TempData["Phone"] = viewModel.guestList.PhoneNumber;
                    TempData["Entrance"] = viewModel.checkinList.EntranceId;
                    checkin.PhoneNumber = viewModel.guestList.PhoneNumber;
                    checkin.EntranceId = viewModel.checkinList.EntranceId;
                    checkin.CheckinDate = viewModel.checkinList.CheckinDate;
                    checkin.HotelCode = viewModel.checkinList.HotelCode;
                    db.Checkins.Add(checkin);
                    db.SaveChanges();
                    if (checkin.EntranceId == 1)
                    {
                        return RedirectToAction("existsymptoms", "Symptom", new { Id_ = checkin.CheckinId });
                    }
                    else
                    {
                        return RedirectToAction("samesymptoms", "Symptom", new { Id_ = checkin.CheckinId });
                    }
                    //return RedirectToAction("Exist",new { id = viewModel.guestList.PhoneNumber  });
                }
                TempData["PhoneNumber"] = viewModel.guestList.PhoneNumber;
                TempData["EntranceId"] = viewModel.checkinList.EntranceId;
                TempData["HotelCode"] = viewModel.checkinList.HotelCode;
                TempData["CheckinDate"] = viewModel.checkinList.CheckinDate;
                return RedirectToAction("Create");
           
        }


        //Detailsexist

        // GET: Guest/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guest guest = db.Guests.Find(id);
            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }

        public ActionResult Detailsexist(string ID)
        {
            if (ID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guest guest = db.Guests.Find(ID);
            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }

        // GET: Guest/Create
        public ActionResult Create()
        {
            ViewBag.CountryCode = new SelectList(db.Countries, "CountryCode", "CountryName");
            ViewBag.TitleId = new SelectList(db.Titles, "TitleId", "TitleName");
            return View();
        }
        // POST: Guest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CheckinId,CheckinDate,HotelCode,PhoneNumber,EntranceId")] Checkin checkin, [Bind(Include = "PhoneNumber,Name,TitleId,CountryCode,RegistrationDate")] Guest guest)
        {
            checkin.EntranceId = (int)TempData["EntranceId"];

            //if (ModelState.IsValid)
            //{
                if (checkin.EntranceId == 1)
                {
                    guest.PhoneNumber = (string)TempData["PhoneNumber"];
                    db.Guests.Add(guest);
                    checkin.PhoneNumber = (string)TempData["PhoneNumber"];
                    checkin.HotelCode = (string)TempData["HotelCode"];
                    checkin.EntranceId = (int)TempData["EntranceId"];
                    checkin.CheckinDate = (DateTime)TempData["CheckinDate"];


                    db.Checkins.Add(checkin);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Symptom", new { id_ = checkin.CheckinId });
                }
                else

                guest.PhoneNumber = (string)TempData["PhoneNumber"];
                db.Guests.Add(guest);
                checkin.PhoneNumber = (string)TempData["PhoneNumber"];
                checkin.HotelCode = (string)TempData["HotelCode"];
                checkin.EntranceId = (int)TempData["EntranceId"];



                db.Checkins.Add(checkin);
                db.SaveChanges();
                return RedirectToAction("tablesymptom", "Symptom", new { id_ = checkin.CheckinId });


            //}

            //ViewBag.CountryCode = new SelectList(db.Countries, "CountryCode", "CountryName", guest.CountryCode);
            //ViewBag.TitleId = new SelectList(db.Titles, "TitleId", "TitleName", guest.TitleId);
            //return View(guest);
        }

        // GET: Guest/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guest guest = db.Guests.Find(id);
            if (guest == null)
            {
                return HttpNotFound();
            }
            ViewBag.CountryCode = new SelectList(db.Countries, "CountryCode", "CountryName", guest.CountryCode);
            ViewBag.TitleId = new SelectList(db.Titles, "TitleId", "TitleName", guest.TitleId);
            return View(guest);
        }
        // POST: Guest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PhoneNumber,Name,TitleId,CountryCode,RegistrationDate")] Guest guest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Guest");
            }
            ViewBag.CountryCode = new SelectList(db.Countries, "CountryCode", "CountryName", guest.CountryCode);
            ViewBag.TitleId = new SelectList(db.Titles, "TitleId", "TitleName", guest.TitleId);
            return View(guest);
        }

        // GET: Guest/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guest guest = db.Guests.Find(id);
            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }


        // POST: Guest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Guest guest = db.Guests.Find(id);
            db.Guests.Remove(guest);
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
