using BaseTemplate.Data.Context;
using BaseTemplate.Data.Entities;

namespace BaseTemplate.Data.Repository
{
    public interface IBrandsRepository : IBaseRepository<Brands> { }
    public class BrandsRepository : BaseRepository<Brands>, IBrandsRepository
    {
        public BrandsRepository(SuperMarketDbContext context) : base(context)
        {
        }
    }
}
