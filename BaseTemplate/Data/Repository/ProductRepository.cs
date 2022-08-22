using BaseTemplate.Data.Context;
using BaseTemplate.Data.Entities;

namespace BaseTemplate.Data.Repository
{
    public interface IProductRepository : IBaseRepository<Products> { }
    public class ProductRepository : BaseRepository<Products>, IProductRepository
    {
        public ProductRepository(SuperMarketDbContext context) : base(context)
        {

        }
    }
}
