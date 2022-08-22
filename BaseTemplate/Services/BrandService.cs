using AutoMapper;
using BaseTemplate.Data.Entities;
using BaseTemplate.Data.Repository;
using BaseTemplate.Dtos;

namespace BaseTemplate.Services
{
    public interface IBrandService : ICrudService<Brands, BrandsDto>{}

    public class BrandService : CrudService<Brands, BrandsDto>, IBrandService
    {
        public BrandService(IMapper mapper, IBrandsRepository brandsRepository) : base (mapper, brandsRepository)
        {

        }
    }
}
