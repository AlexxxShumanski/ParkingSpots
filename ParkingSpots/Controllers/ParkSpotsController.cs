using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ParkingSpots.Data;

namespace ParkingSpots.Controllers
{
    public class ParkSpotsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParkSpotsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ParkSpots
        public async Task<IActionResult> Index()
        {
            return View(await _context.ParkSpots.ToListAsync());
        }

        // GET: ParkSpots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkSpot = await _context.ParkSpots
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkSpot == null)
            {
                return NotFound();
            }

            return View(parkSpot);
        }

        // GET: ParkSpots/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ParkSpots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Disabled,Category,Size,Status,Price,Registration,Date")] ParkSpot parkSpot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parkSpot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parkSpot);
        }

        // GET: ParkSpots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkSpot = await _context.ParkSpots.FindAsync(id);
            if (parkSpot == null)
            {
                return NotFound();
            }
            return View(parkSpot);
        }

        // POST: ParkSpots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Disabled,Category,Size,Status,Price,Registration,Date")] ParkSpot parkSpot)
        {
            if (id != parkSpot.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parkSpot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParkSpotExists(parkSpot.Id))
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
            return View(parkSpot);
        }

        // GET: ParkSpots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkSpot = await _context.ParkSpots
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkSpot == null)
            {
                return NotFound();
            }

            return View(parkSpot);
        }

        // POST: ParkSpots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parkSpot = await _context.ParkSpots.FindAsync(id);
            _context.ParkSpots.Remove(parkSpot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParkSpotExists(int id)
        {
            return _context.ParkSpots.Any(e => e.Id == id);
        }
    }
}
