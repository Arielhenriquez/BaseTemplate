using BaseTemplate.Data.Context;
using BaseTemplate.Data.Entities;

namespace BaseTemplate.Data.Repository
{
    public interface IShoppingListRepository : IBaseRepository<ShoppingList> { }
    public class ShoppingListRepository : BaseRepository<ShoppingList>, IShoppingListRepository
    {

        public ShoppingListRepository(SuperMarketDbContext context) : base(context)
        {

        }
    }
}
