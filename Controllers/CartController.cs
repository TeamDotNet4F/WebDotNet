using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers 
{
    public class CartController : Controller
    {
        public ActionResult Cart()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}