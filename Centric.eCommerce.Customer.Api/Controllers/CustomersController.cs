using Centric.eCommerce.Customer.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Centric.eCommerce.Customer.Api.Controllers;

[Route("api/v1/customers")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomersProvider provider;

    public CustomersController(ICustomersProvider provider)
    {
        this.provider = provider;
    }

    [HttpGet]
    public async Task<IActionResult> GetProductsAsync()
    {
        var customers = await provider.GetCustomersAsync();
        return customers.IsSuccess ? Ok(customers.Customers) : NotFound(customers.ErrorMessage);
    }

    [HttpGet("{customerId}")]
    public async Task<IActionResult> GetProductAsync(Guid customerId)
    {
        var customer = await provider.GetCustomerAsync(customerId);
        return customer.IsSuccess ? Ok(customer.Customer) : NotFound(customer.ErrorMessage);
    } 
}
