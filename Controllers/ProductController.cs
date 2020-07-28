using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Product()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}