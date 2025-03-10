﻿using Lion.AbpPro.Core;

namespace Flex.Quality.EntityModels.Dto;

public class PageEntityModelInput : PagingBase
{
    public Guid Id { get; set; }

    public string Filter { get; set; }
}