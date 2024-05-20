using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;
public class Category : BaseEntity , IBaseEntity
{
    public int ParentId { get; set; }
    public string Name { get; set; } = null!;
    public int Priority { get; set; }
    public int ProductId { get; set; }
    public ICollection<Product> Products { get; set; }
}
