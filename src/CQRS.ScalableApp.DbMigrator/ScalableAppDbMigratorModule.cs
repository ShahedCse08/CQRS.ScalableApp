using CQRS.ScalableApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CQRS.ScalableApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ScalableAppEntityFrameworkCoreModule),
    typeof(ScalableAppApplicationContractsModule)
    )]
public class ScalableAppDbMigratorModule : AbpModule
{

}
