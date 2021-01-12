using System;
using System.Collections.Generic;
using System.Text;
using abpZoom.Localization;
using Volo.Abp.Application.Services;

namespace abpZoom
{
    /* Inherit your application services from this class.
     */
    public abstract class abpZoomAppService : ApplicationService
    {
        protected abpZoomAppService()
        {
            LocalizationResource = typeof(abpZoomResource);
        }
    }
}
