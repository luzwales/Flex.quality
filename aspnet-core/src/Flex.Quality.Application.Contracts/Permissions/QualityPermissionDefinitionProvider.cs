namespace Flex.Quality.Permissions;

public class QualityPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<QualityResource>(name);
    }
}