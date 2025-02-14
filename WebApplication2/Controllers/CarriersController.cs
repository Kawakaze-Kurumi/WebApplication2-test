using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CarriersController : Controller
    {
        private readonly Test1Context _context;

        public CarriersController(Test1Context context)
        {
            _context = context;
        }

        // GET: Carriers
        public async Task<IActionResult> Index()
        {
            var test1Context = _context.Carriers.Include(c => c.Com);
            return View(await test1Context.ToListAsync());
        }

        // GET: Carriers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrier = await _context.Carriers
                .Include(c => c.Com)
                .FirstOrDefaultAsync(m => m.Code == id);
            if (carrier == null)
            {
                return NotFound();
            }

            return View(carrier);
        }

        // GET: Carriers/Create
        public IActionResult Create()
        {
            ViewData["ComId"] = new SelectList(_context.TblComs, "ComId", "ComId");
            return View();
        }

        // POST: Carriers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,CarrierName,CarrierNamekd,CarierAdd,BankAccountF,BankAccountC,Note,ComId")] Carrier carrier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carrier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ComId"] = new SelectList(_context.TblComs, "ComId", "ComId", carrier.ComId);
            return View(carrier);
        }

        // GET: Carriers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrier = await _context.Carriers.FindAsync(id);
            if (carrier == null)
            {
                return NotFound();
            }
            ViewData["ComId"] = new SelectList(_context.TblComs, "ComId", "ComId", carrier.ComId);
            return View(carrier);
        }

        // POST: Carriers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Code,CarrierName,CarrierNamekd,CarierAdd,BankAccountF,BankAccountC,Note,ComId")] Carrier carrier)
        {
            if (id != carrier.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carrier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarrierExists(carrier.Code))
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
            ViewData["ComId"] = new SelectList(_context.TblComs, "ComId", "ComId", carrier.ComId);
            return View(carrier);
        }

        // GET: Carriers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrier = await _context.Carriers
                .Include(c => c.Com)
                .FirstOrDefaultAsync(m => m.Code == id);
            if (carrier == null)
            {
                return NotFound();
            }

            return View(carrier);
        }

        // POST: Carriers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var carrier = await _context.Carriers.FindAsync(id);
            if (carrier != null)
            {
                _context.Carriers.Remove(carrier);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarrierExists(string id)
        {
            return _context.Carriers.Any(e => e.Code == id);
        }
    }
}
