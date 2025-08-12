using Acme.Enterprise.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.Enterprise.Permissions;

public class EnterprisePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EnterprisePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EnterprisePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EnterpriseResource>(name);
    }
}
