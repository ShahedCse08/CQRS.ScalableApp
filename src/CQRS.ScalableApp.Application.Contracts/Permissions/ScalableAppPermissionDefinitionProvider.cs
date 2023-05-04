using CQRS.ScalableApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CQRS.ScalableApp.Permissions;

public class ScalableAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ScalableAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ScalableAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ScalableAppResource>(name);
    }
}
