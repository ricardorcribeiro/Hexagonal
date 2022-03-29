using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductManager.Domain.Adapters;
using ProductManager.Infra.SQLRepository.Contexts;
using ProductManager.Infra.SQLRepository.Repositorys;

namespace ProductManager.Infra.SQLRepository;

public static class DependencyInjection
    {
        public static IServiceCollection RepositoryRegister(this IServiceCollection services, IConfiguration configuration)
            => services
                .ConfigRepository()
                .ConfiguraContext(configuration);
                
        public static IServiceCollection ConfigRepository(this IServiceCollection services)
            => services
                .AddScoped<IProductRepository, ProductRepository>()
                .AddScoped<IInventoryRepository, InventoryRepository>()
                .AddScoped<IClientRepository, ClientRepository>()
                .AddScoped<IBuyRepository, BuyRepository>()
                ;

        public static IServiceCollection ConfiguraContext(this IServiceCollection services, IConfiguration configuration) 
            => services
                .AddDbContextFactory<SqlContext>(options => {
                    options
                        .UseLazyLoadingProxies()
                        .UseSqlServer(configuration["SqlConnection:SqlConnectionString"]);
                    },ServiceLifetime.Scoped)
                .AddTransient<SqlContext>();
    }