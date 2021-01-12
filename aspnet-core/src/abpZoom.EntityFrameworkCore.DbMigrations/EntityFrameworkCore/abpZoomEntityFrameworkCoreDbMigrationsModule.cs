using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace abpZoom.EntityFrameworkCore
{
    [DependsOn(
        typeof(abpZoomEntityFrameworkCoreModule)
        )]
    public class abpZoomEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<abpZoomMigrationsDbContext>();
        }
    }
}
