using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;
public class Brand : BaseEntity , IBaseEntity
{
    public string Name { get; set; } = null!;
    public ICollection<Product> Products {  get; set; }
}
