using AutoMapper;
using Centric.eCommerce.Customer.Api.DB;
using Centric.eCommerce.Customer.Api.Infrastructure;
using Centric.eCommerce.Customer.Api.Interfaces;
using Centric.eCommerce.Customer.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Centric.eCommerce.Product.Api.Providers
{
    public class CustomersProvider : ICustomersProvider
    {
        private readonly CustomersDbContext context;
        private readonly ILogger<CustomersProvider> logger;
        private readonly IMapper mapper;

        public CustomersProvider(CustomersDbContext context, ILogger<CustomersProvider> logger, IMapper mapper)
        {
            this.context = context;
            this.logger = logger;
            this.mapper = mapper;
            context.SeedCustomers();
        }

        public async Task<(bool IsSuccess, CustomerModel Customer, string ErrorMessage)> GetCustomerAsync(Guid id)
        {
            try
            {
                var customer = await context.Customers.FirstOrDefaultAsync(p => p.Id == id);
                if(customer != null)
                {
                    var result = mapper.Map<CustomerModel>(customer);
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

        public async Task<(bool IsSuccess, IEnumerable<CustomerModel> Customers, string ErrorMessage)> GetCustomersAsync()
        {
            try
            {
                var customers = await context.Customers.ToListAsync();
                if(customers != null && customers.Any())
                {
                    var result = mapper.Map<IEnumerable<CustomerModel>>(customers);
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
    }
}
