using AutoMapper;
using ECommerceApi.AutoMapper.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceApi.AutoMapper;
public static class Registration
{
    public static void AddAutoMapper(this IServiceCollection services) 
    {
        var mapperConfiguration = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MapperProfile());
        });
        services.AddSingleton(mapperConfiguration.CreateMapper());
    }
}
