﻿using System.ComponentModel;

namespace Flex.Quality.Templates;

public enum TemplateType
{
    [Description("文件夹")] Folder = 10,
    [Description("文件")]  File   = 20
}