﻿using System.ComponentModel.DataAnnotations;

namespace Flex.Quality.EntityModels.Dto;

public class CreateAggregateInput
{
    public Guid ProjectId { get; set; }

    /// <summary>
    /// 编码
    /// </summary>
    [Required(ErrorMessage = "编码不能为空")]
    public string Code { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    [Required(ErrorMessage = "描述不能为空")]
    public string Description { get; set; }
}