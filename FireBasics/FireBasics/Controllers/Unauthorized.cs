using Microsoft.AspNetCore.Mvc;

namespace FireBasics.Controllers
{
    public class Unauthorized : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
