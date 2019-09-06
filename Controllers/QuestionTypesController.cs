using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using testDemo.Data;
using testDemo.Models;

namespace testDemo.Controllers
{
    public class QuestionTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuestionTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: QuestionTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestionTypes.ToListAsync());
        }

        // GET: QuestionTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionTypes = await _context.QuestionTypes
                .FirstOrDefaultAsync(m => m.QuestionTypeId == id);
            if (questionTypes == null)
            {
                return NotFound();
            }

            return View(questionTypes);
        }

        // GET: QuestionTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuestionTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] QuestionType questionTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questionTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(questionTypes);
        }

        // GET: QuestionTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionTypes = await _context.QuestionTypes.FindAsync(id);
            if (questionTypes == null)
            {
                return NotFound();
            }
            return View(questionTypes);
        }

        // POST: QuestionTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] QuestionType questionTypes)
        {
            if (id != questionTypes.QuestionTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questionTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionTypesExists(questionTypes.QuestionTypeId))
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
            return View(questionTypes);
        }

        // GET: QuestionTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionTypes = await _context.QuestionTypes
                .FirstOrDefaultAsync(m => m.QuestionTypeId == id);
            if (questionTypes == null)
            {
                return NotFound();
            }

            return View(questionTypes);
        }

        // POST: QuestionTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questionTypes = await _context.QuestionTypes.FindAsync(id);
            _context.QuestionTypes.Remove(questionTypes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionTypesExists(int id)
        {
            return _context.QuestionTypes.Any(e => e.QuestionTypeId == id);
        }
    }
}
