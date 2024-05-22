using ECommerceApi.Application.Features.Product.Queries.GetAllProduct;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using MediatR;
namespace ECommerceApi.Application.Features.Product.Handlers;
public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, IList<GetAllProductQueryResponse>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllProductQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IList<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
    {
        List<GetAllProductQueryResponse> response = new();
        var products = await _unitOfWork.GetReadRepository<ECommerce.Domain.Entities.Product>().GetAllAsync();
        foreach (var product in products)
        {
            response.Add(new GetAllProductQueryResponse
            {
                BrandId = product.BrandId,
                Price = product.Price,
                Discount = product.Discount,
                Title = product.Title,
                Description = product.Description,
            });
        }
        return response;
    }
}
