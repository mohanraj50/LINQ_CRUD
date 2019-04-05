using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace linqcrud.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        trainningsessionEntities db = new trainningsessionEntities();
        public ActionResult Index()
        {
           // using (var db=new trainningsessionEntities())
            //{ 
            var empdata = from emp in db.employees select emp;
            return View(empdata);
           // return View();
           // }
        }
        public ActionResult Details(int id)
        {
         //   using (var db = new trainningsessionEntities())
           // {
                //Lambda Expression
                var empdetails = db.employees.Single(x => x.empid == id);

                return View(empdetails);
            //}
        }

        //
        // GET: /Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employee/Create
        [HttpPost]
        public ActionResult Create(employee collection)
        {
            try
            {
              //  using (var db = new trainningsessionEntities())
              //  {
                    // TODO: Add insert logic here
                    db.employees.Add(collection);
                    db.SaveChanges();
                    return RedirectToAction("Index");
              //  }
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Edit/5
        public ActionResult Edit(int id)
        {
           // using (var db = new trainningsessionEntities())
            //{
                var empdetails = db.employees.Single(x => x.empid == id);

                return View(empdetails);
            //}
        }

        //
        // POST: /Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, employee collection)
        {
            try
            {
               // using (var db = new trainningsessionEntities())
               // {
                    // TODO: Add update logic here
                    employee emp = db.employees.Single(x => x.empid == id);
                    emp.empid = collection.empid;
                    emp.empname = collection.empname;
                    emp.designation = collection.designation;
                    db.SaveChanges();
                    return RedirectToAction("Index");
              //  }
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Delete/5
        public ActionResult Delete(int id)
        {
           // using (var db = new trainningsessionEntities())
           // {
                var empdetails = db.employees.Single(x => x.empid == id);

                return View(empdetails);
           // }
        }

        //
        // POST: /Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
             //   using (var db = new trainningsessionEntities())
               // {
                    // TODO: Add delete logic here
                    var empdetails = db.employees.Single(x => x.empid == id);
                    db.employees.Remove(empdetails);
                    db.SaveChanges();
                    return RedirectToAction("Index");
              //  }
            }
            catch
            {
                return View();
            }
        }
    }
}