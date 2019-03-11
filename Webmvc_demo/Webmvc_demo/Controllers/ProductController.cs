using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmvc_demo.Models;
using System.Data.Entity;

namespace Webmvc_demo.Controllers
{
    public class ProductController : Controller
    {
        ProductDbContext1 db = new ProductDbContext1();
        // GET: Product
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product pro)
        {
            if (ModelState.IsValid)
            {
                var x1 = Request["productName"];
                var x2 = Request.QueryString["productName"];
                var x3 = Request.Form["productName"];
                var x4 = Request.Params["productName"];
                db.Products.Add(pro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Create2()
        {
            return View();
        }
        [HttpPost]
        //[ActionName("Create3")]
        public ActionResult Create2(FormCollection fields)
        {
            if (ModelState.IsValid)
            {
                var x1 = fields["productID"];
                var x2 = fields["productName"];

                var x3 = Request.Form["productID"];
                var x4 = Request.Form["productName"];
                return RedirectToAction("Index");
            }
            
            return View();
        }
        public ActionResult Details(int? id)
        {
            
            return View(db.Products.Find(id));
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.Products.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(Product pro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(db.Products.Find(id));
        }
        
        public ActionResult DeleteConfirm(int? id)
        {
            Product pro = db.Products.Find(id);
            if (ModelState.IsValid)
            {
                db.Products.Remove(pro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
