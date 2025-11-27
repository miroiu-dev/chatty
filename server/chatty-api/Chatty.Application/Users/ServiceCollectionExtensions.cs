using Microsoft.Extensions.DependencyInjection;

namespace Chatty.Application.Users;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUsers(this IServiceCollection services)
    {
        return services;
    }
}
