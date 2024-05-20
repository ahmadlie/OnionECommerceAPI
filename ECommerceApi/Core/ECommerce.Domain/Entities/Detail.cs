using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;

public class Detail : BaseEntity
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
}
