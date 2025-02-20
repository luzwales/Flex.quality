using Lion.AbpPro.Core;

namespace Flex.Quality.Templates.Dto;

public class PageTemplateInput : PagingBase
{
    public string Filter { get; set; }
}