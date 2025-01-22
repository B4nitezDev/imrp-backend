using imrp.application.Dto;
using imrp.application.Interfaces;
using imrp.application.Interfaces.UseCases.Auth;
using imrp.application.Interfaces.UseCases.User;
using imrp.application.Services;
using imrp.application.Use_cases.Auth;
using imrp.application.Use_cases.User;
using imrp.domain.Entities;
using imrp.domain.Interfaces;
using imrp.persistence.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace imrp.persistence.DependencyInjection;

public static class BussinesExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Registrar servicios de la capa Application
        services.AddTransient<IAddUserUseCase, AddUserUseCase>();
        services.AddTransient<ILoginUseCase, LoginUseCase>();
        services.AddTransient(typeof(IMapperService<,>), typeof(MapperService<,>));
       // services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        services.AddTransient<ILoggerService, LoggerService>();
        services.AddTransient<UserServices>();

        return services;
    }

    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        // Registrar servicios de persistencia
        services.AddScoped<IAddUserUseCase, AddUserUseCase>();
        services.AddScoped(typeof(IMapperService<,>), typeof(MapperService<,>));
        services.AddScoped<ILoginUseCase, LoginUseCase>();

        // services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<ILoggerService, LoggerService>();
        services.AddScoped<UserServices>();
        
        return services;
    }
}