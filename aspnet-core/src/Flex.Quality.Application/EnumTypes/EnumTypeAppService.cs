// using Flex.Quality.EntityModels;
// using Flex.Quality.EnumTypes.Dto;
// using Volo.Abp;
// using Volo.Abp.Application.Dtos;
//
// namespace Flex.Quality.EnumTypes;
//
// public class EnumTypeAppService(EnumTypeManager enumTypeManager, EntityModelManager entityModelManager)
//     : QualityAppService, IEnumTypeAppService
// {
//     public async Task<PagedResultDto<PageEnumTypeOutput>> PageAsync(PageEnumTypeInput input)
//     {
//         var result = new PagedResultDto<PageEnumTypeOutput>();
//         var list = await enumTypeManager.ListAsync(input.Id, input.Filter);
//         result.TotalCount = list.Count;
//         result.Items = ObjectMapper.Map<List<EnumTypeDto>, List<PageEnumTypeOutput>>(list);
//         return result;
//     }
//
//     public async Task<PagedResultDto<PageEnumTypePropertyOutput>> PagePropertyAsync(PageEnumTypePropertyInput input)
//     {
//         var entity = await enumTypeManager.FindAsync(input.Id);
//         if (entity == null) return new PagedResultDto<PageEnumTypePropertyOutput>();
//         var result = new PagedResultDto<PageEnumTypePropertyOutput>
//         {
//             TotalCount = entity.EnumTypeProperties.Count
//         };
//         var properties = entity.EnumTypeProperties.WhereIf(
//                 input.Filter.IsNotNullOrWhiteSpace(),
//                 e => e.Code.Contains(input.Filter) || e.Description.Contains(input.Filter))
//             .OrderByDescending(e => e.CreationTime)
//             .Skip(input.SkipCount)
//             .Take(input.PageSize)
//             .ToList();
//         result.Items = ObjectMapper.Map<List<EnumTypePropertyDto>, List<PageEnumTypePropertyOutput>>(properties);
//         return result;
//     }
//
//
//     public Task CreateEnumTypeAsync(CreateEnumTypeInput input)
//     {
//         return enumTypeManager.CreateAsync(input.Code, input.Description, input.EntityModelId, input.ProjectId);
//     }
//
//     public Task UpdateEnumTypeAsync(UpdateEnumTypeInput input)
//     {
//         return enumTypeManager.UpdateAsync(input.Id, input.Code, input.Description);
//     }
//
//     public async Task DeleteEnumTypeAsync(DeleteEnumTypeInput input)
//     {
//         await enumTypeManager.DeleteAsync(input.Id);
//         var entity = await entityModelManager.FindAsync(input.EntityModelId);
//         if (entity != null)
//         {
//             if (entity.EntityModelProperties.Any(e => e.EnumTypeId == input.Id))
//             {
//                 throw new UserFriendlyException($"{entity}正在使用该枚举,不能删除");
//             }
//         }
//     }
//
//     public Task CreateEnumTypePropertyAsync(CreateEnumTypePropertyInput input)
//     {
//         return enumTypeManager.CreatePropertyAsync(input.Code, input.Value, input.Description, input.EnumTypeId);
//     }
//
//     public Task UpdateEnumTypePropertyAsync(UpdateEnumTypePropertyInput input)
//     {
//         return enumTypeManager.UpdatePropertyAsync(input.Id, input.Code, input.Value, input.Description, input.EnumTypeId);
//     }
//
//     public Task DeleteEnumTypePropertyAsync(DeleteEnumTypePropertyInput input)
//     {
//         return enumTypeManager.DeletePropertyAsync(input.EnumTypeId, input.Id);
//     }
// }

