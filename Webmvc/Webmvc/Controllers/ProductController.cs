using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmvc.Models;

namespace Webmvc.Controllers
{
    public class ProductController : Controller
    {
        ProductDbContext db = new ProductDbContext(); 
        // GET: Product
        public ActionResult Index()
        {

            var query = from p in db.Products
                        join c in db.CategoryOfProducts 
                        on p.CategoryOfProductID 
                        equals c.categoryOfProductID
                        select new ProductView(){
                                productID = p.productID,
                                producName = p.NameOfProduct,
                                    type = c.description
                               };
            return View(query.ToList());
        }
        public ActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(product);
        }
    }
}