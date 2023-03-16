using FoodManageCodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodManageCodeFirst.FoodRepository
{
    public class CustomerCartRepo:ICustomerCart
    {
        private readonly FoodManagementContext _context;

        public CustomerCartRepo(FoodManagementContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<CustomerCart>>> GetCustomerCart()
        {
            return await _context.CustomerCart.ToListAsync();
        }

        public async Task<ActionResult<CustomerCart>> GetCustomerCart(int id)
        {
            var customerCart = await _context.CustomerCart.FindAsync(id);
            
            //if (customerCart == null)
            //{
            //    return NotFound();
            //}

            return customerCart;
        }
        public async Task<IActionResult> PutCustomerCart(int id, CustomerCart customerCart)
        {
            //if (id != customerCart.CId)
            //{
            //    return BadRequest();
            //}

            _context.Entry(customerCart).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return (IActionResult)customerCart;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    IActionResult NotFound()
            //    {
            //        throw new NotImplementedException();
            //    }
            //    if (!CustomerCartExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return NoContent();
        }

       

       
        public async Task<ActionResult<CustomerCart>> PostCustomerCart(CustomerCart customerCart)
        {
            _context.CustomerCart.Add(customerCart);
            await _context.SaveChangesAsync();
            return customerCart;

            //return CreatedAtAction("GetCustomerCart", new { id = customerCart.CId }, customerCart);
        }

       
        public async Task<ActionResult<CustomerCart>> DeleteCustomerCart(int id)
        {
            var customerCart = await _context.CustomerCart.FindAsync(id);
            
            //if (customerCart == null)
            //{
            //    return NotFound();
            //}

            _context.CustomerCart.Remove(customerCart);
            await _context.SaveChangesAsync();

            return customerCart;
        }
    }
}
