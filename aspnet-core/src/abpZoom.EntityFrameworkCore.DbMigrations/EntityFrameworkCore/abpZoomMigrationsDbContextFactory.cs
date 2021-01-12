using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace abpZoom.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class abpZoomMigrationsDbContextFactory : IDesignTimeDbContextFactory<abpZoomMigrationsDbContext>
    {
        public abpZoomMigrationsDbContext CreateDbContext(string[] args)
        {
            abpZoomEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<abpZoomMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new abpZoomMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../abpZoom.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
