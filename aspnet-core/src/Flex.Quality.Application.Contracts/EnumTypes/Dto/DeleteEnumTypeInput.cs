﻿namespace Flex.Quality.EnumTypes.Dto;

public class DeleteEnumTypeInput
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }

    public Guid EntityModelId { get; set; }
}