﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Schaefer4200.DAL;
using Schaefer4200.Models;

namespace Schaefer4200.Controllers
{
    public class CourseDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: CourseDetails
        public ActionResult Index()
        {
            var courseDetails = db.CourseDetails.Include(c => c.Course).Include(c => c.Student);
            return View(courseDetails.ToList());
        }

        // GET: CourseDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseDetail courseDetail = db.CourseDetails.Find(id);
            if (courseDetail == null)
            {
                return HttpNotFound();
            }
            return View(courseDetail);
        }

        // GET: CourseDetails/Create
        public ActionResult Create()
        {
            ViewBag.courseID = new SelectList(db.Courses, "courseID", "courseName");
            ViewBag.studentID = new SelectList(db.Students, "studentID", "firstName");
            return View();
        }

        // POST: CourseDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "coursedetailID,startDate,endDate,location,courseID,studentID")] CourseDetail courseDetail)
        {
            if (ModelState.IsValid)
            {
                db.CourseDetails.Add(courseDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.courseID = new SelectList(db.Courses, "courseID", "courseName", courseDetail.courseID);
            ViewBag.studentID = new SelectList(db.Students, "studentID", "firstName", courseDetail.studentID);
            return View(courseDetail);
        }

        // GET: CourseDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseDetail courseDetail = db.CourseDetails.Find(id);
            if (courseDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.courseID = new SelectList(db.Courses, "courseID", "courseName", courseDetail.courseID);
            ViewBag.studentID = new SelectList(db.Students, "studentID", "firstName", courseDetail.studentID);
            return View(courseDetail);
        }

        // POST: CourseDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "coursedetailID,startDate,endDate,location,courseID,studentID")] CourseDetail courseDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.courseID = new SelectList(db.Courses, "courseID", "courseName", courseDetail.courseID);
            ViewBag.studentID = new SelectList(db.Students, "studentID", "firstName", courseDetail.studentID);
            return View(courseDetail);
        }

        // GET: CourseDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseDetail courseDetail = db.CourseDetails.Find(id);
            if (courseDetail == null)
            {
                return HttpNotFound();
            }
            return View(courseDetail);
        }

        // POST: CourseDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseDetail courseDetail = db.CourseDetails.Find(id);
            db.CourseDetails.Remove(courseDetail);
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
