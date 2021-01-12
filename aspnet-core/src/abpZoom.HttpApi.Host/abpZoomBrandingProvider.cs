using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace abpZoom
{
    [Dependency(ReplaceServices = true)]
    public class abpZoomBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "abpZoom";
    }
}
