using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webproje.Models;

namespace webproje.Controllers
{
    public class adminController : Controller
    {
        private ProductDBContext db = new ProductDBContext();

        [Authorize(Users = "admin")]
        // GET: admin
        public ActionResult Index()
        {
            return View(db.Purchases.ToList());
        }
    }
}