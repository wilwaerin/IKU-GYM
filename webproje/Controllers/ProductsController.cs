using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webproje.Models;

namespace webproje.Controllers
{
    public class ProductsController : Controller
    {
        private ProductDBContext db = new ProductDBContext();

        
       [Authorize]
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        [Authorize]
        // GET: Products/Purchase/5
        public ActionResult Purchase(int? id)
        {
            ModelState.Clear();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            Purchases purs = new Purchases { NameSurname = null, Mail = null, Gender = null };
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(purs);
        }


        [Authorize]
        // POST: Products/Purchase/MakePurchase
        [HttpPost]
        public ActionResult MakePurchase(string nameSurname, string mail, string gender) {

            var pur = new Purchases {
                NameSurname = nameSurname,
                Mail = mail,
                Gender = gender,
                PurchaseDate = DateTime.Now
            };
            db.Purchases.Add(pur);
            
            db.SaveChanges();

            ModelState.Clear();

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
