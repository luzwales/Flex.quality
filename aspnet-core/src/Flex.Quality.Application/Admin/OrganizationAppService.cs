using Lion.AbpPro.BasicManagement.OrganizationUnits.Dto;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.ObjectMapping;

namespace Flex.Quality.Admin;

[Dependency(ServiceLifetime.Singleton)]
public class OrganizationAppService(
    IRepository<OrganizationUnit, Guid> organizationUnitRepository,
    IObjectMapper objectMapper)
    : IOrganizationAppService
{
    public async Task<List<OrganizationUnitDto>> GetAllChildrenRecursiveAsync(Guid parentId)
    {
        var result = new List<OrganizationUnitDto>();
        await GetChildrenRecursiveAsync(parentId, result);
        return result;
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