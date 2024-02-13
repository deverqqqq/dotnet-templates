namespace Template.WebApi.Infrastructure;

public static class DI
{
    public static IServiceCollection AddApplicationItems(
        this IServiceCollection services)
    {
        services.AddSingleton<ApplicationMapper>();
        
        return services;
    }
}