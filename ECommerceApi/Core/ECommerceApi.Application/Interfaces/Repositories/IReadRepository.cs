using ECommerce.Domain.Common;
using System.Linq.Expressions;

namespace ECommerceApi.Application.Interfaces.Repositories;
public interface IReadRepository<TEntity> where TEntity : class, IBaseEntity, new()
{
    Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null);
    Task<TEntity> GetByIdAsync(int id);
}
