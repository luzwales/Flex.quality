using Lion.AbpPro.BasicManagement.OrganizationUnits.Dto;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.ObjectMapping;

namespace Flex.Quality.Admin;

[Dependency(ServiceLifetime.Singleton)]
public class OrganizationAppService(
    IRepository<OrganizationUnit, Guid> organizationUnitRepository,
    IObjectMapper objectMapper,
    IRepository<Users, Guid> userRepository,
    IOrganizationAppService organizationAppServiceImplementation)
    : IOrganizationAppService, IRemoteService
{
    private IOrganizationAppService _organizationAppServiceImplementation { get; set; }

    public async Task<List<OrganizationUnitDto>> GetAllChildrenRecursiveAsync(Guid parentId)
    {
        var result = new List<OrganizationUnitDto>();
        await GetChildrenRecursiveAsync(parentId, result);
        return result;
    }

    public async Task<OrganizationUnitDto> GetOrganizationUnitByUserAsync(Guid userId)
    {
        var user = await userRepository.GetAsync(userId);
        var organizationUnit =
            await organizationUnitRepository.FirstOrDefaultAsync(x => x.Id == user.OrganizationUnitId);

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