using CQRS.ScalableApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CQRS.ScalableApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ScalableAppController : AbpControllerBase
{
    protected ScalableAppController()
    {
        LocalizationResource = typeof(ScalableAppResource);
    }
}
