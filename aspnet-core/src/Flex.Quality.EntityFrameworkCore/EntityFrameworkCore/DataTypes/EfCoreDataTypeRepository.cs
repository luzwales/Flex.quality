// using Flex.Quality.DataTypes;
// using Flex.Quality.DataTypes.Aggregates;
// using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
//
// namespace Flex.Quality.EntityFrameworkCore.DataTypes
// {
//     /// <summary>
//     /// 数据类型 仓储Ef core 实现
//     /// </summary>
//     public class EfCoreDataTypeRepository :
//         EfCoreRepository<IQualityDbContext, DataType, Guid>,
//         IDataTypeRepository
//     {
//         public EfCoreDataTypeRepository(IDbContextProvider<IQualityDbContext> dbContextProvider) : base(dbContextProvider)
//         {
//         }
//
//         public async Task<DataType> FindByCodeAsync(string code)
//         {
//             return await (await GetDbSetAsync())
//                 .FirstOrDefaultAsync(t => t.Code == code);
//         }
//     }
// }

