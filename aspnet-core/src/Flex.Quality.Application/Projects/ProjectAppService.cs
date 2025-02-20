// using Lion.AbpPro.CodeManagement.Projects;
// using Lion.AbpPro.CodeManagement.Projects.Dto;
// using Volo.Abp.Application.Dtos;
//
// namespace Flex.Quality.Projects;
//
// public class ProjectAppService(ProjectManager projectManager) : QualityAppService, IProjectAppService
// {
//     public async Task<List<ProjectDto>> AllAsync()
//     {
//         return await projectManager.GetListAsync(maxResultCount: int.MaxValue);
//     }
//
//     public async Task<PagedResultDto<ProjectDto>> PageAsync(PageProjectInput input)
//     {
//         var result = new PagedResultDto<ProjectDto>();
//         var totalCount = await projectManager.GetCountAsync(input.Filter);
//         result.TotalCount = totalCount;
//         if (totalCount <= 0) return result;
//
//         var list = await projectManager.GetListAsync(input.Filter, input.PageSize,
//             input.SkipCount, false);
//         result.Items = list;
//
//         return result;
//     }
//
//     public Task CreateAsync(CreateProjectInput input)
//     {
//         return projectManager.CreateAsync(input.Name, input.CompanyName, input.ProjectName, input.Owner, input.Remark);
//     }
//
//     public Task UpdateAsync(UpdateProjectInput input)
//     {
//         return projectManager.UpdateAsync(input.Id, input.Name, input.CompanyName,input.ProjectName, input.Owner, input.Remark);
//     }
//
//     public Task DeleteAsync(DeleteProjectInput input)
//     {
//         return projectManager.DeleteAsync(input.Id);
//     }
// }

