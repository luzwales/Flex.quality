using Lion.AbpPro.Core;

namespace Flex.Quality.EnumTypes.Dto;

public class PageEnumTypePropertyInput : PagingBase
{
    public Guid Id { get; set; }

    public string Filter { get; set; }
}