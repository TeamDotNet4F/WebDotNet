using Project.Models.DBConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class ShopController : Controller
    {
        public ActionResult Shop()
        {
            ViewBag.Message = "Your contact page.";
            

            return View();
        }
    }
}