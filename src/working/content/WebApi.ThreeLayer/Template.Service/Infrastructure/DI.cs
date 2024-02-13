namespace Template.Service.Infrastructure;

public static class DI
{
    public static IServiceCollection AddServiceItems(
        this IServiceCollection services)
    {
        services.AddSingleton<ServiceMapper>();
        services.AddScoped<ISampleService, SampleService>(sp =>
        {
            var sampleRepository = sp.GetRequiredService<ISampleRepository>();
            return new SampleService(
                new ServiceMapper(),
                sampleRepository);
        });

        return services;
    }
}