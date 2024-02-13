namespace Template.Repository.Infrastructure;

public static class DI
{
    public static IServiceCollection AddRepositoryItems(
        this IServiceCollection services)
    {
        services.AddScoped<IDataConstant, DataConstant>(sp => new DataConstant("conn-string"));
        services.AddScoped<ISampleRepository, SampleRepository>(sp =>
        {
            var dataConstant = sp.GetRequiredService<IDataConstant>();
            return new SampleRepository(() => dataConstant.GetConnection());
        });

        return services;
    }
}