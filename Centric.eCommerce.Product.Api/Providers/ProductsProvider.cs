using AutoMapper;
using Centric.eCommerce.Product.Api.DB;
using Centric.eCommerce.Product.Api.Infrastructure;
using Centric.eCommerce.Product.Api.Interfaces;
using Centric.eCommerce.Product.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Centric.eCommerce.Product.Api.Providers
{
    public class ProductsProvider : IProductsProvider
    {
        private readonly ProductsDbContext context;
        private readonly ILogger<ProductsProvider> logger;
        private readonly IMapper mapper;

        public ProductsProvider(ProductsDbContext context, ILogger<ProductsProvider> logger, IMapper mapper)
        {
            this.context = context;
            this.logger = logger;
            this.mapper = mapper;
            context.SeedProducts();
        }

        public async Task<(bool IsSuccess, ProductModel Product, string ErrorMessage)> GetProductAsync(Guid id)
        {
            try
            {
                var product = await context.Products.FirstOrDefaultAsync(p => p.Id == id);
                if(product != null)
                {
                    var result = mapper.Map<ProductModel>(product);
                    return (true, result, null);
                }
                return (false, null, "Not Found");
            }
            catch (Exception ex) 
            { 
                logger.LogError(ex.Message);
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, IEnumerable<ProductModel> Products, string ErrorMessage)> GetProductsAsync()
        {
            try
            {
                var products = await context.Products.ToListAsync();
                if(products != null && products.Any())
                {
                    var result = mapper.Map<IEnumerable<ProductModel>>(products);
                    return (true, result, null);
                }
                return (false, null, "Not Found");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
