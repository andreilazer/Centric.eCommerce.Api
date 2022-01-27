using Centric.eCommerce.Search.Api.Models;

namespace Centric.eCommerce.Search.Api.Interfaces
{
    public interface IProductsService
    {
        Task<(bool IsSuccess, IEnumerable<Product> Products, string ErrorMessage)> GetProductsAsync();
        Task<(bool IsSuccess, Product Products, string ErrorMessage)> GetProductAsync(Guid productId);
    }
}
