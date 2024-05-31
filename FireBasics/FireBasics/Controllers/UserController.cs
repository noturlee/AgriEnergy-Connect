using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FireBasics.Models;

namespace FireBasics.Controllers
{
    public class UserController : Controller
    {
        private readonly AgrienergyContext _context;

        public UserController(AgrienergyContext context)
        {
            _context = context;
        }

        // GET: User/Index
        public async Task<IActionResult> Index()
        {
            var userRole = HttpContext.Session.GetString("Role");
            if (userRole == null)
            {
                return RedirectToAction("Index", "Unauthorized");

            }
            else
            {
                var users = await _context.Users.ToListAsync();
                return View(users);
            }
        }

        // GET: User/UserList
        public async Task<IActionResult> UserList()
        {
            var userRole = HttpContext.Session.GetString("Role");
            if (userRole.Equals("EMPLOYEE"))
            {
                var users = await _context.Users.ToListAsync();
                return View(users);
            }
            else
            {
                return RedirectToAction("Index", "Unauthorized");
            }
        }

        // POST: User/ChangeRole
        [HttpPost]
        public async Task<IActionResult> ChangeRole(int id, string role)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            user.Role = role;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(UserList));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
