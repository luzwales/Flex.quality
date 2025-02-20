// using Flex.Quality.DataTypes;
// using Flex.Quality.DataTypes.Dto;
//
// namespace Flex.Quality.Controllers;
//
// [Route("DataTypes")]
// public class DataTypeController : QualityController, IDataTypeAppService
// {
//     private readonly IDataTypeAppService _dataTypeAppService;
//
//     public DataTypeController(IDataTypeAppService dataTypeAppService)
//     {
//         _dataTypeAppService = dataTypeAppService;
//     }
//     
//     [HttpPost("List")]
//     [SwaggerOperation(summary: "获取类型", Tags = new[] { "DataTypes" })]
//     public Task<List<DataTypeDto>> ListAsync(GetDataTypeInput input)
//     {
//         return _dataTypeAppService.ListAsync(input);
//     }
// }

