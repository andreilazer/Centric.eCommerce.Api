using Centric.eCommerce.Customer.Api.Models;

namespace Centric.eCommerce.Customer.Api.Profiles
{
    public class CustomerProfile: AutoMapper.Profile
    {
        public CustomerProfile()
        {
            CreateMap<DB.Customer, CustomerModel>().ReverseMap();
        }
    }
}
