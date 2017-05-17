using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    public class GoogleAccountController : Controller
    {
        // GET: GoogleAccount
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password, string returnUrl)
        {
            if (username.EndsWith("@google.com") && password == "secret")
            {
                FormsAuthentication.
            }
        }
    }
}