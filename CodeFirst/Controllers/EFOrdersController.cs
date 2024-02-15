using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
    public class EFOrdersController : Controller
    {
        private readonly AzureContext _context;

        public EFOrdersController(AzureContext context)
        {
            _context = context;
        }

        // GET: EFOrders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Order.ToListAsync());
        }

        // GET: EFOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eFOrder = await _context.Order
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (eFOrder == null)
            {
                return NotFound();
            }

            return View(eFOrder);
        }

        // GET: EFOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EFOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,CustomerID,EmpID,OrderDate")] EFOrder eFOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eFOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eFOrder);
        }

        // GET: EFOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eFOrder = await _context.Order.FindAsync(id);
            if (eFOrder == null)
            {
                return NotFound();
            }
            return View(eFOrder);
        }

        // POST: EFOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,CustomerID,EmpID,OrderDate")] EFOrder eFOrder)
        {
            if (id != eFOrder.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eFOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EFOrderExists(eFOrder.OrderId))
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
            return View(eFOrder);
        }

        // GET: EFOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eFOrder = await _context.Order
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (eFOrder == null)
            {
                return NotFound();
            }

            return View(eFOrder);
        }

        // POST: EFOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eFOrder = await _context.Order.FindAsync(id);
            if (eFOrder != null)
            {
                _context.Order.Remove(eFOrder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EFOrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderId == id);
        }
    }
}
