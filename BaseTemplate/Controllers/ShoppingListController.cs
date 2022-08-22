using AutoMapper;
using BaseTemplate.Data.Entities;
using BaseTemplate.Dtos;
using BaseTemplate.Services;
using Microsoft.AspNetCore.Mvc;

namespace BaseTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListController : BaseController<ShoppingList, ShoppingListDto>
    {
        public ShoppingListController(IShoppingListService shoppingListService, IMapper mapper) : base(shoppingListService, mapper)
        {

        }
    }
}
