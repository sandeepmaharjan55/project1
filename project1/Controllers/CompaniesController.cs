﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using System.IO;
using project1.Models;

namespace Project1.Controllers
{
    [Authorize(Roles ="Admin")]
    public class CompaniesController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: Companies
        public ActionResult Index(string q, string order)
        {
            var name = from n in db.Companies select n;
            if (q != null)
            {
                name = name.Where(n => n.Name.Contains(q));
            }
            switch (order)
            {
                case "name":
                    name = name.OrderBy(n => n.Name);
                    break;
                case "Email":
                    name = name.OrderBy(n => n.Email);
                    break;
                default:
                    name = name.OrderBy(n => n.CompanyId);
                    break;
            }
            return View(name.ToList());
        }

        // GET: Companies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // GET: Companies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Company model, HttpPostedFileBase image)
        {
            try
            {
                // TODO: Add insert logic here
                model.Logo = "/images/" + image.FileName;
                string fullpath = Server.MapPath("~/images/");//for full path
                image.SaveAs(fullpath + image.FileName);//savin in db

                db.Companies.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
        }

        // GET: Companies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Company model, HttpPostedFileBase image)
        {
            try
            {
                // TODO: Add update logic here
                if (image != null)
                {





                    var oldimg = model.Logo;
                    model.Logo = "/images/" + image.FileName;
                    string fullpath = Server.MapPath("~/images/");//for full path
                    image.SaveAs(fullpath + image.FileName);//savin in db
                                                            //delete before save
                    if (System.IO.File.Exists(fullpath + oldimg))
                    {
                        System.IO.File.Delete(fullpath + oldimg);
                    }
                }

                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");


            }
            catch
            {
                return View();
            }
        }

        // GET: Companies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Company company = db.Companies.Find(id);
            db.Companies.Remove(company);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ReqLFA(int id)
        {

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
