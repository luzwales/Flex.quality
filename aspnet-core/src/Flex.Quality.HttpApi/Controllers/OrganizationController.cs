using Flex.Quality.Admin;
using Lion.AbpPro.BasicManagement.OrganizationUnits.Dto;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.DependencyInjection;
using PermissionAppService = Flex.Quality.Admin.PermissionAppService;

namespace Flex.Quality.Controllers;

[ApiController]
[Route("api/organization")]
[Authorize(Roles = "admin")]
public class OrganizationController(
    IOrganizationAppService organizationAppService,
    PermissionAppService permissionAppService)
    : AbpController, ITransientDependency
{
    [HttpGet("get-all-children-org/{parentId}")]
    public async Task<List<OrganizationUnitDto>> GetAllChildrenRecursiveAsync(Guid parentId)
    {
        return await organizationAppService.GetAllChildrenRecursiveAsync(parentId);
    }

    [HttpPut("grant-permissions-for-department")]
    public async Task GrantPermissionsForUserAsync(string organization, List<string> permissionNames)
    {
        await permissionAppService.GrantPermissionsForOrganizationAsync(organization, permissionNames);
    }
}