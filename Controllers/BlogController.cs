using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Blog()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}