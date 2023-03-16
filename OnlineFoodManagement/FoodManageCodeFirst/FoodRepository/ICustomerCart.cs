using FoodManageCodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodManageCodeFirst.FoodRepository
{
    public interface ICustomerCart
    {
        Task<ActionResult<IEnumerable<CustomerCart>>> GetCustomerCart();
       Task<ActionResult<CustomerCart>> GetCustomerCart(int id);
        Task<IActionResult> PutCustomerCart(int id, CustomerCart customerCart);
      Task<ActionResult<CustomerCart>> PostCustomerCart(CustomerCart customerCart);
        Task<ActionResult<CustomerCart>> DeleteCustomerCart(int id);
    }
}
