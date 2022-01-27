using Centric.eCommerce.Product.Api.DB;

namespace Centric.eCommerce.Product.Api.Infrastructure
{
    public static class ProductsFactory
    {
        public static ProductsDbContext SeedProducts(this ProductsDbContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.Add(new DB.Product
                {
                    Id = new Guid("d09aff24-d1ea-44aa-b47c-dfa6cb08a04d"),
                    Name = "Keyboard",
                    Price = 20,
                    Inventory = 100
                });
                context.Products.Add(new DB.Product
                {
                    Id = new Guid("f81b7509-c67d-44d7-af6e-ced23d48eb05"),
                    Name = "Mouse",
                    Price = 10,
                    Inventory = 200
                });
                context.Products.Add(new DB.Product
                {
                    Id = new Guid("98cee8ac-ff75-4e6e-bff2-d801ac968c32"),
                    Name = "Monitor",
                    Price = 159,
                    Inventory = 20
                });
                context.Products.Add(new DB.Product
                {
                    Id = new Guid("06e2a0e4-55b5-4ec9-9c6f-731abda77c1b"),
                    Name = "CPU",
                    Price = 220,
                    Inventory = 20
                });
                context.SaveChanges();
            }
            return context;
        }
    }
}
