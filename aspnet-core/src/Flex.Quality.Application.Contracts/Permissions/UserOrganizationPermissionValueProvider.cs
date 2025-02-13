using Flex.Quality.Admin;
using Flex.Quality.EntityFrameworkCore;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.Security.Claims;

namespace Flex.Quality.Permissions;

public class UserOrganizationPermissionValueProvider(
    [NotNull] IPermissionStore permissionStore,
    IOrganizationAppService organizationAppService,
    QualityDbContext dbContext)
    : PermissionValueProvider(permissionStore)
{
    public override string Name { get; } = "O";

    public override async Task<PermissionGrantResult> CheckAsync(PermissionValueCheckContext context)
    {
        // 1、获取用户邮箱
        var name = context.Principal?.FindFirst(AbpClaimTypes.Name)?.Value;
        var user = dbContext.Users.Include(identityUser => identityUser.OrganizationUnits)
            .FirstOrDefault(x => x.UserName == name);
        var organization = user?.OrganizationUnits.FirstOrDefault()?.OrganizationUnitId;
        var userOrganization = organizationAppService.GetOrganizationUnitByUserAsync(name);

        if (user == null)
            // 2、返回授权失败
            return await Task.FromResult(PermissionGrantResult.Undefined);

        // 3、根据邮箱查询UsermManage权限
        // 1、获取的是接口权限。
        // 2、UserEamil
        // 3、具体邮箱
        // 核心鉴权：查询授权数据库是否有权限。
        var flag = await PermissionStore.IsGrantedAsync(context.Permission.Name, Name,
                                                        userOrganization.Result.DisplayName);

        return await Task.FromResult(flag
                                         ? PermissionGrantResult.Granted
                                         : PermissionGrantResult.Undefined);
    }

    public override async Task<MultiplePermissionGrantResult> CheckAsync(PermissionValuesCheckContext context)
    {
        var permissionNames = context.Permissions.Select(x => x.Name).Distinct().ToArray();
        Check.NotNullOrEmpty(permissionNames, nameof(permissionNames));

        var Email = context.Principal?.FindFirst(AbpClaimTypes.Email)?.Value;
        if (Email == null) return new MultiplePermissionGrantResult(permissionNames);

        return await PermissionStore.IsGrantedAsync(permissionNames, Name, Email);
    }
}