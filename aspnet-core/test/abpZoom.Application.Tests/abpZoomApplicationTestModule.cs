using Volo.Abp.Modularity;

namespace abpZoom
{
    [DependsOn(
        typeof(abpZoomApplicationModule),
        typeof(abpZoomDomainTestModule)
        )]
    public class abpZoomApplicationTestModule : AbpModule
    {

    }
}