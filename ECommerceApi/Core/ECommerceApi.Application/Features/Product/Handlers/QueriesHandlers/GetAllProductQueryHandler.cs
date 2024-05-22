using AutoMapper;
using ECommerceApi.Application.Features.Product.Queries.GetAllProduct;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using MediatR;
namespace ECommerceApi.Application.Features.Product.Handlers.QueriesHandlers;
public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, IList<GetAllProductQueryResponse>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public GetAllProductQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IList<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
    {
        var products = await _unitOfWork.GetReadRepository<ECommerce.Domain.Entities.Product>().GetAllAsync();
        return _mapper.Map<List<GetAllProductQueryResponse>>(products);
    }
}
