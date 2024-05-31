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
    public class CategoryController : Controller
    {
        private readonly AgrienergyContext _context;

        public CategoryController(AgrienergyContext context)
        {
            _context = context;
        }

        // GET: Category
        public async Task<IActionResult> Index()
        {
            var userRole = HttpContext.Session.GetString("Role");
            if (userRole == null)
            {
                return RedirectToAction("Index", "Unauthorized");
            }
            else
            {
                return View(await _context.Categories.ToListAsync());
                
            }
        }

        // GET: Category/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var userRole = HttpContext.Session.GetString("Role");
            if (userRole == null)
            {
                return RedirectToAction("Index", "Unauthorized");

            }
            else
            {
                if (id == null)
                {
                    return RedirectToAction("Index", "Unauthorized");
                }

                var category = await _context.Categories.FirstOrDefaultAsync(m => m.CategoryId == id);
                if (category == null)
                {
                    return NotFound();
                }

                var productsInCategory = await _context.Products
                    .Include(p => p.Category)
                    .Include(p => p.Farmer)
                    .Where(p => p.CategoryId == id)
                    .ToListAsync();

                return View(productsInCategory);
            }
        }




            // GET: Category/Create
            public IActionResult Create()
        {
            var userRole = HttpContext.Session.GetString("Role");
            if (userRole.Equals("EMPLOYEE"))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Unauthorized");
            }
        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,CategoryName,ImageUrl")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Category/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var userRole = HttpContext.Session.GetString("Role");
            if (userRole.Equals("EMPLOYEE"))
            {
                if (id == null)
                {
                    return NotFound();
                }

                var category = await _context.Categories.FindAsync(id);
                if (category == null)
                {
                    return NotFound();
                }
                return View(category);
            }
            else
            {
                return RedirectToAction("Index", "Unauthorized");
            }
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryId,CategoryName,ImageUrl")] Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }



        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userRole = HttpContext.Session.GetString("Role");
            if (userRole.Equals("EMPLOYEE"))
            {
                var category = await _context.Categories.FindAsync(id);
                if (category != null)
                {
                    _context.Categories.Remove(category);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction("Index", "Unauthorized");
            }
        }


        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}
