using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Chatty.Infrastructure.Persistence;

internal class PersistenceSettingsSetup(IConfiguration configuration) : IConfigureOptions<PersistenceSettings>
{
    public void Configure(PersistenceSettings options)
    {
        configuration.GetSection(PersistenceSettings.SectionName).Bind(options);
    }
}

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        return services
            .ConfigureOptions<PersistenceSettingsSetup>()
            .AddDbContext<ApplicationDbContext>((services, options) =>
            {
                var settings = services.GetRequiredService<IOptions<PersistenceSettings>>();
                options.UseMongoDB(settings.Value.ConnectionString);
            });
    }
}
