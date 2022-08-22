using BaseTemplate.Data.Context;
using BaseTemplate.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BaseTemplate.Data.Repository
{
    public interface IBaseRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete (int id);
    }
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseEntity
    {
        protected readonly SuperMarketDbContext _superMarketDbContext;
        protected readonly DbSet<TEntity> entities;
        public BaseRepository(SuperMarketDbContext superMarketDbContext)
        {
            _superMarketDbContext = superMarketDbContext;
            entities = superMarketDbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return entities.AsQueryable();
        }

        public async Task<TEntity> GetById(int id)
        {
           var entity = await entities.Where(x=> x.Id == id).SingleOrDefaultAsync();
            return entity;
        }
        public async Task<TEntity> Create(TEntity entity)
        {
            var result = await entities.AddAsync(entity);
            await _superMarketDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _superMarketDbContext.Entry(entity).State = EntityState.Modified;
            await _superMarketDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await GetById(id);

            var result = entities.Remove(entity);
            await _superMarketDbContext.SaveChangesAsync();

            return result.Entity;
        }

    }
}
