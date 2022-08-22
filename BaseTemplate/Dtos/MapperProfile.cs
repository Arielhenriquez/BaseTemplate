using AutoMapper;
using BaseTemplate.Data.Entities;

namespace BaseTemplate.Dtos
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Brands, BrandsDto>().ReverseMap();
            CreateMap<Products, ProductsDto>().ReverseMap();
            CreateMap<SuperMarkets, SuperMarketDto>().ReverseMap();
            CreateMap<ShoppingList, ShoppingListDto>().ReverseMap();
        }
    }
}
