namespace Flex.Quality.Permissions;

public class OrganizationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        // 1、定义权限组
        var permissionGroupDefinition =
            context.AddGroup(OrganizationPermissions.GroupName, L(OrganizationPermissions.GroupName));


        // 1、定义一级权限
        var permissionDefinition_RQA = permissionGroupDefinition.AddPermission("RQA", L("RQA"));
        var permissionDefinition_Program =
            permissionGroupDefinition.AddPermission("Program", L("Program"));
        var permissionDefinition_ME = permissionGroupDefinition.AddPermission("ME", L("ME"));
        var permissionDefinition_TE = permissionGroupDefinition.AddPermission("TE", L("TE"));
        var permissionDefinition_Material =
            permissionGroupDefinition.AddPermission("Material", L("Material"));

        // 2、定义二级权限
        // PermissionDefinition permissionDefinition_Inset = permissionDefinition_Quality.AddChild(QualityPermissions.GroupName+".Inset");
        // PermissionDefinition permissionDefinition_Edit = permissionDefinition_Quality.AddChild(QualityPermissions.GroupName+".Edit");
        // PermissionDefinition permissionDefinition_View = permissionDefinition_Quality.AddChild(QualityPermissions.GroupName+".View");
        // PermissionDefinition permissionDefinition_Delete = permissionDefinition_Quality.AddChild(QualityPermissions.GroupName+".Delete");
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OrganizationResource>(name);
    }
}