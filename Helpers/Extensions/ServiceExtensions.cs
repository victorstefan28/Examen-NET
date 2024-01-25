using Examen.Repositories.OrderRepository;
using Examen.Repositories.ProductOrdersRepository;
using Examen.Repositories.ProductRepository;
using Examen.Repositories.UserRepository;
using Examen.Services.OrderService;
using Examen.Services.ProductService;
using Examen.Services.UserService;

namespace Examen.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //    services.AddTransient<IUserRepository, UserRepository>();
            //services.AddScoped<IDogRepository, DogRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderProductRepository, OrderProductRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //    services.AddTransient<IAuthService, AuthService>();
            //services.AddScoped<IDogService, DogService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();

            return services;
        }
    }
}
