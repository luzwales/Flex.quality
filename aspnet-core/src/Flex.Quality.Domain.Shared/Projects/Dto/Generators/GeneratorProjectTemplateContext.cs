namespace Flex.Quality.Projects.Dto.Generators;

public class GeneratorProjectTemplateContext
{
    public GeneratorProjectTemplateContext()
    {
        TreeEntityModels = new List<GeneratorTreeEntityModelContext>();
    }

    public GeneratorProjectContext Project { get; set; }

    public List<GeneratorTreeEntityModelContext> TreeEntityModels { get; set; }

    public List<GeneratorEntityModelContext> EntityModels { get; set; }
}