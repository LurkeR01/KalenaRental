using KalenaRental.Application.Interfaces;
using KalenaRental.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace KalenaRental.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICarService, CarService>();

        return services;
    }
}