using CQRS.ScalableApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CQRS.ScalableApp;

[DependsOn(
    typeof(ScalableAppEntityFrameworkCoreTestModule)
    )]
public class ScalableAppDomainTestModule : AbpModule
{

}
