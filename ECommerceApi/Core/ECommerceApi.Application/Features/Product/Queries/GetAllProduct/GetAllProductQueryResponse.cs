namespace ECommerceApi.Application.Features.Product.Queries.GetAllProduct;
public class GetAllProductQueryResponse
{
    public string? Title { get; set; }
    public string? Description { get; set; } 
    public int BrandId { get; set; }
    public decimal? Price { get; set; } 
    public decimal? Discount { get; set; } 
}
