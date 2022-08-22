using AutoMapper;
using BaseTemplate.Data.Entities;
using BaseTemplate.Data.Repository;
using BaseTemplate.Dtos;

namespace BaseTemplate.Services
{
    public interface ISuperMarketService : ICrudService<SuperMarkets, SuperMarketDto> { }
    public class SuperMarketService : CrudService<SuperMarkets, SuperMarketDto>, ISuperMarketService
    {
        public SuperMarketService(IMapper mapper, ISuperMarketRepository superMarketRepository) : base(mapper, superMarketRepository)
        {

        }
    }
}
