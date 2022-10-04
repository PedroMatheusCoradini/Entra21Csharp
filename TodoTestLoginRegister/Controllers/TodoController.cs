using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TodoTestLoginRegister.Data;
using TodoTestLoginRegister.Models;
using Microsoft.AspNetCore.Identity;
using TodoTestLoginRegister.ViewModels;

namespace TodoTestLoginRegister.Controllers
{
    //[AllowAnonymous] permite que o metodo n precise de autorizacao
    [Authorize]
    public class TodoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TodoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Todo
        public async Task<IActionResult> Index()
        {
            return _context.Todos != null ?
                        View(await _context.Todos
                        .AsNoTracking()
                        .Where(x => x.User == User.Identity.Name)
                        .ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Todos'  is null.");
        }

        // GET: Todo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Todos == null)
            {
                return NotFound();
            }

            var todo = await _context.Todos.FirstOrDefaultAsync(m => m.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            if (todo.User != User.Identity.Name)
            {
                return NotFound();
            }

            return View(todo);
        }

        // GET: Todo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Todo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Done,CreateAt,LastUpdateDate,User")] UserViewModel todo) // 
        {
            Todo todo2 = new Todo
            {
                Id = todo.Id,
                Title = todo.Title,
                CreateAt = DateTime.Now
            };

            if (ModelState.IsValid)
            {
                todo2.User = User.Identity.Name;
                _context.Add(todo2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(todo2);
        }

        // GET: Todo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Todos == null)
            {
                return NotFound();
            }

            var todo = await _context.Todos.FindAsync(id);
            if (todo == null)
            {
                return NotFound();
            }

            if (todo.User != User.Identity.Name)
                return NotFound();

            return View(todo);
        }

        // POST: Todo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Done,CreateAt")] Todo todo) // ,CreateAt,LastUpdateDate,User
        {
            if (id != todo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var todos = await _context.Todos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == todo.Id);

                    todo.User = User.Identity.Name;
                    todo.CreateAt = todos.CreateAt;
                    _context.Update(todo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TodoExists(todo.Id))
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
            return View(todo);
        }

        // GET: Todo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Todos == null)
            {
                return NotFound();
            }

            var todo = await _context.Todos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            if (todo.User != User.Identity.Name)
                return NotFound();

            return View(todo);
        }

        // POST: Todo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Todos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Todos'  is null.");
            }
            var todo = await _context.Todos.FindAsync(id);
            if (todo != null)
            {
                _context.Todos.Remove(todo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TodoExists(int id)
        {
            return (_context.Todos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
