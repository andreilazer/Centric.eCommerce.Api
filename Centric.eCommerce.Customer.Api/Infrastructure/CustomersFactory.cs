using Centric.eCommerce.Customer.Api.DB;

namespace Centric.eCommerce.Customer.Api.Infrastructure
{
    public static class CustomersFactory
    {
        public static CustomersDbContext SeedCustomers(this CustomersDbContext context)
        {
            if (!context.Customers.Any())
            {
                context.Customers.Add(new DB.Customer
                {
                    Id = new Guid("2b8357de-27f7-4412-a786-57062d8888f7"),
                    Name = "Ion",
                    Address = "Iasi"
                });
                context.Customers.Add(new DB.Customer
                {
                    Id = new Guid("2b8357de-27f7-4412-a786-57062d8888f6"),
                    Name = "Vasile",
                    Address = "București"
                });
                context.Customers.Add(new DB.Customer
                {
                    Id = new Guid("2b8357de-27f7-4412-a786-57062d8888f5"),
                    Name = "Cornelia",
                    Address = "Vaslui"
                });
                context.Customers.Add(new DB.Customer
                {
                    Id = new Guid("2b8357de-27f7-4412-a786-57062d8888f4"),
                    Name = "Maria",
                    Address = "Suceava"
                });
                context.SaveChanges();
            }
            return context;
        }
    }
}
