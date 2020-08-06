using Project.Models.DAO;
using Project.Models.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class IndexController : Controller
    {
        project_dotnetEntities db = new project_dotnetEntities();
        public ActionResult Index()
        {
            var listSanPham = db.sanphams.AsParallel();
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}