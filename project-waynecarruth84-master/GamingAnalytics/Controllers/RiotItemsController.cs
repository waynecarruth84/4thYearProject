using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GamingAnalytics.Models;

namespace GamingAnalytics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiotItemsController : ControllerBase
    {
        private readonly RiotApiContext _context;

        public RiotItemsController(RiotApiContext context)
        {
            _context = context;
        }

        // GET: api/RiotItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RiotItem>>> GetTodoItems()
        {
            return await _context.TodoItems.ToListAsync();
        }

        // GET: api/RiotItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RiotItem>> GetRiotItem(string name)
        {
            var riotItem = await _context.TodoItems.FindAsync(name);

            if (riotItem == null)
            {
                return NotFound();
            }

            return riotItem;
        }

        // PUT: api/RiotItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{name}")]
        public async Task<IActionResult> PutRiotItem(string name, RiotItem riotItem)
        {
            if (name != riotItem.Name)
            {
                return BadRequest();
            }

            _context.Entry(riotItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RiotItemExists(name))
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

        // POST: api/RiotItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RiotItem>> PostRiotItem(RiotItem riotItem)
        {
            _context.TodoItems.Add(riotItem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RiotItemExists(riotItem.Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(nameof(GetRiotItem), new { name = riotItem.Name }, riotItem);
        }

        // DELETE: api/RiotItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RiotItem>> DeleteRiotItem(string name)
        {
            var riotItem = await _context.TodoItems.FindAsync(name);
            if (riotItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(riotItem);
            await _context.SaveChangesAsync();

            return riotItem;
        }

        private bool RiotItemExists(string name)
        {
            return _context.TodoItems.Any(e => e.Name == name);
        }
    }
}
