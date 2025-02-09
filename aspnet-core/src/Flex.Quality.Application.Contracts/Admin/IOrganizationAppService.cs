using Lion.AbpPro.BasicManagement.OrganizationUnits.Dto;

namespace Flex.Quality.Admin;

public interface IOrganizationAppService
{
    // 其他方法声明...

    Task<List<OrganizationUnitDto>> GetAllChildrenRecursiveAsync(Guid parentId);
}