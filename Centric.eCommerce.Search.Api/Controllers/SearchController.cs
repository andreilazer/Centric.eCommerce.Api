using Centric.eCommerce.Search.Api.Interfaces;
using Centric.eCommerce.Search.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Centric.eCommerce.Search.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService service;

        public SearchController(ISearchService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> SearchAsync([FromBody] SearchTerm term)
        {
            var result = await service.SearchAsync(term.CustomerId);
            if (result.IsSuccess)
            {
                return Ok(result.SearchResult);
            }
            return NotFound();
        }
    }
}
