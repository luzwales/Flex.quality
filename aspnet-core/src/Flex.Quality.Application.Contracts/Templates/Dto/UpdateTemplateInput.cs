﻿namespace Flex.Quality.Templates.Dto;

public class UpdateTemplateInput
{
    public Guid Id { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; set; }
}