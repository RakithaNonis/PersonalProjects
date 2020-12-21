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
    public class SymptomController : Controller
    {
        private DataEntities db = new DataEntities();

        // GET: Symptom
        public ActionResult Index()
        {
            SymptomModel symptomModel = new SymptomModel();
            using (DataEntities Db = new DataEntities())
            {
                symptomModel.symptomslist = Db.Symptoms.ToList<Symptom>();

            }
            return View(symptomModel);
            //  return View(db.Symptoms.ToList());

        }
        [HttpPost]
        public ActionResult Index(SymptomModel symptomModel, GuestSymptom guestSymptom)
        {
            
            string q = Request.QueryString["id_"];
           
            Checkin checkin = new Checkin();
            checkin.CheckinId = Convert.ToInt32(q);
            List<Symptom> selectedsyms = new List<Symptom>();

            for (int i = 0; i < symptomModel.symptomslist.Count; i++)
            {
                if (symptomModel.symptomslist[i].IsCheked)
                {
                    selectedsyms.Add(symptomModel.symptomslist[i]);
                }
            }
            foreach (var item in selectedsyms)
            {
                guestSymptom.SymptomId = item.SymptomId;
                guestSymptom.CheckinId = checkin.CheckinId;
                db.GuestSymptoms.Add(guestSymptom);
                db.SaveChanges();
            }


            TempData["check"] = checkin.CheckinId;
            return RedirectToAction("Index", "Temperature");
        }

        public ActionResult tablesymptom()
        {
            SymptomModel symptomModel = new SymptomModel();
            using (DataEntities Db = new DataEntities())
            {
                symptomModel.symptomslist = Db.Symptoms.ToList<Symptom>();

            }
            return View(symptomModel);
        }
        [HttpPost]
        public ActionResult tablesymptom(SymptomModel symptomModel, GuestSymptom guestSymptom)
        {
            string q = Request.QueryString["id_"];
            Checkin checkin = new Checkin();
            checkin.CheckinId = Convert.ToInt32(q);
            List<Symptom> selectedsyms = new List<Symptom>();

            for (int i = 0; i < symptomModel.symptomslist.Count; i++)
            {
                if (symptomModel.symptomslist[i].IsCheked)
                {
                    selectedsyms.Add(symptomModel.symptomslist[i]);
                }
            }
            foreach (var item in selectedsyms)
            {
                guestSymptom.SymptomId = item.SymptomId;
                guestSymptom.CheckinId = checkin.CheckinId;
                db.GuestSymptoms.Add(guestSymptom);
                db.SaveChanges();
            }
            TempData["check1"] = checkin.CheckinId;
            return RedirectToAction("Indexexist", "Temperature");
        }
        public ActionResult existsymptoms()
        {
            SymptomModel symptomModel = new SymptomModel();
            using (DataEntities Db = new DataEntities())
            {
                symptomModel.symptomslist = Db.Symptoms.ToList<Symptom>();

            }
            return View(symptomModel);
        }
        [HttpPost]
        public ActionResult existsymptoms(SymptomModel symptomModel, GuestSymptom guestSymptom)
        {

            string q = Request.QueryString["Id_"];
            Checkin checkin = new Checkin();
            checkin.PhoneNumber = (string)TempData["Phone"];
            checkin.CheckinId = Convert.ToInt32(q);

            List<Symptom> selectedsyms = new List<Symptom>();

            for (int i = 0; i < symptomModel.symptomslist.Count; i++)
            {
                if (symptomModel.symptomslist[i].IsCheked)
                {
                    selectedsyms.Add(symptomModel.symptomslist[i]);
                }
            }
            foreach (var item in selectedsyms)
            {
                guestSymptom.SymptomId = item.SymptomId;
                guestSymptom.CheckinId = checkin.CheckinId;
                db.GuestSymptoms.Add(guestSymptom);
                db.SaveChanges();
            }
            TempData["Ephn"] = checkin.CheckinId;
            return RedirectToAction("Exist", "Guest", new { id = checkin.PhoneNumber });
        }

















        public ActionResult samesymptoms()
        {
            SymptomModel symptomModel = new SymptomModel();
            using (DataEntities Db = new DataEntities())
            {
                symptomModel.symptomslist = Db.Symptoms.ToList<Symptom>();

            }
            return View(symptomModel);
        }











        [HttpPost]
        public ActionResult samesymptoms(SymptomModel symptomModel, GuestSymptom guestSymptom)
        {

            string q = Request.QueryString["Id_"];
            Checkin checkin = new Checkin();
            checkin.PhoneNumber = (string)TempData["Phone"];
            checkin.CheckinId = Convert.ToInt32(q);
            List<Symptom> selectedsyms = new List<Symptom>();

            for (int i = 0; i < symptomModel.symptomslist.Count; i++)
            {
                if (symptomModel.symptomslist[i].IsCheked)
                {
                    selectedsyms.Add(symptomModel.symptomslist[i]);
                }
            }
            foreach (var item in selectedsyms)
            {
                guestSymptom.SymptomId = item.SymptomId;
                guestSymptom.CheckinId = checkin.CheckinId;
                db.GuestSymptoms.Add(guestSymptom);
                db.SaveChanges();
            }
            TempData["Tphn"] = checkin.CheckinId;
            return RedirectToAction("Detailsexist", "Guest", new { ID = checkin.PhoneNumber });
        }

























        // GET: Symptom/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Symptom symptom = db.Symptoms.Find(id);
            if (symptom == null)
            {
                return HttpNotFound();
            }
            return View(symptom);
        }
        // GET: Symptom/Create
        public ActionResult Create()
        {

            ViewBag.SymptomId = new SelectList(db.Symptoms, "SymptomId", "SymptomName");
            return View();
        }

        // POST: Symptom/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SymptomId,SymptomName")] Symptom symptom)
        {
            if (ModelState.IsValid)
            {
                db.Symptoms.Add(symptom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(symptom);
        }
        // GET: Symptom/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Symptom symptom = db.Symptoms.Find(id);
            if (symptom == null)
            {
                return HttpNotFound();
            }
            return View(symptom);
        }

        // POST: Symptom/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SymptomId,SymptomName")] Symptom symptom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(symptom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(symptom);
        }


        // GET: Symptom/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Symptom symptom = db.Symptoms.Find(id);
            if (symptom == null)
            {
                return HttpNotFound();
            }
            return View(symptom);
        }

        // POST: Symptom/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Symptom symptom = db.Symptoms.Find(id);
            db.Symptoms.Remove(symptom);
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
