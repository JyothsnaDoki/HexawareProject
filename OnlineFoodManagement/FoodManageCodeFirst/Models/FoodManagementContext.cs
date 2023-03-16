using Microsoft.EntityFrameworkCore;

namespace FoodManageCodeFirst.Models
{
    public class FoodManagementContext : DbContext
    {
        public FoodManagementContext(DbContextOptions<FoodManagementContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<CustomerCart> CustomerCart { get; set; }

    }
}


