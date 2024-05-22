using AutoMapper;
using ECommerce.Domain.Entities;
using ECommerceApi.Application.Features.Product.Commands.CreateProduct;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using MediatR;

namespace ECommerceApi.Application.Features.Product.Handlers.CommandsHandlers;
public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CreateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
    {
        var product = _mapper.Map<ECommerce.Domain.Entities.Product>(request);
        await _unitOfWork.GetWriteRepository<ECommerce.Domain.Entities.Product>().AddAsync(product);
        if (await _unitOfWork.SaveChangesAsync() > 0) { return new() { IsSuccess = true }; }
        return new() { IsSuccess = false };
    }
}
