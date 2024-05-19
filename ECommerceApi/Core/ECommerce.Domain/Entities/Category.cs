using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;
public class Category : BaseEntity , IBaseEntity
{
    public required int ParentId { get; set; }
    public required string Name { get; set; }
    public required string Priority { get; set; }
    public int ProductId { get; set; }
    public ICollection<Product> Products { get; set; }
    public ICollection<Detail> Details { get; set; }
}
