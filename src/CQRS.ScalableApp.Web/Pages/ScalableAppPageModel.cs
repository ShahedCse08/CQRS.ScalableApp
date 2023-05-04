using CQRS.ScalableApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CQRS.ScalableApp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ScalableAppPageModel : AbpPageModel
{
    protected ScalableAppPageModel()
    {
        LocalizationResourceType = typeof(ScalableAppResource);
    }
}
