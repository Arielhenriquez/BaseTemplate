using AutoMapper;
using BaseTemplate.Data.Entities;
using BaseTemplate.Data.Repository;
using BaseTemplate.Dtos;

namespace BaseTemplate.Services
{
    public interface IShoppingListService : ICrudService<ShoppingList, ShoppingListDto> { }
    public class ShoppingListService : CrudService<ShoppingList, ShoppingListDto>, IShoppingListService
    {
        public ShoppingListService(IMapper mapper, IShoppingListRepository shoppingListRepository) : base(mapper, shoppingListRepository)
        {

        }
    }
}
