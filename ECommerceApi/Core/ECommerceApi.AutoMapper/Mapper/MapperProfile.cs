using AutoMapper;
using ECommerce.Domain.Entities;
using ECommerceApi.Application.Features.Product.Commands.CreateProduct;
using ECommerceApi.Application.Features.Product.Queries.GetAllProduct;

namespace ECommerceApi.AutoMapper.Mapper;
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Product, GetAllProductQueryResponse>().ReverseMap();
        CreateMap<Product, CreateProductCommandRequest>().ReverseMap();
    }
}
