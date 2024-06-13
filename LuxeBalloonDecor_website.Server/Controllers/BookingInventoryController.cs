using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LuxeBalloonDecor_website.Server.Data;
using LuxeBalloonDecor_website.Server.Models;

namespace LuxeBalloonDecor_website.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingInventoryController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public BookingInventoryController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/BookingInventories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingInventory>>> GetBookingInventory()
        {
            return await _context.BookingInventory.ToListAsync();
        }

        // GET: api/BookingInventories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingInventory>> GetBookingInventory(int id)
        {
            var bookingInventory = await _context.BookingInventory.FindAsync(id);

            if (bookingInventory == null)
            {
                return NotFound();
            }

            return bookingInventory;
        }

        // PUT: api/BookingInventories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookingInventory(int id, BookingInventory bookingInventory)
        {
            if (id != bookingInventory.bookingInventoryID)
            {
                return BadRequest();
            }

            _context.Entry(bookingInventory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingInventoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BookingInventories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookingInventory>> PostBookingInventory(BookingInventory bookingInventory)
        {
            _context.BookingInventory.Add(bookingInventory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookingInventory", new { id = bookingInventory.bookingInventoryID }, bookingInventory);
        }

        // DELETE: api/BookingInventories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingInventory(int id)
        {
            var bookingInventory = await _context.BookingInventory.FindAsync(id);
            if (bookingInventory == null)
            {
                return NotFound();
            }

            _context.BookingInventory.Remove(bookingInventory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookingInventoryExists(int id)
        {
            return _context.BookingInventory.Any(e => e.bookingInventoryID == id);
        }
    }
}
