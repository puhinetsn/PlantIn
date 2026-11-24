using FluentValidation;
using PlantInAPI.src.User.Repositories;
using PlantInAPI.src.User.Services;
using PlantInAPI.src.User.Validation;

namespace PlantInAPI.src.User
{
    public static class UserDI
    {
        public static IServiceCollection AddUsersDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUsersRepo, UsersRepo>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddValidatorsFromAssemblyContaining<UserValidator>();

            return services;
        }
    }
}
