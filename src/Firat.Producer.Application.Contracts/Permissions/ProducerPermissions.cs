using Volo.Abp.Reflection;

namespace Firat.Producer.Permissions;

public class ProducerPermissions
{
    public const string GroupName = "Producer";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProducerPermissions));
    }
}
