using Flex.Quality.EnumTypes.Dto;
using Volo.Abp.Application.Dtos;

namespace Flex.Quality.EnumTypes;

public interface IEnumTypeAppService : IApplicationService
{
    Task<PagedResultDto<PageEnumTypeOutput>> PageAsync(PageEnumTypeInput input);

    Task<PagedResultDto<PageEnumTypePropertyOutput>> PagePropertyAsync(PageEnumTypePropertyInput input);
    Task CreateEnumTypeAsync(CreateEnumTypeInput input);


    Task UpdateEnumTypeAsync(UpdateEnumTypeInput input);


    Task DeleteEnumTypeAsync(DeleteEnumTypeInput input);


    Task CreateEnumTypePropertyAsync(CreateEnumTypePropertyInput input);


    Task UpdateEnumTypePropertyAsync(UpdateEnumTypePropertyInput input);


    Task DeleteEnumTypePropertyAsync(DeleteEnumTypePropertyInput input);
}