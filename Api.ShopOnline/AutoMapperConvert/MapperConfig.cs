using AutoMapper;
using shopOnline.Api.Models;
using ShopOnline.Modes.DTOs;

namespace Api.ShopOnline.AutoMapperConvert
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<ProductDTO, Product>().ReverseMap();
            CreateMap<IReadOnlyList<ProductDTO>, IReadOnlyList<Product>>().ReverseMap();
            
            
        }
    }
}
