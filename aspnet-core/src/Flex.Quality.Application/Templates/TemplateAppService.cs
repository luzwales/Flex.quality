// using AutoMapper.Internal.Mappers;
// using Lion.AbpPro.CodeManagement.Templates.Dto;
// using Volo.Abp.Application.Dtos;
//
// namespace Flex.Quality.Templates;
//
// public class TemplateAppService(TemplateManager templateManager) : QualityAppService, ITemplateAppService
// {
//     private ITemplateAppService _templateAppServiceImplementation;
//
//     public async Task<List<TemplateDto>> AllAsync()
//     {
//         return await templateManager.GetListAsync(maxResultCount: int.MaxValue);
//     }
//
//     public async Task<PagedResultDto<TemplateDto>> PageAsync(PageTemplateInput input)
//     {
//         var result = new PagedResultDto<TemplateDto>();
//         var totalCount = await templateManager.GetCountAsync(input.Filter);
//         result.TotalCount = totalCount;
//         if (totalCount <= 0) return result;
//
//         var list = await templateManager.GetListAsync(input.Filter, input.PageSize,
//             input.SkipCount, false);
//         result.Items = list;
//
//         return result;
//     }
//
//     public async Task<List<TemplateDto>> ListAsync()
//     {
//         var list = await templateManager.GetListAsync(null, Int32.MaxValue, 0, false);
//         return list;
//     }
//
//     public Task CreateAsync(CreateTemplateInput input)
//     {
//         return templateManager.CreateAsync(input.Name, input.Remark);
//     }
//
//     public Task UpdateAsync(UpdateTemplateInput input)
//     {
//         return templateManager.UpdateAsync(input.Id, input.Name, input.Remark);
//     }
//
//     public Task DeleteAsync(DeleteTemplateInput input)
//     {
//         return templateManager.DeleteAsync(input.Id);
//     }
//
//     public Task CreateDetailAsync(CreateTemplateDetailInput input)
//     {
//         return templateManager.CreateDetailAsync(input.TemplateId, input.TemplateType, input.ControlType, input.Name, input.Description, input.Content, input.ParentId);
//     }
//
//
//     public Task UpdateDetailAsync(UpdateTemplateDetailInput input)
//     {
//         return templateManager.UpdateDetailAsync(input.TemplateId, input.TemplateDetailId, input.Name, input.Description, input.ControlType);
//     }
//
//     public Task UpdateDetailAsync(UpdateTemplateDetailContentInput input)
//     {
//         return templateManager.UpdateDetailAsync(input.TemplateId, input.TemplateDetailId, input.Content);
//     }
//
//
//     public Task DeleteDetailAsync(DeleteTemplateDetailInput input)
//     {
//         return templateManager.DeleteDetailAsync(input.TemplateId, input.TemplateDetailId);
//     }
//
//     public List<KeyValuePair<string, int>> GetControlTypeAsync()
//     {
//         return EnumExtensions.GetEntityStringIntKeyValueList<ControlType>();
//     }
//
//     public List<KeyValuePair<string, int>> GetTemplateTypeAsync()
//     {
//         return EnumExtensions.GetEntityStringIntKeyValueList<TemplateType>();
//     }
//
//     public Task CopyTemplateAsync(CopyTemplateInput input)
//     {
//         return templateManager.CopyAsync(input.Id, input.Name, input.Remark);
//     }
//
//     public async Task<List<GetTemplateTreeOutput>> TemplateTreeAsync(GetTemplteTreeInput input)
//     {
//         var result = await templateManager.TemplateTreeAsync(input.TemplateId);
//         return ObjectMapper<,>.Map<List<TemplateTreeDto>, List<GetTemplateTreeOutput>>(result);
//     }
// }

