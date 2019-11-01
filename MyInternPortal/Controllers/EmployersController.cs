﻿//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using MyInternPortal.Models;
//using MyInternPortal.Models.Classes;

//namespace MyInternPortal.Controllers
//{
//    public class EmployersController : Controller
//    {
//        private ApplicationDbContext db = new ApplicationDbContext();

//        // GET: Employers
//        public ActionResult Index()
//        {
//            return View(db.ApplicationUsers.ToList());
//        }

//        // GET: Employers/Details/5
//        //public ActionResult Details(string id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    Employer employer = db.ApplicationUsers;
//        //    if (employer == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    return View(employer);
//        //}

//        // GET: Employers/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Employers/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,UserName")] Employer employer)
//        {
//            if (ModelState.IsValid)
//            {
//                db.ApplicationUsers.Add(employer);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(employer);
//        }

//        // GET: Employers/Edit/5
//        public ActionResult Edit(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Employer employer = db.ApplicationUsers.Find(id);
//            if (employer == null)
//            {
//                return HttpNotFound();
//            }
//            return View(employer);
//        }

//        // POST: Employers/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,UserName")] Employer employer)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(employer).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(employer);
//        }

//        // GET: Employers/Delete/5
//        public ActionResult Delete(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Employer employer = db.ApplicationUsers.Find(id);
//            if (employer == null)
//            {
//                return HttpNotFound();
//            }
//            return View(employer);
//        }

//        // POST: Employers/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(string id)
//        {
//            Employer employer = db.ApplicationUsers.Find(id);
//            db.ApplicationUsers.Remove(employer);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
