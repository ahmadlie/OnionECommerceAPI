using MediatR;

namespace ECommerceApi.Application.Features.Product.Queries.GetAllProduct;
public class GetAllProductQueryRequest : IRequest<IList<GetAllProductQueryResponse>>
{
}
