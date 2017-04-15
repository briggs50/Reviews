using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace briggs_Reviews.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("AccessDenied");
        }

        public ActionResult AccessDenied()
        {
            return View();
        }
    }
}