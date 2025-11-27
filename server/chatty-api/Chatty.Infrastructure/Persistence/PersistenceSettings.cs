namespace Chatty.Infrastructure.Persistence;

internal record PersistenceSettings
{
    public static string SectionName => "Persistence";

    public required string ConnectionString { get; init; }
}
