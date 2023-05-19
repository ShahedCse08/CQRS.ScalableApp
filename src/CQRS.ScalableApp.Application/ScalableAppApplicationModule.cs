using CQRS.ScalableApp.Models.Players;
using CQRS.ScalableApp.MyHandler;
using CQRS.ScalableApp.Players.Dtos;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace CQRS.ScalableApp;

[DependsOn(
    typeof(ScalableAppDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(ScalableAppApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class ScalableAppApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<ScalableAppApplicationModule>();
        });

        Configure<AbpDistributedEntityEventOptions>(options =>
        {

            //Enable for all entities
            options.AutoEventSelectors.AddAll();

            options.EtoMappings.Add<Player, PlayerEto>();
           

           
        });
    }
}
