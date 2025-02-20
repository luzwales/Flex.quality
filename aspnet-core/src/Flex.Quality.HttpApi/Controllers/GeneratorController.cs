// using System.Net;
// using Flex.Quality.Generators;
// using Flex.Quality.Generators.Dto;
// using Flex.Quality.Templates;
//
// namespace Flex.Quality.Controllers;
//
// [Route("Generator")]
// public class GeneratorController : QualityController, IGeneratorAppService
// {
//     private readonly IGeneratorAppService _generatorAppService;
//
//     public GeneratorController(IGeneratorAppService generatorAppService)
//     {
//         _generatorAppService = generatorAppService;
//     }
//
//     [HttpPost("PreViewCode")]
//     [SwaggerOperation(summary: "预览", Tags = new[] { "Generator" })]
//     public Task<List<TemplateTreeDto>> PreViewCodeAsync(PreViewCodeInput input)
//     {
//         return _generatorAppService.PreViewCodeAsync(input);
//     }
//
//     [HttpPost("Down")]
//     [SwaggerOperation(summary: "下载", Tags = new[] { "Generator" })]
//     [ProducesResponseType(typeof(FileContentResult), (int)HttpStatusCode.OK)]
//     public Task<ActionResult> DownCodeAsync(DownCodeInput input)
//     {
//         return _generatorAppService.DownCodeAsync(input);
//     }
// }

