using Volo.Abp.Settings;

namespace CQRS.ScalableApp.Settings;

public class ScalableAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ScalableAppSettings.MySetting1));
    }
}
