﻿using Examen.Repositories.DogRepository;
using Examen.Services;

namespace Examen.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //    services.AddTransient<IUserRepository, UserRepository>();
            services.AddScoped<IDogRepository, DogRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //    services.AddTransient<IAuthService, AuthService>();
            services.AddScoped<IDogService, DogService>();

            return services;
        }
    }
}
