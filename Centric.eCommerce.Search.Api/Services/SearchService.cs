using Centric.eCommerce.Search.Api.Interfaces;

namespace Centric.eCommerce.Search.Api.Services
{
    public class SearchService : ISearchService
    {
        private readonly IProductsService productsService;
        private readonly IOrdersService ordersService;
        private readonly ICustomersService customersService;

        public SearchService(IProductsService productsService, IOrdersService ordersService, ICustomersService customersService)
        {
            this.productsService = productsService;
            this.ordersService = ordersService;
            this.customersService = customersService;
        }

        public async Task<(bool IsSuccess, dynamic SearchResult)> SearchAsync(Guid customerId)
        {
            var customerResult = await customersService.GetCustomerAsync(customerId);
            var ordersResult = await ordersService.GetOrdersAsync(customerId);
            var productsResult = await productsService.GetProductsAsync();
            if (ordersResult.IsSuccess)
            {
                foreach (var order in ordersResult.Orders)
                {
                    foreach (var item in order.Items)
                    {
                        item.ProductName = productsResult.Products.FirstOrDefault(p => p.Id == item.ProductId)?.Name;
                    }
                }
                var result = new
                {
                    Customer = customerResult.Customer,
                    Orders = ordersResult.Orders
                };
                return (true, result);
            }


            return (true, null);
        }
    }
}
