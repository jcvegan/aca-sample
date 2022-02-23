namespace CustomAuth.Services
{
    public static class SerivceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IClaimsFactory, ClaimsFactory>();
            services.AddScoped<ISessionService, SessionService>();
            services.AddScoped<ITokenFactory, TokenFactory>();
            services.AddScoped<ITokenValidator, TokenValidator>();
            services.AddScoped<IClaimsDecoder, ClaimsDecoder>();
            return services;
        }
    }
}
