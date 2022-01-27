using Centric.eCommerce.Product.Api.Models;

namespace Centric.eCommerce.Product.Api.Interfaces
{
    public interface IProductProvider
    {
        Task<(bool IsSuccess, IEnumerable<ProductModel> Products, string ErrorMessage)> GetProductsAsync();
        Task<(bool IsSuccess, ProductModel Product, string ErrorMessage)> GetProductAsync(Guid id);
    }
}
