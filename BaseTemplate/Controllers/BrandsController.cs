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
    public class BrandsController : BaseController<Brands, BrandsDto>
    {
        public BrandsController(IBrandService brandService, IMapper mapper) : base (brandService, mapper)
        {

        }
    }
}
