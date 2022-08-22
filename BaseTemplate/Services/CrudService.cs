using AutoMapper;
using BaseTemplate.Data.Entities;
using BaseTemplate.Data.Repository;
using BaseTemplate.Dtos;

namespace BaseTemplate.Services
{
    public interface ICrudService<TEntity, TEntityDto> where TEntity : class, IBaseEntity
       where TEntityDto : class, IBaseEntityDto
    {
        IQueryable<TEntity> GetAll();
        Task<TEntityDto> GetById(int id);
        Task<TEntityDto> Create(TEntityDto entityDto);
        Task<TEntityDto> Update(int id, TEntityDto entityDto);
        Task<TEntityDto> Delete(int id);

    }
    public class CrudService<TEntity, TEntityDto> : ICrudService<TEntity, TEntityDto> where TEntity : class, IBaseEntity
      where TEntityDto : class, IBaseEntityDto
    {

        protected readonly IMapper _mapper;
        protected readonly IBaseRepository<TEntity> _repository;

        public CrudService(IMapper mapper, IBaseRepository<TEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<TEntityDto> GetById(int id)
        {
            var entity = await _repository.GetById(id);
            var dto = _mapper.Map<TEntityDto>(entity);
            return dto;
        }

        public async Task<TEntityDto> Create(TEntityDto entityDto)
        {
            TEntity entity = _mapper.Map<TEntity>(entityDto);
            await _repository.Create(entity);


            entityDto = _mapper.Map<TEntityDto>(entity);

            return entityDto;
        }

        public async Task<TEntityDto> Update(int id, TEntityDto entityDto)
        {
            TEntity entity = await _repository.GetById(id);
            if (entity is null)
                return null;

            _mapper.Map(entityDto, entity);

            await _repository.Update(entity);

            entityDto = _mapper.Map(entity, entityDto);

            return entityDto;
        }


        public async Task<TEntityDto> Delete(int id)
        {
            var entity = await _repository.GetById(id);

            if (entity is null)
                return null;

            entity = await _repository.Delete(id);

            var dto = _mapper.Map<TEntityDto>(entity);
            return dto;

        }
    }
}
