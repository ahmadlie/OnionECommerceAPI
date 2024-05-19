using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;

public class Detail : BaseEntity
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required int CategoryId { get; set; }
    public Category Category { get; set; }

}
