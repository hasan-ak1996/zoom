using abpZoom.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace abpZoom
{
    [DependsOn(
        typeof(abpZoomEntityFrameworkCoreTestModule)
        )]
    public class abpZoomDomainTestModule : AbpModule
    {

    }
}