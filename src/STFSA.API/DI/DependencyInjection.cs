using STFSA.Application.Auth.Interfaces;
using STFSA.Application.Auth.Services;
using STFSA.Application.User.Interfaces;
using STFSA.Application.User.Services;

namespace STFSA.API.DI
{
    public static class DependencyInjection 
    {
        public static void AddScopedServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
        }

        public static void AddSingletonServices(this IServiceCollection services)
        {
            // Add singleton services here if needed
        }

        public static void AddTransientServices(this IServiceCollection services)
        {
            // Add transient services here if needed
        }
    }
}
