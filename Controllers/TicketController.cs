using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CorePdf.Models;

namespace CorePdf.Controllers
{
    public class TicketController : Controller
    {
        private readonly TicketContext _context;

        public TicketController(TicketContext context)
        {
            _context = context;
        }

        // GET: Ticket
        public async Task<IActionResult> Index()
        {
            return View(await _context.TicketDB.ToListAsync());
        }

        // GET: Ticket/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketModel = await _context.TicketDB
                .FirstOrDefaultAsync(m => m.GUID == id);
            if (ticketModel == null)
            {
                return NotFound();
            }

            return View(ticketModel);
        }

        // GET: Ticket/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ticket/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GUID,Name,LastName,SeatNo,Email")] TicketModel ticketModel)
        {
            if (ModelState.IsValid)
            {
                ticketModel.GUID = Guid.NewGuid();
                _context.Add(ticketModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ticketModel);
        }

        // GET: Ticket/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketModel = await _context.TicketDB.FindAsync(id);
            if (ticketModel == null)
            {
                return NotFound();
            }
            return View(ticketModel);
        }

        // POST: Ticket/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("GUID,Name,LastName,SeatNo,Email")] TicketModel ticketModel)
        {
            if (id != ticketModel.GUID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticketModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketModelExists(ticketModel.GUID))
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
            return View(ticketModel);
        }

        public async Task<IActionResult> GetPDF(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketModel = await _context.TicketDB
                .FirstOrDefaultAsync(m => m.GUID == id);
            if (ticketModel == null)
            {
                return NotFound();
            }

            return View(ticketModel);
        }


        // GET: Ticket/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketModel = await _context.TicketDB
                .FirstOrDefaultAsync(m => m.GUID == id);
            if (ticketModel == null)
            {
                return NotFound();
            }

            return View(ticketModel);
        }




        // POST: Ticket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var ticketModel = await _context.TicketDB.FindAsync(id);
            _context.TicketDB.Remove(ticketModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketModelExists(Guid id)
        {
            return _context.TicketDB.Any(e => e.GUID == id);
        }
    }
}
