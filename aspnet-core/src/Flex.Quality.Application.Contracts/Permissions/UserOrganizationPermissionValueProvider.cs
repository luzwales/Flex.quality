using JetBrains.Annotations;

namespace Flex.Quality.Permissions;

public class UserOrganizationPermissionValueProvider([NotNull] IPermissionStore permissionStore)
    : PermissionValueProvider(permissionStore)
{
    public override string Name { get; } = "O";

    public override Task<PermissionGrantResult> CheckAsync(PermissionValueCheckContext context)
    {
        throw new NotImplementedException();
    }

    public override Task<MultiplePermissionGrantResult> CheckAsync(PermissionValuesCheckContext context)
    {
        throw new NotImplementedException();
    }
}