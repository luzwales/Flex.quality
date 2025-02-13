using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.PermissionManagement;

namespace Flex.Quality.Admin;

[Dependency(ServiceLifetime.Singleton)]
public class PermissionAppService : IRemoteService
{
    /// <summary>
    ///     授权管理器
    /// </summary>
    public IPermissionManager permissionManager { set; get; }

    /// <summary>
    ///     给部门授权
    /// </summary>
    /// <param name="Organization"> 3a0cd7eb-38d3-b3c8-927c-cbe3c24677d3</param>
    /// <param name="permissionName">UserInset </param>
    /// <returns></returns>
    public async Task GrantPermissionForOrganizationAsync(string Organization, string permissionName)
    {
        await permissionManager.SetAsync(permissionName, "O", Organization, true);
    }

    /// <summary>
    ///     给部门授权(批量)
    /// </summary>
    /// <param name="Organization"> 3a0cd7eb-38d3-b3c8-927c-cbe3c24677d3</param>
    /// <param name="permissionNames">UserInset </param>
    /// <returns></returns>
    public async Task GrantPermissionsForOrganizationAsync(string Organization, List<string> permissionNames)
    {
        foreach (var permissionName in permissionNames)
            await permissionManager.SetAsync(permissionName, "O", Organization, true);
    }
}