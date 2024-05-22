using ECommerce.Domain.Common;
using ECommerceApi.Application.Interfaces.Repositories;

namespace ECommerceApi.Application.Interfaces.UnitOfWorks;
public interface IUnitOfWork
{
    IWriteRepository<T> GetWriteRepository<T>() where T : class, IBaseEntity, new();
    IReadRepository<T> GetReadRepository<T>() where T : class, IBaseEntity, new();
    Task<int> SaveChangesAsync();
    int SaveChanges();
}
