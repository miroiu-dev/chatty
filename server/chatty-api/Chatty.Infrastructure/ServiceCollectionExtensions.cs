using Chatty.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Chatty.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services
            .AddPersistence();
    }
}
