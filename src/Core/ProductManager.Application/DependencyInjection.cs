using Microsoft.Extensions.DependencyInjection;
using ProductManager.Application.Services;
using ProductManager.Domain.Services;

namespace ProductManager.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection ServiceRegister(this IServiceCollection services)
            => services
                .ConfigService()
                .ConfigAutoMapper();

        public static IServiceCollection ConfigService(this IServiceCollection services)
            => services
                .AddScoped<IProductService, ProductService>()
                .AddScoped<IInventoryService, InventoryService>()
                .AddScoped<IClientService, ClientService>()
                .AddScoped<IBuyService, BuyService>()
                ;

        public static IServiceCollection ConfigAutoMapper(this IServiceCollection services)
            => services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }
}