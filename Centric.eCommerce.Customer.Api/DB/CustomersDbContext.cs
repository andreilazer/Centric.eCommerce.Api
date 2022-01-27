using Microsoft.EntityFrameworkCore;

namespace Centric.eCommerce.Customer.Api.DB
{
    public class CustomersDbContext: DbContext
    {
        public CustomersDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
