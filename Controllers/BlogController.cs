using Project.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class BlogController : Controller
    {
        project_dotnetEntities db = new project_dotnetEntities();
        public ActionResult Blog()
        {
            
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}