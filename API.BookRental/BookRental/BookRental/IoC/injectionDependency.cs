using BookRental.Models;
using BookRental.Repository;
using BookRental.Repository.Interfaces;
using BookRental.Services;
using BookRental.Services.Interfaces;

namespace BookRental.IoC
{
    public static class injectionDependency
    {
        public static IServiceCollection addServices(this IServiceCollection services,
                                                          IConfiguration configuration)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }

        public static IServiceCollection ReadArchiverConfiguration(this IServiceCollection services,
                                                                        IConfiguration configuration)
        {
            services.Configure<Connection>(configuration.GetSection("ConnectionStrings"));

            return services;
        }

    }
}
