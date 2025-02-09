using Volo.Abp.Guids;
using Volo.Abp.MultiTenancy;
using Volo.Abp.PermissionManagement;

namespace Flex.Quality.Permissions;

public class UserOrganizationPermissionManagementProvider : PermissionManagementProvider
{
    /// <summary>
    ///     用户部门 权限管理(提供用户授权)
    /// </summary>
    public UserOrganizationPermissionManagementProvider(IPermissionGrantRepository permissionGrantRepository,
                                                        IGuidGenerator guidGenerator,
                                                        ICurrentTenant currentTenant) : base(
        permissionGrantRepository, guidGenerator, currentTenant)
    {
    }

    // 提供者名称 自定义
    public override string Name { get; } = "O";
}