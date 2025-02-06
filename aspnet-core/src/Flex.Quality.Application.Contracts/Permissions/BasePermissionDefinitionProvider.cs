namespace Flex.Quality.Permissions;

public class BasePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        // 1、定义权限组
        var permissionGroupDefinition =
            context.AddGroup(BasePermissions.GroupName, L(BasePermissions.GroupName));

        // 1、定义一级权限

        var permissionDefinition_Inset = permissionGroupDefinition.AddPermission("Inset", L("Inset"));
        var permissionDefinition_Edit = permissionGroupDefinition.AddPermission("Edit", L("Edit"));
        var permissionDefinition_Update =
            permissionGroupDefinition.AddPermission("Update", L("Update"));
        var permissionDefinition_Query = permissionGroupDefinition.AddPermission("Query", L("Query"));

        // 2、定义二级权限
        // PermissionDefinition permissionDefinition_Inset = permissionDefinition_Quality.AddChild(QualityPermissions.GroupName+".Inset");
        // PermissionDefinition permissionDefinition_Edit = permissionDefinition_Quality.AddChild(QualityPermissions.GroupName+".Edit");
        // PermissionDefinition permissionDefinition_View = permissionDefinition_Quality.AddChild(QualityPermissions.GroupName+".View");
        // PermissionDefinition permissionDefinition_Delete = permissionDefinition_Quality.AddChild(QualityPermissions.GroupName+".Delete");
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BaseResource>(name);
    }
}