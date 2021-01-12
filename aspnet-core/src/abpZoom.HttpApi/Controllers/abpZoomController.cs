using abpZoom.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abpZoom.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class abpZoomController : AbpController
    {
        protected abpZoomController()
        {
            LocalizationResource = typeof(abpZoomResource);
        }
    }
}