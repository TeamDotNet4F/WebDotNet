using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class RegularController : Controller
    {
        public ActionResult Regular()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}