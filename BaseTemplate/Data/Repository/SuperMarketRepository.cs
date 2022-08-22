using BaseTemplate.Data.Context;
using BaseTemplate.Data.Entities;

namespace BaseTemplate.Data.Repository
{
    public interface ISuperMarketRepository: IBaseRepository<SuperMarkets> { }
    public class SuperMarketRepository : BaseRepository<SuperMarkets>, ISuperMarketRepository
    {
        public SuperMarketRepository(SuperMarketDbContext context) : base(context)
        {

        }
    }
}
