using Microsoft.Extensions.DependencyInjection;

namespace Chatty.Application.Chat;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddChat(this IServiceCollection services)
    {
        return services;
    }
}
