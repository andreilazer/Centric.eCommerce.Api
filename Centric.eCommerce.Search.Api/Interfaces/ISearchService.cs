namespace Centric.eCommerce.Search.Api.Interfaces
{
    public interface ISearchService
    {
        Task<(bool IsSuccess, dynamic SearchResult)> SearchAsync(Guid customerId);
    }
}
