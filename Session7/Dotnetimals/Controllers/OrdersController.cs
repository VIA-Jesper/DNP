using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dotnetimals.Data;
using Dotnetimals.Entities;

// Update-database


namespace Dotnetimals.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly CatContext _context;

        public OrdersController(CatContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            // https://docs.microsoft.com/en-us/ef/core/querying/related-data

            
            return await _context.Orders
                .Include(x => x.Cats)
                .ThenInclude(row => row.Cat)
                .ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {

            var orderIncludingItems = _context.Orders
                .Include(order => order.Cats)
                .ThenInclude(row => row.Cat)
                .First(ordr => ordr.Id == id);


            var order = await _context.Orders.Where(ord => ord.Cats.Any(j => j.OrderId == id)).FirstAsync();

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
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

        // POST: api/Orders
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            /* Json could look like this:
                {
                  "orderDate": "2020-04-13T10:09:57.7254985",
                  "orderNumber": null,
                  "cats": [
                    {
                      "catId": 1,
                      "cat": null,
                    },
                    {
                      "catId": 2,
                      "cat": null,
                    }
                  ]
                }
            */ // note for some reason REST Client to firefox has to be switched to JSON before custom for it to work. lol....

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();


            return CreatedAtAction("GetOrder", new { id = order.Id }, order); // this will not include the cats them selves
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return order;
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}
