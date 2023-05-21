using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Lw.Data.Entity;
using Microsoft.AspNetCore.SignalR;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Data;
using Nop.Plugin.VoiceIn.CRUD.Models;

namespace Nop.Plugin.VoiceIn.CRUD.Data
{
    public class ItemRepository : IRepository<ItemModel>, IItemRepository
    {
        private readonly IDbContext _dbContext;

        public ItemRepository(IDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public virtual IQueryable<ItemModel> Table => _dbContext.Set<ItemModel>();

        public virtual void Delete(ItemModel entity, bool publishEvent = true)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbContext.Set<ItemModel>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public virtual int Delete(Expression<Func<ItemModel, bool>> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            var entities = _dbContext.Set<ItemModel>().Where(predicate).ToList();
            _dbContext.Set<ItemModel>().Remove(entities);
            _dbContext.SaveChanges();

            return entities.Count;
        }

        public virtual async Task DeleteAsync(ItemModel entity, bool publishEvent = true)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbContext.Set<ItemModel>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public virtual async Task DeleteAsync(IList<ItemModel> entities, bool publishEvent = true)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            _dbContext.Set<ItemModel>().Remove(entities);
             _dbContext.SaveChanges();
        }

        public virtual async Task<int> DeleteAsync(Expression<Func<ItemModel, bool>> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            var entities = _dbContext.Set<ItemModel>().Where(predicate).ToList();
            _dbContext.Set<ItemModel>().Remove(entities);
             _dbContext.SaveChanges();

            return entities.Count;
        }
        public virtual IList<ItemModel> GetAll(Func<IQueryable<ItemModel>, IQueryable<ItemModel>> func = null, Func<IStaticCacheManager, CacheKey> getCacheKey = null, bool includeDeleted = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task<IList<ItemModel>> GetAllAsync(Func<IQueryable<ItemModel>, IQueryable<ItemModel>> func = null, Func<IStaticCacheManager, CacheKey> getCacheKey = null, bool includeDeleted = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task<IList<ItemModel>> GetAllAsync(Func<IQueryable<ItemModel>, Task<IQueryable<ItemModel>>> func = null, Func<IStaticCacheManager, CacheKey> getCacheKey = null, bool includeDeleted = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task<IList<ItemModel>> GetAllAsync(Func<IQueryable<ItemModel>, Task<IQueryable<ItemModel>>> func, Func<IStaticCacheManager, Task<CacheKey>> getCacheKey, bool includeDeleted = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task<IPagedList<ItemModel>> GetAllPagedAsync(Func<IQueryable<ItemModel>, IQueryable<ItemModel>> func = null, int pageIndex = 0, int pageSize = int.MaxValue, bool getOnlyTotalCount = false, bool includeDeleted = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task<IPagedList<ItemModel>> GetAllPagedAsync(Func<IQueryable<ItemModel>, Task<IQueryable<ItemModel>>> func = null, int pageIndex = 0, int pageSize = int.MaxValue, bool getOnlyTotalCount = false, bool includeDeleted = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual ItemModel GetById(int? id, Func<IStaticCacheManager, CacheKey> getCacheKey = null, bool includeDeleted = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task<ItemModel> GetByIdAsync(int? id, Func<IStaticCacheManager, CacheKey> getCacheKey = null, bool includeDeleted = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task<IList<ItemModel>> GetByIdsAsync(IList<int> ids, Func<IStaticCacheManager, CacheKey> getCacheKey = null, bool includeDeleted = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual void Insert(ItemModel entity, bool publishEvent = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual void Insert(IList<ItemModel> entities, bool publishEvent = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task InsertAsync(ItemModel entity, bool publishEvent = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task InsertAsync(IList<ItemModel> entities, bool publishEvent = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task<ItemModel> LoadOriginalCopyAsync(ItemModel entity)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task TruncateAsync(bool resetIdentity = false)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual void Update(ItemModel entity, bool publishEvent = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual void Update(IList<ItemModel> entities, bool publishEvent = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task UpdateAsync(ItemModel entity, bool publishEvent = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }

        public virtual Task UpdateAsync(IList<ItemModel> entities, bool publishEvent = true)
        {
            // Implement the method logic here
            throw new NotImplementedException();
        }
    }
}
