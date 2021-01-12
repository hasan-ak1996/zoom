using abpZoom.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace abpZoom.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(abpZoomEntityFrameworkCoreDbMigrationsModule),
        typeof(abpZoomApplicationContractsModule)
        )]
    public class abpZoomDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
