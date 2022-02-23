using CustomAuth.Data;

namespace CustomAuth.Providers
{
    public static class IdentityProviderExtensions
    {
        public static IServiceCollection RegisterIdentityProvider(this IServiceCollection services)
        {
            services.AddScoped<IIdentityProvider, IdentityProvider>(sp => new IdentityProvider(IdentityUsers.UsersDirectory));
            return services;
        }
    }
}
