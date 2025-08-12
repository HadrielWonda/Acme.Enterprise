using Volo.Abp.Settings;

namespace Acme.Enterprise.Settings;

public class EnterpriseSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EnterpriseSettings.MySetting1));
    }
}
