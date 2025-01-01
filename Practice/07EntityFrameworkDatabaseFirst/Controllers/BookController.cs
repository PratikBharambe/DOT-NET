using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _07EntityFrameworkDatabaseFirst.Models;

namespace _07EntityFrameworkDatabaseFirst.Controllers
{
    public class BookController : Controller
    {
        private readonly TestContext _context;

        public BookController(TestContext context)
        {
            _context = context;
        }

        // GET: Book
        public async Task<IActionResult> Index()
        {
              return _context.AudioBooks != null ? 
                          View(await _context.AudioBooks.ToListAsync()) :
                          Problem("Entity set 'TestContext.AudioBooks'  is null.");
        }

        // GET: Book/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AudioBooks == null)
            {
                return NotFound();
            }

            var audioBook = await _context.AudioBooks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (audioBook == null)
            {
                return NotFound();
            }

            return View(audioBook);
        }

        // GET: Book/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Author,Narrator")] AudioBook audioBook)
        {
            if (ModelState.IsValid)
            {
                _context.Add(audioBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(audioBook);
        }

        // GET: Book/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AudioBooks == null)
            {
                return NotFound();
            }

            var audioBook = await _context.AudioBooks.FindAsync(id);
            if (audioBook == null)
            {
                return NotFound();
            }
            return View(audioBook);
        }

        // POST: Book/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Author,Narrator")] AudioBook audioBook)
        {
            if (id != audioBook.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(audioBook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AudioBookExists(audioBook.Id))
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
            return View(audioBook);
        }

        // GET: Book/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AudioBooks == null)
            {
                return NotFound();
            }

            var audioBook = await _context.AudioBooks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (audioBook == null)
            {
                return NotFound();
            }

            return View(audioBook);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AudioBooks == null)
            {
                return Problem("Entity set 'TestContext.AudioBooks'  is null.");
            }
            var audioBook = await _context.AudioBooks.FindAsync(id);
            if (audioBook != null)
            {
                _context.AudioBooks.Remove(audioBook);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AudioBookExists(int id)
        {
          return (_context.AudioBooks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
