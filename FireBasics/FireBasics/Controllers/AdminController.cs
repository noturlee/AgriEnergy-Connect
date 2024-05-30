using Microsoft.AspNetCore.Mvc;

namespace FireBasics.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
