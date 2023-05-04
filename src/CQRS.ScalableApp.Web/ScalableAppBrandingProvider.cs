using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CQRS.ScalableApp.Web;

[Dependency(ReplaceServices = true)]
public class ScalableAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ScalableApp";
}
