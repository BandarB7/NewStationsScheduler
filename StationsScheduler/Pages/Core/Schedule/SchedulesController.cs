using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StationsScheduler.Data;

namespace StationsScheduler.Pages.Core.Schedule
{
    [Produces("application/json")]
    [Route("api/Schedules")]
    public class SchedulesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SchedulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Schedules
        [HttpGet]
        public IEnumerable<ProductSchedule> GetProductSchedule()
        {
            return _context.ProductSchedule;
        }

        // GET: api/Schedules/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductSchedule([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productSchedule = await _context.ProductSchedule.SingleOrDefaultAsync(m => m.ProductScheduleID == id);

            if (productSchedule == null)
            {
                return NotFound();
            }

            return Ok(productSchedule);
        }



        // PUT: api/Schedules/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductSchedule([FromRoute] int id, [FromBody] ProductSchedule productSchedule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productSchedule.ProductScheduleID)
            {
                return BadRequest();
            }

            _context.Entry(productSchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductScheduleExists(id))
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

        // POST: api/Schedules
        [HttpPost]
        public async Task<IActionResult> PostProductSchedule([FromBody] ProductSchedule productSchedule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ProductSchedule.Add(productSchedule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductSchedule", new { id = productSchedule.ProductScheduleID }, productSchedule);
        }

        // DELETE: api/Schedules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductSchedule([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productSchedule = await _context.ProductSchedule.SingleOrDefaultAsync(m => m.ProductScheduleID == id);
            if (productSchedule == null)
            {
                return NotFound();
            }

            _context.ProductSchedule.Remove(productSchedule);
            await _context.SaveChangesAsync();

            return Ok(productSchedule);
        }

        private bool ProductScheduleExists(int id)
        {
            return _context.ProductSchedule.Any(e => e.ProductScheduleID == id);
        }
    }
}