using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using abpZoom.Data;
using Volo.Abp.DependencyInjection;

namespace abpZoom.EntityFrameworkCore
{
    public class EntityFrameworkCoreabpZoomDbSchemaMigrator
        : IabpZoomDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreabpZoomDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the abpZoomMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<abpZoomMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}