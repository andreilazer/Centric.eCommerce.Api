using Centric.eCommerce.Product.Api.Models;

namespace Centric.eCommerce.Product.Api.Profiles
{
    public class ProductProfile: AutoMapper.Profile
    {
        public ProductProfile()
        {
            CreateMap<DB.Product, ProductModel>().ReverseMap();
        }
    }
}
