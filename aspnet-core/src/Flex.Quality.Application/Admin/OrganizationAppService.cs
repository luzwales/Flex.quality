using Lion.AbpPro.BasicManagement.OrganizationUnits.Dto;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.ObjectMapping;

namespace Flex.Quality.Admin;

[Dependency(ServiceLifetime.Singleton)]
public class OrganizationAppService(
    IRepository<OrganizationUnit, Guid> organizationUnitRepository,
    IObjectMapper objectMapper,
    IRepository<IdentityUser, Guid> userRepository,
    IRepository<IdentityUserOrganizationUnit> userOrgRepository,
    IOrganizationAppService organizationAppServiceImplementation)
    : IOrganizationAppService
{
    private IOrganizationAppService _organizationAppServiceImplementation { get; set; }

    public async Task<List<OrganizationUnitDto>> GetAllChildrenRecursiveAsync(Guid parentId)
    {
        var result = new List<OrganizationUnitDto>();
        await GetChildrenRecursiveAsync(parentId, result);
        return result;
    }


    public async Task<OrganizationUnitDto> GetOrganizationUnitByUserAsync(string userName)
    {
        var userId = userRepository.FirstOrDefaultAsync(x => x.Name == userName).Result?.Id;
        var orgUser = userOrgRepository.FirstOrDefaultAsync(x => x.UserId == userId);

        var orgUserId = orgUser.Result?.OrganizationUnitId;
        var organizationUnit =
            await organizationUnitRepository.FirstOrDefaultAsync(x => x.Id == orgUserId);
        if (organizationUnit == null) throw new Exception("OrganizationUnit not found for the user.");

        return objectMapper.Map<OrganizationUnit, OrganizationUnitDto>(organizationUnit);
    }

    public async Task<OrganizationUnitDto> GetOrganizationUnitByUserAsync(Guid userId)
    {
        var user = await userRepository.GetAsync(userId);
        var orgUserId =
            userOrgRepository.FirstOrDefaultAsync(x => x.UserId == userId).Result?.OrganizationUnitId;
        var organizationUnit =
            await organizationUnitRepository.FirstOrDefaultAsync(x => x.Id == orgUserId);

        if (organizationUnit == null) throw new Exception("OrganizationUnit not found for the user.");

        return objectMapper.Map<OrganizationUnit, OrganizationUnitDto>(organizationUnit);
    }

    private async Task GetChildrenRecursiveAsync(Guid parentId, List<OrganizationUnitDto> result)
    {
        var children = await organizationUnitRepository.GetListAsync(x => x.ParentId == parentId);
        foreach (var child in children)
        {
            var childDto = objectMapper.Map<OrganizationUnit, OrganizationUnitDto>(child);
            result.Add(childDto);
            await GetChildrenRecursiveAsync(child.Id, result);
        }
    }
}