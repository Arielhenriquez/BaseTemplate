using AutoMapper;
using BaseTemplate.Data.Entities;
using BaseTemplate.Dtos;
using BaseTemplate.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController<Products, ProductsDto>
    {
        public ProductsController(IProductService productService, IMapper mapper) : base (productService, mapper)
        {

        }
    }
}
