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
    public class SuperMarketController : BaseController<SuperMarkets, SuperMarketDto>
    {
        public SuperMarketController(ISuperMarketService superMarketService, IMapper mapper) : base(superMarketService, mapper)
        {

        }
    }
}
