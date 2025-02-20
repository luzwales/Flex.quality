// using Flex.Quality.DataTypes.Dto;
// using Flex.Quality.EnumTypes;
// using Flex.Quality.EnumTypes.Dto;
//
// namespace Flex.Quality.DataTypes;
//
// public class DataTypeAppService(DataTypeManager dataTypeManager, EnumTypeManager enumTypeManager)
//     : QualityAppService, IDataTypeAppService
// {
//     private          IDataTypeAppService _dataTypeAppServiceImplementation;
//
//     public async Task<List<DataTypeDto>> ListAsync(GetDataTypeInput input)
//     {
//         List<EnumTypeDto> enumList = await enumTypeManager.ListAsync(input.EntityModelId);
//         var dataTypeList = await dataTypeManager.ListAsync();
//         var result = new List<DataTypeDto>();
//         result.AddRange((IEnumerable<DataTypeDto>)dataTypeList);
//         result.AddRange(ObjectMapper.Map<List<EnumTypeDto>, List<DataTypeDto>>(enumList));
//         return result;
//     }
// }

