using Chatty.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Chatty.Infrastructure.Persistence;

internal class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users { get; init; }
}
