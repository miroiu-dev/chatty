using Chatty.Application.Chat;
using Chatty.Application.Common;
using Chatty.Application.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Chatty.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services
            .AddCommon()
            .AddChat()
            .AddUsers();
    }
}
