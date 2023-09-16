using Firat.Producer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Firat.Producer.Permissions;

public class ProducerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProducerPermissions.GroupName, L("Permission:Producer"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProducerResource>(name);
    }
}
