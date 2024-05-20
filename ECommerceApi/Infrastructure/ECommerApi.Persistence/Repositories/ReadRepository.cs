using ECommerApi.Persistence.Context;
using ECommerce.Domain.Common;
using ECommerceApi.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerApi.Persistence.Repositories;
public class ReadRepository<TEntity> : IReadRepository<TEntity> where TEntity : class, IBaseEntity, new()
{
    private readonly AppDbContext _dbContext;
    private readonly DbSet<TEntity> _entity;
    public ReadRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _entity = _dbContext.Set<TEntity>();
    }

    public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? expression = null, bool enableTracking = false)
    {
        IQueryable<TEntity> queryableEntity = _entity;
        if (!enableTracking) queryableEntity = queryableEntity.AsNoTracking();
        if (expression is not null) return await queryableEntity
                                   .Where(expression)
                                   .ToListAsync();
        return await queryableEntity.ToListAsync();
    }

    public async Task<IList<TEntity>> GetAllByPageAsync(int currrentPage = 1, int pageSize = 3, Expression<Func<TEntity, bool>>? expression = null, bool enableTracking = false)
    {
        IQueryable<TEntity> queryableEntity = _entity;
        if (!enableTracking) queryableEntity = queryableEntity.AsNoTracking();
        if (expression is not null) return await queryableEntity
                                           .Where(expression)
                                           .Skip((currrentPage - 1) + pageSize)
                                           .Take(pageSize).ToListAsync();
        return await queryableEntity.Skip((currrentPage - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression, bool enableTracking = false)
    {
        IQueryable<TEntity> queryableEntity = _entity;
        if (!enableTracking) queryableEntity = queryableEntity.AsNoTracking();
        return await queryableEntity.FirstOrDefaultAsync(expression);
                                   
    }
}
