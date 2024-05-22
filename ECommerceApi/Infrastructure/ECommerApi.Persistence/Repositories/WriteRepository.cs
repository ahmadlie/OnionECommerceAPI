using ECommerApi.Persistence.Context;
using ECommerce.Domain.Common;
using ECommerceApi.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ECommerApi.Persistence.Repositories;
public class WriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : class, IBaseEntity, new()
{
    private readonly AppDbContext _dbContext;
    private readonly DbSet<TEntity> _entity;
    public WriteRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _entity = _dbContext.Set<TEntity>();
    }
    public async Task AddAsync(TEntity entity)
    {
        await _entity.AddAsync(entity);    
    }

    public async Task AddRangeAsync(IList<TEntity> entities)
    {
        await _entity.AddRangeAsync(entities);
    }


    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        await Task.Run(() => { _entity.Update(entity); });
        return entity;
    }
    public async Task HardDeleteAsync(TEntity entity)
    {
        await Task.Run(() => { _entity.Remove(entity); });
    }

}
