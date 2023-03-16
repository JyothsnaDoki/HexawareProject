using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodManageCodeFirst.Models;

namespace FoodManageCodeFirst.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{v:apiVersion}/project")]
    public class CustomerCartsController : ControllerBase
    {
        private readonly FoodManagementContext _context;

        public CustomerCartsController(FoodManagementContext context)
        {
            _context = context;
        }

        // GET: api/CustomerCarts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerCart>>> GetCustomerCart()
        {
            return await _context.CustomerCart.ToListAsync();
        }

        // GET: api/CustomerCarts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerCart>> GetCustomerCart(int id)
        {
            var customerCart = await _context.CustomerCart.FindAsync(id);

            if (customerCart == null)
            {
                return NotFound();
            }

            return customerCart;
        }

        // PUT: api/CustomerCarts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerCart(int id, CustomerCart customerCart)
        {
            if (id != customerCart.CId)
            {
                return BadRequest();
            }

            _context.Entry(customerCart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerCartExists(id))
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

        // POST: api/CustomerCarts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CustomerCart>> PostCustomerCart(CustomerCart customerCart)
        {
            _context.CustomerCart.Add(customerCart);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerCart", new { id = customerCart.CId }, customerCart);
        }

        // DELETE: api/CustomerCarts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CustomerCart>> DeleteCustomerCart(int id)
        {
            var customerCart = await _context.CustomerCart.FindAsync(id);
            if (customerCart == null)
            {
                return NotFound();
            }

            _context.CustomerCart.Remove(customerCart);
            await _context.SaveChangesAsync();

            return customerCart;
        }

        private bool CustomerCartExists(int id)
        {
            return _context.CustomerCart.Any(e => e.CId == id);
        }
    }
}
