namespace Centric.eCommerce.Search.Api.Interfaces
{
    public interface ICustomersService
    {
        Task<(bool IsSuccess, dynamic? Customer, string? ErrorMessage)> GetCustomerAsync(Guid customerId);
    }
}
