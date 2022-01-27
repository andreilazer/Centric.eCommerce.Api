using Microsoft.EntityFrameworkCore;

namespace Centric.eCommerce.Product.Api.DB
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
