using AutoMapper;
using Centric.eCommerce.Product.Api.DB;
using Centric.eCommerce.Product.Api.Interfaces;
using Centric.eCommerce.Product.Api.Models;

namespace Centric.eCommerce.Product.Api.Profiles
{
    public class ProductsProvider : IProductProvider
    {
        private readonly ProductDbContext context;
        private readonly ILogger<ProductsProvider> logger;
        private readonly IMapper mapper;

        public ProductsProvider(ProductDbContext context, ILogger<ProductsProvider> logger, IMapper mapper)
        {
            this.context = context;
            this.logger = logger;
            this.mapper = mapper;
        }

        public Task<(bool IsSuccess, ProductModel Product, string ErrorMessage)> GetProductAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<(bool IsSuccess, IEnumerable<ProductModel> Products, string ErrorMessage)> GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
