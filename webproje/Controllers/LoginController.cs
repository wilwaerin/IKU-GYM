using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using webproje.Models;

namespace webproje.Controllers
{
    public class LoginController : Controller
    {
        private UsersDBDcontext db = new UsersDBDcontext();
        // GET: Index
        public ActionResult Index()
        {
         
            return View();
        }
        [HttpPost]
        public ActionResult Index(Users u) {
            var userExists = db.Users.FirstOrDefault(x => x.userName == u.userName && x.password == u.password);

            if(userExists != null) {
                FormsAuthentication.SetAuthCookie(u.userName, false);               

                return RedirectToAction("Index", "Home");
            } else {
                ViewBag.Message = "Invalid username or password.";
                return View();
            }
        }

        public ActionResult Logout() {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        

    }
}