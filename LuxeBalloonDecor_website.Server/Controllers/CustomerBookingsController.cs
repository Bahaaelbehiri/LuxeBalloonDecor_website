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
    public class CustomerBookingsController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public CustomerBookingsController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/CustomerBookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerBookings>>> GetCustomerBookings()
        {
            return await _context.CustomerBookings.ToListAsync();
        }

        // GET: api/CustomerBookings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerBookings>> GetCustomerBookings(int id)
        {
            var customerBookings = await _context.CustomerBookings.FindAsync(id);

            if (customerBookings == null)
            {
                return NotFound();
            }

            return customerBookings;
        }

        // PUT: api/CustomerBookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerBookings(int id, CustomerBookings customerBookings)
        {
            if (id != customerBookings.CustomerBookingID)
            {
                return BadRequest();
            }

            _context.Entry(customerBookings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerBookingsExists(id))
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

        // POST: api/CustomerBookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerBookings>> PostCustomerBookings(CustomerBookings customerBookings)
        {
            _context.CustomerBookings.Add(customerBookings);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerBookings", new { id = customerBookings.CustomerBookingID }, customerBookings);
        }

        // DELETE: api/CustomerBookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerBookings(int id)
        {
            var customerBookings = await _context.CustomerBookings.FindAsync(id);
            if (customerBookings == null)
            {
                return NotFound();
            }

            _context.CustomerBookings.Remove(customerBookings);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerBookingsExists(int id)
        {
            return _context.CustomerBookings.Any(e => e.CustomerBookingID == id);
        }
    }
}
