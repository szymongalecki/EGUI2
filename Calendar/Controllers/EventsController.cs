using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CalendarEGUIc1.Data;
using CalendarEGUIc1.Models;

namespace CalendarEGUIc1.Controllers
{
    public class EventsController : Controller
    {
        private readonly CalendarEGUIbContext _context;

        public EventsController(CalendarEGUIbContext context)
        {
            _context = context;
        }

        // GET: Events
        public async Task<IActionResult> Index(string date)
        { 
            
            var events = from e in _context.Event
                        select e;

            if (!String.IsNullOrEmpty(date))
            {
                DateTime d = DateTime.Parse(date);

                ViewData["Year"] = d.Year;
                ViewData["Month"] = d.Month;
                ViewData["Day"] = d.Day;
               
                events = events.Where(s => s.Date == d);
            }
            else
            {
                ViewData["Year"] = 0;
                ViewData["Month"] = 0;
                ViewData["Day"] = 0;
            }
            events = events.OrderBy(q => q.Date).ThenBy(a => a.Time.Hour).ThenBy(z => z.Time.Minute);

            return View(await events.ToListAsync());
            

            //return View(await _context.Event.ToListAsync());
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Events/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Time,Description")] Event @event)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                var date = @event.Date.Day + "/" + @event.Date.Month + "/" + @event.Date.Year;
                return RedirectToAction(nameof(Index), new { date }); 
            }
            return View(@event);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Time,Description")] Event @event)
        {
            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                var date = @event.Date.Day + "/" + @event.Date.Month + "/" + @event.Date.Year;
                return RedirectToAction(nameof(Index), new { date });
                //return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @event = await _context.Event.FindAsync(id);
            var date = @event.Date.Day + "/" + @event.Date.Month + "/" + @event.Date.Year;
            _context.Event.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { date });
        }

        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.Id == id);
        }
    }
}
