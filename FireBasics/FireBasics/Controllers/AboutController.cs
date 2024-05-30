using Microsoft.AspNetCore.Mvc;

namespace FireBasics.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
