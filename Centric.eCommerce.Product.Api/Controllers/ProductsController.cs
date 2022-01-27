using Centric.eCommerce.Product.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Centric.eCommerce.Product.Api.Controllers;

[Route("api/v1/products")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductsProvider provider;

    public ProductsController(IProductsProvider provider)
    {
        this.provider = provider;
    }

    [HttpGet]
    public async Task<IActionResult> GetProductsAsync()
    {
        var products = await provider.GetProductsAsync();
        return products.IsSuccess ? Ok(products.Products) : NotFound(products.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductAsync(Guid id)
    {
        var product = await provider.GetProductAsync(id);
        return product.IsSuccess ? Ok(product.Product) : NotFound(product.ErrorMessage);
    } 
}
