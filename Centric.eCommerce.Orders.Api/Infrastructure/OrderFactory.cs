using Centric.eCommerce.Order.API.DB;

namespace Centric.eCommerce.Order.API.Infrastructure
{
    public static class OrderFactory
    {
        public static OrdersDbContext SeedOrders(this OrdersDbContext context)
        {
            if (!context.Orders.Any())
            {
                context.Orders.Add(new DB.Order()
                {
                    Id = new Guid("ed83a911-a078-4b5c-bda0-8a4e80f32b39"),
                    CustomerId = new Guid("2b8357de-27f7-4412-a786-57062d8888f7"),
                    OrderDate = DateTime.Now,
                    Items = new List<OrderItem>()
                    {
                        new OrderItem() { OrderId = new Guid("ed83a911-a078-4b5c-bda0-8a4e80f32b39"), ProductId = new Guid("d09aff24-d1ea-44aa-b47c-dfa6cb08a04d"), Quantity = 10, UnitPrice = 10 },
                        new OrderItem() { OrderId = new Guid("ed83a911-a078-4b5c-bda0-8a4e80f32b39"), ProductId = new Guid("f81b7509-c67d-44d7-af6e-ced23d48eb05"), Quantity = 10, UnitPrice = 10 },
                        new OrderItem() { OrderId = new Guid("ed83a911-a078-4b5c-bda0-8a4e80f32b39"), ProductId = new Guid("98cee8ac-ff75-4e6e-bff2-d801ac968c32"), Quantity = 10, UnitPrice = 10 },
                        new OrderItem() { OrderId = new Guid("4cb0c381-3f9d-460c-9796-2635c500eb46"), ProductId = new Guid("f81b7509-c67d-44d7-af6e-ced23d48eb05"), Quantity = 10, UnitPrice = 10 },
                        new OrderItem() { OrderId = new Guid("4cb0c381-3f9d-460c-9796-2635c500eb46"), ProductId = new Guid("98cee8ac-ff75-4e6e-bff2-d801ac968c32"), Quantity = 1, UnitPrice = 100 }
                    },
                    Total = 100
                });
                context.Orders.Add(new DB.Order()
                {
                    Id = new Guid("4cb0c381-3f9d-460c-9796-2635c500eb46"),
                    CustomerId = new Guid("2b8357de-27f7-4412-a786-57062d8888f6"),
                    OrderDate = DateTime.Now.AddDays(-1),
                    Items = new List<OrderItem>()
                    {
                        new OrderItem() { OrderId = new Guid("ed83a911-a078-4b5c-bda0-8a4e80f32b39"), ProductId = new Guid("06e2a0e4-55b5-4ec9-9c6f-731abda77c1b"), Quantity = 10, UnitPrice = 10 },
                        new OrderItem() { OrderId = new Guid("ed83a911-a078-4b5c-bda0-8a4e80f32b39"), ProductId = new Guid("f81b7509-c67d-44d7-af6e-ced23d48eb05"), Quantity = 10, UnitPrice = 10 },
                        new OrderItem() { OrderId = new Guid("ed83a911-a078-4b5c-bda0-8a4e80f32b39"), ProductId = new Guid("d09aff24-d1ea-44aa-b47c-dfa6cb08a04d"), Quantity = 10, UnitPrice = 10 },
                        new OrderItem() { OrderId = new Guid("4cb0c381-3f9d-460c-9796-2635c500eb46"), ProductId = new Guid("f81b7509-c67d-44d7-af6e-ced23d48eb05"), Quantity = 10, UnitPrice = 10 },
                        new OrderItem() { OrderId = new Guid("4cb0c381-3f9d-460c-9796-2635c500eb46"), ProductId = new Guid("d09aff24-d1ea-44aa-b47c-dfa6cb08a04d"), Quantity = 1, UnitPrice = 100 }
                    },
                    Total = 100
                });
                context.Orders.Add(new DB.Order()
                {
                    Id = new Guid("87c7c2b7-1279-42c8-9667-beb9e1c897e6"),
                    CustomerId = new Guid("2b8357de-27f7-4412-a786-57062d8888f5"),
                    OrderDate = DateTime.Now,
                    Items = new List<OrderItem>()
                    {
                        new OrderItem() {
                            OrderId =new Guid("ed83a911-a078-4b5c-bda0-8a4e80f32b39"), ProductId = new Guid("f81b7509-c67d-44d7-af6e-ced23d48eb05"), Quantity = 10, UnitPrice = 10 },
                        new OrderItem() { OrderId = new Guid("4cb0c381-3f9d-460c-9796-2635c500eb46"), ProductId = new Guid("98cee8ac-ff75-4e6e-bff2-d801ac968c32"), Quantity = 10, UnitPrice = 10 },
                        new OrderItem() { OrderId = new Guid("87c7c2b7-1279-42c8-9667-beb9e1c897e6"), ProductId = new Guid("06e2a0e4-55b5-4ec9-9c6f-731abda77c1b"), Quantity = 1, UnitPrice = 100 }
                    },
                    Total = 100
                });
                context.SaveChanges();
            }
            return context;
        }
    }
}
