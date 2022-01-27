using Centric.eCommerce.Search.Api.Models;

namespace Centric.eCommerce.Search.Api.Interfaces
{
    public interface IOrdersService
    {
        Task<(bool IsSuccess, IEnumerable<Order> Orders, string ErrorMessage)> GetOrdersAsync(Guid customerId);
    }
}
