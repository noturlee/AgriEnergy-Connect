using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FireBasics.Models;

namespace FireBasics.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var userRole = HttpContext.Session.GetString("Role");
            if (userRole == null)
            {
                return RedirectToAction("Index", "Unauthorized");
            }

            else if (userRole.Equals("EMPLOYEE"))
            {
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Unauthorized");

            }
        }
    }
}

