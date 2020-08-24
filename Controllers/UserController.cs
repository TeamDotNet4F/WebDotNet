using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjectCore.Models;
using ProjectCore.Models.DAO;

namespace ProjectCore.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = UserDAO.checkUser(model.taikhoan, model.matkhau);
                if (result)
                {

                }
                
            }
            return View(model);
        }
        public IActionResult Login(LoginModel model)
        {
            return View();
        }
    }
}