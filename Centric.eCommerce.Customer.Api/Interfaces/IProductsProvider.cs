using Centric.eCommerce.Customer.Api.Models;

namespace Centric.eCommerce.Customer.Api.Interfaces
{
    public interface ICustomersProvider
    {
        Task<(bool IsSuccess, IEnumerable<CustomerModel> Customers, string ErrorMessage)> GetCustomersAsync();
        Task<(bool IsSuccess, CustomerModel Customer, string ErrorMessage)> GetProductAsync(Guid id);
    }
}
