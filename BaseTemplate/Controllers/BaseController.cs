using AutoMapper;
using BaseTemplate.Data.Entities;
using BaseTemplate.Dtos;
using BaseTemplate.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BaseTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TEntityDto> : ControllerBase where TEntity : class, IBaseEntity
            where TEntityDto : class, IBaseEntityDto
    {
        public IMapper _mapper { get; set; }
        protected readonly ICrudService<TEntity, TEntityDto> _crudService;
        public BaseController(ICrudService<TEntity, TEntityDto> crudService, IMapper mapper)
        {
            _crudService = crudService;
            _mapper = mapper;
        }

        [HttpGet(nameof(Get))]
        public virtual IActionResult Get()
        {
            var list = _crudService.GetAll();
            return Ok(list);
        }

        [HttpGet(nameof(GetById))]
        public virtual async Task<IActionResult> GetById(int id)
        {
            TEntityDto dto = await _crudService.GetById(id);

            if (dto is null)
                return NotFound();

            return Ok(dto);
        }


        [HttpPost(nameof(Post))]
        public virtual async Task<IActionResult> Post([FromBody] TEntityDto entityDto)
        {
            entityDto = await _crudService.Create(entityDto);
            return CreatedAtAction(WebRequestMethods.Http.Get, new { id = entityDto.Id }, entityDto);
        }

        [HttpPut(nameof(Put))]
        public virtual async Task<IActionResult> Put(int id, [FromBody] TEntityDto entityDto)
        {
            if (entityDto.Id != id)
                return BadRequest();

            entityDto = await _crudService.Update(id, entityDto);

            if (entityDto is null)
                return NotFound();

            return Ok(entityDto);
        }

        [HttpDelete(nameof(Delete))]
        public virtual async Task<IActionResult> Delete(int id)
        {
            TEntityDto entityDto = await _crudService.Delete(id);

            if (entityDto is null)
                return NotFound();

            return Ok(entityDto);
        }
    }
}

