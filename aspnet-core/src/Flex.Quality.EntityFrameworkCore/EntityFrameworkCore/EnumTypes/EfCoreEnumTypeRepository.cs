// using System;
// using System.Collections.Generic;
// using System.Threading;
// using System.Threading.Tasks;
// using Volo.Abp.Domain.Repositories;
// using Flex.Quality.EnumTypes;
// using Flex.Quality.EnumTypes.Aggregates;
// using Flex.Quality.Projects.Aggregates;
// using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
//
// namespace Flex.Quality.EntityFrameworkCore.EnumTypes
// {
//     /// <summary>
//     /// 枚举 仓储Ef core 实现
//     /// </summary>
//     public class EfCoreEnumTypeRepository :
//         EfCoreRepository<IQualityDbContext, EnumType, Guid>,
//         IEnumTypeRepository
//     {
//         public EfCoreEnumTypeRepository(IDbContextProvider<IQualityDbContext> dbContextProvider) : base(dbContextProvider)
//         {
//         }
//
//         public async Task<List<EnumType>> ListAsync(Guid entityModelId, string filter = null, bool includeDetail = true)
//         {
//             return await (await GetDbSetAsync())
//                 .IncludeDetails(includeDetail)
//                 .WhereIf(filter.IsNotNullOrWhiteSpace(), e => e.Code.Contains(filter) || e.Description.Contains(filter))
//                 .Where(e => e.EntityModelId == entityModelId)
//                 .ToListAsync();
//         }
//
//         public async Task<List<EnumType>> ListByProjectIdAsync(Guid projectId, string filter = null, bool includeDetail = true)
//         {
//             return await (await GetDbSetAsync())
//                 .IncludeDetails(includeDetail)
//                 .WhereIf(filter.IsNotNullOrWhiteSpace(), e => e.Code.Contains(filter) || e.Description.Contains(filter))
//                 .Where(e => e.ProjectId == projectId)
//                 .ToListAsync();
//         }
//
//         public async Task<EnumType> FindAsync(string code, bool includeDetail = true)
//         {
//             return await (await GetDbSetAsync())
//                 .IncludeDetails(includeDetail)
//                 .FirstOrDefaultAsync(e => e.Code == code);
//         }
//
//         public async Task<EnumType> FindAsync(string code, Guid entityModelId, bool includeDetail = true)
//         {
//             return await (await GetDbSetAsync())
//                 .IncludeDetails(includeDetail)
//                 .FirstOrDefaultAsync(e => e.Code == code && e.EntityModelId == entityModelId);
//         }
//
//         public async Task<EnumType> FindByCodeExcludeIdAsync(string code, Guid id, bool includeDetail = true)
//         {
//             return await (await GetDbSetAsync())
//                 .IncludeDetails(includeDetail)
//                 .Where(e => e.Code == code)
//                 .Where(e => e.Id != id)
//                 .FirstOrDefaultAsync();
//         }
//
//         public override async Task<IQueryable<EnumType>> WithDetailsAsync()
//         {
//             return (await GetQueryableAsync()).IncludeDetails();
//         }
//     }
// }

