using System;
using System.Collections.Generic;
using System.Text;
using CQRS.ScalableApp.Localization;
using Volo.Abp.Application.Services;

namespace CQRS.ScalableApp;

/* Inherit your application services from this class.
 */
public abstract class ScalableAppAppService : ApplicationService
{
    protected ScalableAppAppService()
    {
        LocalizationResource = typeof(ScalableAppResource);
    }
}
