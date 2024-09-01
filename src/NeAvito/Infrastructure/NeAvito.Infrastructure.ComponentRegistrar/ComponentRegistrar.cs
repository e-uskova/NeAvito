using Microsoft.Extensions.DependencyInjection;
using NeAvito.Application.AppServices.Category.Repository;
using NeAvito.Application.AppServices.Category.Services;
using NeAvito.Application.AppServices.User.Repository;
using NeAvito.Application.AppServices.User.Services;
using NeAvito.Infrastructure.DataAccess.Repositories;

namespace NeAvito.Infrastructure.ComponentRegistrar
{
    public static class ComponentRegistrar
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
