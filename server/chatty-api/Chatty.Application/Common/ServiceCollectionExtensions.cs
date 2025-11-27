using Microsoft.Extensions.DependencyInjection;

namespace Chatty.Application.Common;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCommon(this IServiceCollection services)
    {
        return services;
    }
}
