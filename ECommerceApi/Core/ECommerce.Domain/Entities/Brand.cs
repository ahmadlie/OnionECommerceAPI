using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;
public class Brand : BaseEntity , IBaseEntity
{
    public required string Name { get; set; }
}
