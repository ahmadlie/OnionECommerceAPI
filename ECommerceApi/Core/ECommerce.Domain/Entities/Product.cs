using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;
public class Product : BaseEntity
{
    public string Title { get; set; } = null!;
    public  string Description { get; set; } = null!;
    public  int BrandId { get; set; } 
    public  decimal? Price { get; set; } = null!;
    public  decimal? Discount { get; set; } = null!;
    public  Brand Brand { get; set; }
    public ICollection<Category> Categories { get; set; }
    public ICollection<Detail> Details { get; set; }


}
