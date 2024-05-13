using FireBasics.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FireBasics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Check if the session has a user token to determine if the user is logged in
            ViewBag.IsLoggedIn = !string.IsNullOrEmpty(HttpContext.Session.GetString("_UserToken"));
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}