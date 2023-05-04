using Volo.Abp.Modularity;

namespace CQRS.ScalableApp;

[DependsOn(
    typeof(ScalableAppApplicationModule),
    typeof(ScalableAppDomainTestModule)
    )]
public class ScalableAppApplicationTestModule : AbpModule
{

}
