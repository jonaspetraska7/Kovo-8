#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kovo8.Models;

namespace Kovo8.Controllers
{
    public class TulpeModelsController : Controller
    {
        private readonly MainDbContext _context;

        public TulpeModelsController(MainDbContext context)
        {
            _context = context;
        }

        // GET: TulpeModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tulpes.ToListAsync());
        }

        // GET: TulpeModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tulpeModel = await _context.Tulpes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tulpeModel == null)
            {
                return NotFound();
            }

            return View(tulpeModel);
        }

        public async Task<IActionResult> JonoTulpe()
        {
            var tulpeModel = await _context.Tulpes
                .FirstOrDefaultAsync(m => m.Id == 1);
            if (tulpeModel == null)
            {
                return NotFound();
            }

            return View(tulpeModel);
        }
        public async Task<IActionResult> EvaldoTulpe()
        {
            var tulpeModel = await _context.Tulpes
                .FirstOrDefaultAsync(m => m.Id == 5);
            if (tulpeModel == null)
            {
                return NotFound();
            }

            return View(tulpeModel);
        }

        public async Task<IActionResult> PauliausTulpe()
        {
            var tulpeModel = await _context.Tulpes
                .FirstOrDefaultAsync(m => m.Id == 3);
            if (tulpeModel == null)
            {
                return NotFound();
            }

            return View(tulpeModel);
        }
        public async Task<IActionResult> ZydriusTulpe()
        {
            var tulpeModel = await _context.Tulpes
                .FirstOrDefaultAsync(m => m.Id == 6);
            if (tulpeModel == null)
            {
                return NotFound();
            }

            return View(tulpeModel);
        }

        public async Task<IActionResult> GermantoTulpe()
        {
            var tulpeModel = await _context.Tulpes
                .FirstOrDefaultAsync(m => m.Id == 2);
            if (tulpeModel == null)
            {
                return NotFound();
            }

            return View(tulpeModel);
        }
        public async Task<IActionResult> ArnoTulpe()
        {
            var tulpeModel = await _context.Tulpes
                .FirstOrDefaultAsync(m => m.Id == 4);
            if (tulpeModel == null)
            {
                return NotFound();
            }

            return View(tulpeModel);
        }

        // GET: TulpeModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TulpeModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Vardas,Gele,Balsai")] TulpeModel tulpeModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tulpeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tulpeModel);
        }

        // GET: TulpeModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tulpeModel = await _context.Tulpes.FindAsync(id);
            if (tulpeModel == null)
            {
                return NotFound();
            }
            return View(tulpeModel);
        }

        // POST: TulpeModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Vardas,Gele,Balsai")] TulpeModel tulpeModel)
        {
            if (id != tulpeModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tulpeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TulpeModelExists(tulpeModel.Id))
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
            return View(tulpeModel);
        }

        // GET: TulpeModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tulpeModel = await _context.Tulpes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tulpeModel == null)
            {
                return NotFound();
            }

            return View(tulpeModel);
        }

        // POST: TulpeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tulpeModel = await _context.Tulpes.FindAsync(id);
            _context.Tulpes.Remove(tulpeModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TulpeModelExists(int id)
        {
            return _context.Tulpes.Any(e => e.Id == id);
        }
    }
}
