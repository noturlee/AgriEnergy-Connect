using Microsoft.AspNetCore.Mvc;

namespace FireBasics.Controllers
{
    public class CheckOutController : Controller
    {
        public IActionResult Pay()
        {
            return View();
        }
    }
}
