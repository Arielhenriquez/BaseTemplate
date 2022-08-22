using AutoMapper;
using BaseTemplate.Data.Entities;
using BaseTemplate.Data.Repository;
using BaseTemplate.Dtos;

namespace BaseTemplate.Services
{
    public interface IProductService : ICrudService<Products, ProductsDto> { }

    public class ProductsService : CrudService<Products, ProductsDto>, IProductService
    {
        public ProductsService(IMapper mapper, IProductRepository productRepository) : base(mapper, productRepository)
        {
        }
    }
}
