using BlazorWebApp.Data;
using Microsoft.EntityFrameworkCore;

public interface IDbContextFactory
{
    ApplicationDbContext CreateDbContext();
}

public class DbContextFactory(DbContextOptions<ApplicationDbContext> options) : IDbContextFactory
{
    private readonly DbContextOptions<ApplicationDbContext> _options = options;

    public ApplicationDbContext CreateDbContext()
    {
        return new ApplicationDbContext(_options);
    }
}