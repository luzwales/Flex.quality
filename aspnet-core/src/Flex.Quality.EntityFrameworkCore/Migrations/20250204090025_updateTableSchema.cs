using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flex.Quality.Migrations
{
    /// <inheritdoc />
    public partial class updateTableSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnitRoles_AbpOrganizationUnits_OrganizationUnitId",
                table: "AbpOrganizationUnitRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnitRoles_AbpRoles_RoleId",
                table: "AbpOrganizationUnitRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenantConnectionStrings_AbpTenants_TenantId",
                table: "AbpTenantConnectionStrings");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserClaims_AbpUsers_UserId",
                table: "AbpUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserLogins_AbpUsers_UserId",
                table: "AbpUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserOrganizationUnits_AbpOrganizationUnits_OrganizationUnitId",
                table: "AbpUserOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserOrganizationUnits_AbpUsers_UserId",
                table: "AbpUserOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserRoles_AbpRoles_RoleId",
                table: "AbpUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserRoles_AbpUsers_UserId",
                table: "AbpUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserTokens",
                table: "AbpUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUsers",
                table: "AbpUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserRoles",
                table: "AbpUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserOrganizationUnits",
                table: "AbpUserOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserLogins",
                table: "AbpUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserDelegations",
                table: "AbpUserDelegations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserClaims",
                table: "AbpUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTenants",
                table: "AbpTenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTenantConnectionStrings",
                table: "AbpTenantConnectionStrings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpSettings",
                table: "AbpSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpSettingDefinitions",
                table: "AbpSettingDefinitions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpSessions",
                table: "AbpSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpSecurityLogs",
                table: "AbpSecurityLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoleClaims",
                table: "AbpRoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpPermissions",
                table: "AbpPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpPermissionGroups",
                table: "AbpPermissionGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpPermissionGrants",
                table: "AbpPermissionGrants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpOrganizationUnitRoles",
                table: "AbpOrganizationUnitRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpLinkUsers",
                table: "AbpLinkUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpFeatureValues",
                table: "AbpFeatureValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpFeatures",
                table: "AbpFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpFeatureGroups",
                table: "AbpFeatureGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpClaimTypes",
                table: "AbpClaimTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpBackgroundJobs",
                table: "AbpBackgroundJobs");

            migrationBuilder.EnsureSchema(
                name: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpUserTokens",
                newName: "Abp_UserTokens",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpUsers",
                newName: "Abp_Users",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpUserRoles",
                newName: "Abp_UserRoles",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpUserOrganizationUnits",
                newName: "Abp_UserOrganizationUnits",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpUserLogins",
                newName: "Abp_UserLogins",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpUserDelegations",
                newName: "Abp_UserDelegations",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpUserClaims",
                newName: "Abp_UserClaims",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpTenants",
                newName: "Abp_Tenants",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpTenantConnectionStrings",
                newName: "Abp_TenantConnectionStrings",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpSettings",
                newName: "Abp_Settings",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpSettingDefinitions",
                newName: "Abp_SettingDefinitions",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpSessions",
                newName: "Abp_Sessions",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpSecurityLogs",
                newName: "Abp_SecurityLogs",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpRoles",
                newName: "Abp_Roles",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpRoleClaims",
                newName: "Abp_RoleClaims",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpPermissions",
                newName: "Abp_Permissions",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpPermissionGroups",
                newName: "Abp_PermissionGroups",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpPermissionGrants",
                newName: "Abp_PermissionGrants",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnits",
                newName: "Abp_OrganizationUnits",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnitRoles",
                newName: "Abp_OrganizationUnitRoles",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpLinkUsers",
                newName: "Abp_LinkUsers",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpFeatureValues",
                newName: "Abp_FeatureValues",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpFeatures",
                newName: "Abp_Features",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpFeatureGroups",
                newName: "Abp_FeatureGroups",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpClaimTypes",
                newName: "Abp_ClaimTypes",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpBackgroundJobs",
                newName: "Abp_BackgroundJobs",
                newSchema: "Qa");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_UserName",
                schema: "Qa",
                table: "Abp_Users",
                newName: "IX_Abp_Users_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_NormalizedUserName",
                schema: "Qa",
                table: "Abp_Users",
                newName: "IX_Abp_Users_NormalizedUserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_NormalizedEmail",
                schema: "Qa",
                table: "Abp_Users",
                newName: "IX_Abp_Users_NormalizedEmail");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_Email",
                schema: "Qa",
                table: "Abp_Users",
                newName: "IX_Abp_Users_Email");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_RoleId_UserId",
                schema: "Qa",
                table: "Abp_UserRoles",
                newName: "IX_Abp_UserRoles_RoleId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserOrganizationUnits_UserId_OrganizationUnitId",
                schema: "Qa",
                table: "Abp_UserOrganizationUnits",
                newName: "IX_Abp_UserOrganizationUnits_UserId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_LoginProvider_ProviderKey",
                schema: "Qa",
                table: "Abp_UserLogins",
                newName: "IX_Abp_UserLogins_LoginProvider_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserClaims_UserId",
                schema: "Qa",
                table: "Abp_UserClaims",
                newName: "IX_Abp_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_NormalizedName",
                schema: "Qa",
                table: "Abp_Tenants",
                newName: "IX_Abp_Tenants_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_Name",
                schema: "Qa",
                table: "Abp_Tenants",
                newName: "IX_Abp_Tenants_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSettings_Name_ProviderName_ProviderKey",
                schema: "Qa",
                table: "Abp_Settings",
                newName: "IX_Abp_Settings_Name_ProviderName_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSettingDefinitions_Name",
                schema: "Qa",
                table: "Abp_SettingDefinitions",
                newName: "IX_Abp_SettingDefinitions_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSessions_TenantId_UserId",
                schema: "Qa",
                table: "Abp_Sessions",
                newName: "IX_Abp_Sessions_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSessions_SessionId",
                schema: "Qa",
                table: "Abp_Sessions",
                newName: "IX_Abp_Sessions_SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSessions_Device",
                schema: "Qa",
                table: "Abp_Sessions",
                newName: "IX_Abp_Sessions_Device");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSecurityLogs_TenantId_UserId",
                schema: "Qa",
                table: "Abp_SecurityLogs",
                newName: "IX_Abp_SecurityLogs_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSecurityLogs_TenantId_Identity",
                schema: "Qa",
                table: "Abp_SecurityLogs",
                newName: "IX_Abp_SecurityLogs_TenantId_Identity");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSecurityLogs_TenantId_ApplicationName",
                schema: "Qa",
                table: "Abp_SecurityLogs",
                newName: "IX_Abp_SecurityLogs_TenantId_ApplicationName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSecurityLogs_TenantId_Action",
                schema: "Qa",
                table: "Abp_SecurityLogs",
                newName: "IX_Abp_SecurityLogs_TenantId_Action");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_NormalizedName",
                schema: "Qa",
                table: "Abp_Roles",
                newName: "IX_Abp_Roles_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoleClaims_RoleId",
                schema: "Qa",
                table: "Abp_RoleClaims",
                newName: "IX_Abp_RoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_Name",
                schema: "Qa",
                table: "Abp_Permissions",
                newName: "IX_Abp_Permissions_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_GroupName",
                schema: "Qa",
                table: "Abp_Permissions",
                newName: "IX_Abp_Permissions_GroupName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissionGroups_Name",
                schema: "Qa",
                table: "Abp_PermissionGroups",
                newName: "IX_Abp_PermissionGroups_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissionGrants_TenantId_Name_ProviderName_ProviderKey",
                schema: "Qa",
                table: "Abp_PermissionGrants",
                newName: "IX_Abp_PermissionGrants_TenantId_Name_ProviderName_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_ParentId",
                schema: "Qa",
                table: "Abp_OrganizationUnits",
                newName: "IX_Abp_OrganizationUnits_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_Code",
                schema: "Qa",
                table: "Abp_OrganizationUnits",
                newName: "IX_Abp_OrganizationUnits_Code");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnitRoles_RoleId_OrganizationUnitId",
                schema: "Qa",
                table: "Abp_OrganizationUnitRoles",
                newName: "IX_Abp_OrganizationUnitRoles_RoleId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpLinkUsers_SourceUserId_SourceTenantId_TargetUserId_TargetTenantId",
                schema: "Qa",
                table: "Abp_LinkUsers",
                newName: "IX_Abp_LinkUsers_SourceUserId_SourceTenantId_TargetUserId_TargetTenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpFeatureValues_Name_ProviderName_ProviderKey",
                schema: "Qa",
                table: "Abp_FeatureValues",
                newName: "IX_Abp_FeatureValues_Name_ProviderName_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_AbpFeatures_Name",
                schema: "Qa",
                table: "Abp_Features",
                newName: "IX_Abp_Features_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpFeatures_GroupName",
                schema: "Qa",
                table: "Abp_Features",
                newName: "IX_Abp_Features_GroupName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpFeatureGroups_Name",
                schema: "Qa",
                table: "Abp_FeatureGroups",
                newName: "IX_Abp_FeatureGroups_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime",
                schema: "Qa",
                table: "Abp_BackgroundJobs",
                newName: "IX_Abp_BackgroundJobs_IsAbandoned_NextTryTime");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_UserTokens",
                schema: "Qa",
                table: "Abp_UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_Users",
                schema: "Qa",
                table: "Abp_Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_UserRoles",
                schema: "Qa",
                table: "Abp_UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_UserOrganizationUnits",
                schema: "Qa",
                table: "Abp_UserOrganizationUnits",
                columns: new[] { "OrganizationUnitId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_UserLogins",
                schema: "Qa",
                table: "Abp_UserLogins",
                columns: new[] { "UserId", "LoginProvider" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_UserDelegations",
                schema: "Qa",
                table: "Abp_UserDelegations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_UserClaims",
                schema: "Qa",
                table: "Abp_UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_Tenants",
                schema: "Qa",
                table: "Abp_Tenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_TenantConnectionStrings",
                schema: "Qa",
                table: "Abp_TenantConnectionStrings",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_Settings",
                schema: "Qa",
                table: "Abp_Settings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_SettingDefinitions",
                schema: "Qa",
                table: "Abp_SettingDefinitions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_Sessions",
                schema: "Qa",
                table: "Abp_Sessions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_SecurityLogs",
                schema: "Qa",
                table: "Abp_SecurityLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_Roles",
                schema: "Qa",
                table: "Abp_Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_RoleClaims",
                schema: "Qa",
                table: "Abp_RoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_Permissions",
                schema: "Qa",
                table: "Abp_Permissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_PermissionGroups",
                schema: "Qa",
                table: "Abp_PermissionGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_PermissionGrants",
                schema: "Qa",
                table: "Abp_PermissionGrants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_OrganizationUnits",
                schema: "Qa",
                table: "Abp_OrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_OrganizationUnitRoles",
                schema: "Qa",
                table: "Abp_OrganizationUnitRoles",
                columns: new[] { "OrganizationUnitId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_LinkUsers",
                schema: "Qa",
                table: "Abp_LinkUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_FeatureValues",
                schema: "Qa",
                table: "Abp_FeatureValues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_Features",
                schema: "Qa",
                table: "Abp_Features",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_FeatureGroups",
                schema: "Qa",
                table: "Abp_FeatureGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_ClaimTypes",
                schema: "Qa",
                table: "Abp_ClaimTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_BackgroundJobs",
                schema: "Qa",
                table: "Abp_BackgroundJobs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_OrganizationUnitRoles_Abp_OrganizationUnits_OrganizationUnitId",
                schema: "Qa",
                table: "Abp_OrganizationUnitRoles",
                column: "OrganizationUnitId",
                principalSchema: "Qa",
                principalTable: "Abp_OrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_OrganizationUnitRoles_Abp_Roles_RoleId",
                schema: "Qa",
                table: "Abp_OrganizationUnitRoles",
                column: "RoleId",
                principalSchema: "Qa",
                principalTable: "Abp_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_OrganizationUnits_Abp_OrganizationUnits_ParentId",
                schema: "Qa",
                table: "Abp_OrganizationUnits",
                column: "ParentId",
                principalSchema: "Qa",
                principalTable: "Abp_OrganizationUnits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_RoleClaims_Abp_Roles_RoleId",
                schema: "Qa",
                table: "Abp_RoleClaims",
                column: "RoleId",
                principalSchema: "Qa",
                principalTable: "Abp_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_TenantConnectionStrings_Abp_Tenants_TenantId",
                schema: "Qa",
                table: "Abp_TenantConnectionStrings",
                column: "TenantId",
                principalSchema: "Qa",
                principalTable: "Abp_Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_UserClaims_Abp_Users_UserId",
                schema: "Qa",
                table: "Abp_UserClaims",
                column: "UserId",
                principalSchema: "Qa",
                principalTable: "Abp_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_UserLogins_Abp_Users_UserId",
                schema: "Qa",
                table: "Abp_UserLogins",
                column: "UserId",
                principalSchema: "Qa",
                principalTable: "Abp_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_UserOrganizationUnits_Abp_OrganizationUnits_OrganizationUnitId",
                schema: "Qa",
                table: "Abp_UserOrganizationUnits",
                column: "OrganizationUnitId",
                principalSchema: "Qa",
                principalTable: "Abp_OrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_UserOrganizationUnits_Abp_Users_UserId",
                schema: "Qa",
                table: "Abp_UserOrganizationUnits",
                column: "UserId",
                principalSchema: "Qa",
                principalTable: "Abp_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_UserRoles_Abp_Roles_RoleId",
                schema: "Qa",
                table: "Abp_UserRoles",
                column: "RoleId",
                principalSchema: "Qa",
                principalTable: "Abp_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_UserRoles_Abp_Users_UserId",
                schema: "Qa",
                table: "Abp_UserRoles",
                column: "UserId",
                principalSchema: "Qa",
                principalTable: "Abp_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_UserTokens_Abp_Users_UserId",
                schema: "Qa",
                table: "Abp_UserTokens",
                column: "UserId",
                principalSchema: "Qa",
                principalTable: "Abp_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abp_OrganizationUnitRoles_Abp_OrganizationUnits_OrganizationUnitId",
                schema: "Qa",
                table: "Abp_OrganizationUnitRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_OrganizationUnitRoles_Abp_Roles_RoleId",
                schema: "Qa",
                table: "Abp_OrganizationUnitRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_OrganizationUnits_Abp_OrganizationUnits_ParentId",
                schema: "Qa",
                table: "Abp_OrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_RoleClaims_Abp_Roles_RoleId",
                schema: "Qa",
                table: "Abp_RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_TenantConnectionStrings_Abp_Tenants_TenantId",
                schema: "Qa",
                table: "Abp_TenantConnectionStrings");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_UserClaims_Abp_Users_UserId",
                schema: "Qa",
                table: "Abp_UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_UserLogins_Abp_Users_UserId",
                schema: "Qa",
                table: "Abp_UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_UserOrganizationUnits_Abp_OrganizationUnits_OrganizationUnitId",
                schema: "Qa",
                table: "Abp_UserOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_UserOrganizationUnits_Abp_Users_UserId",
                schema: "Qa",
                table: "Abp_UserOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_UserRoles_Abp_Roles_RoleId",
                schema: "Qa",
                table: "Abp_UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_UserRoles_Abp_Users_UserId",
                schema: "Qa",
                table: "Abp_UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_UserTokens_Abp_Users_UserId",
                schema: "Qa",
                table: "Abp_UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_UserTokens",
                schema: "Qa",
                table: "Abp_UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_Users",
                schema: "Qa",
                table: "Abp_Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_UserRoles",
                schema: "Qa",
                table: "Abp_UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_UserOrganizationUnits",
                schema: "Qa",
                table: "Abp_UserOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_UserLogins",
                schema: "Qa",
                table: "Abp_UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_UserDelegations",
                schema: "Qa",
                table: "Abp_UserDelegations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_UserClaims",
                schema: "Qa",
                table: "Abp_UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_Tenants",
                schema: "Qa",
                table: "Abp_Tenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_TenantConnectionStrings",
                schema: "Qa",
                table: "Abp_TenantConnectionStrings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_Settings",
                schema: "Qa",
                table: "Abp_Settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_SettingDefinitions",
                schema: "Qa",
                table: "Abp_SettingDefinitions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_Sessions",
                schema: "Qa",
                table: "Abp_Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_SecurityLogs",
                schema: "Qa",
                table: "Abp_SecurityLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_Roles",
                schema: "Qa",
                table: "Abp_Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_RoleClaims",
                schema: "Qa",
                table: "Abp_RoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_Permissions",
                schema: "Qa",
                table: "Abp_Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_PermissionGroups",
                schema: "Qa",
                table: "Abp_PermissionGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_PermissionGrants",
                schema: "Qa",
                table: "Abp_PermissionGrants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_OrganizationUnits",
                schema: "Qa",
                table: "Abp_OrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_OrganizationUnitRoles",
                schema: "Qa",
                table: "Abp_OrganizationUnitRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_LinkUsers",
                schema: "Qa",
                table: "Abp_LinkUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_FeatureValues",
                schema: "Qa",
                table: "Abp_FeatureValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_Features",
                schema: "Qa",
                table: "Abp_Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_FeatureGroups",
                schema: "Qa",
                table: "Abp_FeatureGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_ClaimTypes",
                schema: "Qa",
                table: "Abp_ClaimTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_BackgroundJobs",
                schema: "Qa",
                table: "Abp_BackgroundJobs");

            migrationBuilder.RenameTable(
                name: "Abp_UserTokens",
                schema: "Qa",
                newName: "AbpUserTokens");

            migrationBuilder.RenameTable(
                name: "Abp_Users",
                schema: "Qa",
                newName: "AbpUsers");

            migrationBuilder.RenameTable(
                name: "Abp_UserRoles",
                schema: "Qa",
                newName: "AbpUserRoles");

            migrationBuilder.RenameTable(
                name: "Abp_UserOrganizationUnits",
                schema: "Qa",
                newName: "AbpUserOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "Abp_UserLogins",
                schema: "Qa",
                newName: "AbpUserLogins");

            migrationBuilder.RenameTable(
                name: "Abp_UserDelegations",
                schema: "Qa",
                newName: "AbpUserDelegations");

            migrationBuilder.RenameTable(
                name: "Abp_UserClaims",
                schema: "Qa",
                newName: "AbpUserClaims");

            migrationBuilder.RenameTable(
                name: "Abp_Tenants",
                schema: "Qa",
                newName: "AbpTenants");

            migrationBuilder.RenameTable(
                name: "Abp_TenantConnectionStrings",
                schema: "Qa",
                newName: "AbpTenantConnectionStrings");

            migrationBuilder.RenameTable(
                name: "Abp_Settings",
                schema: "Qa",
                newName: "AbpSettings");

            migrationBuilder.RenameTable(
                name: "Abp_SettingDefinitions",
                schema: "Qa",
                newName: "AbpSettingDefinitions");

            migrationBuilder.RenameTable(
                name: "Abp_Sessions",
                schema: "Qa",
                newName: "AbpSessions");

            migrationBuilder.RenameTable(
                name: "Abp_SecurityLogs",
                schema: "Qa",
                newName: "AbpSecurityLogs");

            migrationBuilder.RenameTable(
                name: "Abp_Roles",
                schema: "Qa",
                newName: "AbpRoles");

            migrationBuilder.RenameTable(
                name: "Abp_RoleClaims",
                schema: "Qa",
                newName: "AbpRoleClaims");

            migrationBuilder.RenameTable(
                name: "Abp_Permissions",
                schema: "Qa",
                newName: "AbpPermissions");

            migrationBuilder.RenameTable(
                name: "Abp_PermissionGroups",
                schema: "Qa",
                newName: "AbpPermissionGroups");

            migrationBuilder.RenameTable(
                name: "Abp_PermissionGrants",
                schema: "Qa",
                newName: "AbpPermissionGrants");

            migrationBuilder.RenameTable(
                name: "Abp_OrganizationUnits",
                schema: "Qa",
                newName: "AbpOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "Abp_OrganizationUnitRoles",
                schema: "Qa",
                newName: "AbpOrganizationUnitRoles");

            migrationBuilder.RenameTable(
                name: "Abp_LinkUsers",
                schema: "Qa",
                newName: "AbpLinkUsers");

            migrationBuilder.RenameTable(
                name: "Abp_FeatureValues",
                schema: "Qa",
                newName: "AbpFeatureValues");

            migrationBuilder.RenameTable(
                name: "Abp_Features",
                schema: "Qa",
                newName: "AbpFeatures");

            migrationBuilder.RenameTable(
                name: "Abp_FeatureGroups",
                schema: "Qa",
                newName: "AbpFeatureGroups");

            migrationBuilder.RenameTable(
                name: "Abp_ClaimTypes",
                schema: "Qa",
                newName: "AbpClaimTypes");

            migrationBuilder.RenameTable(
                name: "Abp_BackgroundJobs",
                schema: "Qa",
                newName: "AbpBackgroundJobs");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Users_UserName",
                table: "AbpUsers",
                newName: "IX_AbpUsers_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Users_NormalizedUserName",
                table: "AbpUsers",
                newName: "IX_AbpUsers_NormalizedUserName");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Users_NormalizedEmail",
                table: "AbpUsers",
                newName: "IX_AbpUsers_NormalizedEmail");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Users_Email",
                table: "AbpUsers",
                newName: "IX_AbpUsers_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_UserRoles_RoleId_UserId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_RoleId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_UserOrganizationUnits_UserId_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                newName: "IX_AbpUserOrganizationUnits_UserId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_UserLogins_LoginProvider_ProviderKey",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_LoginProvider_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_UserClaims_UserId",
                table: "AbpUserClaims",
                newName: "IX_AbpUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Tenants_NormalizedName",
                table: "AbpTenants",
                newName: "IX_AbpTenants_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Tenants_Name",
                table: "AbpTenants",
                newName: "IX_AbpTenants_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Settings_Name_ProviderName_ProviderKey",
                table: "AbpSettings",
                newName: "IX_AbpSettings_Name_ProviderName_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_SettingDefinitions_Name",
                table: "AbpSettingDefinitions",
                newName: "IX_AbpSettingDefinitions_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Sessions_TenantId_UserId",
                table: "AbpSessions",
                newName: "IX_AbpSessions_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Sessions_SessionId",
                table: "AbpSessions",
                newName: "IX_AbpSessions_SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Sessions_Device",
                table: "AbpSessions",
                newName: "IX_AbpSessions_Device");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_SecurityLogs_TenantId_UserId",
                table: "AbpSecurityLogs",
                newName: "IX_AbpSecurityLogs_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_SecurityLogs_TenantId_Identity",
                table: "AbpSecurityLogs",
                newName: "IX_AbpSecurityLogs_TenantId_Identity");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_SecurityLogs_TenantId_ApplicationName",
                table: "AbpSecurityLogs",
                newName: "IX_AbpSecurityLogs_TenantId_ApplicationName");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_SecurityLogs_TenantId_Action",
                table: "AbpSecurityLogs",
                newName: "IX_AbpSecurityLogs_TenantId_Action");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Roles_NormalizedName",
                table: "AbpRoles",
                newName: "IX_AbpRoles_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_RoleClaims_RoleId",
                table: "AbpRoleClaims",
                newName: "IX_AbpRoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Permissions_Name",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Permissions_GroupName",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_GroupName");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_PermissionGroups_Name",
                table: "AbpPermissionGroups",
                newName: "IX_AbpPermissionGroups_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_PermissionGrants_TenantId_Name_ProviderName_ProviderKey",
                table: "AbpPermissionGrants",
                newName: "IX_AbpPermissionGrants_TenantId_Name_ProviderName_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_OrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_OrganizationUnits_Code",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_OrganizationUnitRoles_RoleId_OrganizationUnitId",
                table: "AbpOrganizationUnitRoles",
                newName: "IX_AbpOrganizationUnitRoles_RoleId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_LinkUsers_SourceUserId_SourceTenantId_TargetUserId_TargetTenantId",
                table: "AbpLinkUsers",
                newName: "IX_AbpLinkUsers_SourceUserId_SourceTenantId_TargetUserId_TargetTenantId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_FeatureValues_Name_ProviderName_ProviderKey",
                table: "AbpFeatureValues",
                newName: "IX_AbpFeatureValues_Name_ProviderName_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Features_Name",
                table: "AbpFeatures",
                newName: "IX_AbpFeatures_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Features_GroupName",
                table: "AbpFeatures",
                newName: "IX_AbpFeatures_GroupName");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_FeatureGroups_Name",
                table: "AbpFeatureGroups",
                newName: "IX_AbpFeatureGroups_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_BackgroundJobs_IsAbandoned_NextTryTime",
                table: "AbpBackgroundJobs",
                newName: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserTokens",
                table: "AbpUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUsers",
                table: "AbpUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserRoles",
                table: "AbpUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserOrganizationUnits",
                table: "AbpUserOrganizationUnits",
                columns: new[] { "OrganizationUnitId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserLogins",
                table: "AbpUserLogins",
                columns: new[] { "UserId", "LoginProvider" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserDelegations",
                table: "AbpUserDelegations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserClaims",
                table: "AbpUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTenants",
                table: "AbpTenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTenantConnectionStrings",
                table: "AbpTenantConnectionStrings",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpSettings",
                table: "AbpSettings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpSettingDefinitions",
                table: "AbpSettingDefinitions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpSessions",
                table: "AbpSessions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpSecurityLogs",
                table: "AbpSecurityLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoleClaims",
                table: "AbpRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpPermissions",
                table: "AbpPermissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpPermissionGroups",
                table: "AbpPermissionGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpPermissionGrants",
                table: "AbpPermissionGrants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpOrganizationUnitRoles",
                table: "AbpOrganizationUnitRoles",
                columns: new[] { "OrganizationUnitId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpLinkUsers",
                table: "AbpLinkUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpFeatureValues",
                table: "AbpFeatureValues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpFeatures",
                table: "AbpFeatures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpFeatureGroups",
                table: "AbpFeatureGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpClaimTypes",
                table: "AbpClaimTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpBackgroundJobs",
                table: "AbpBackgroundJobs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnitRoles_AbpOrganizationUnits_OrganizationUnitId",
                table: "AbpOrganizationUnitRoles",
                column: "OrganizationUnitId",
                principalTable: "AbpOrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnitRoles_AbpRoles_RoleId",
                table: "AbpOrganizationUnitRoles",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                column: "ParentId",
                principalTable: "AbpOrganizationUnits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenantConnectionStrings_AbpTenants_TenantId",
                table: "AbpTenantConnectionStrings",
                column: "TenantId",
                principalTable: "AbpTenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserClaims_AbpUsers_UserId",
                table: "AbpUserClaims",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserLogins_AbpUsers_UserId",
                table: "AbpUserLogins",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserOrganizationUnits_AbpOrganizationUnits_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                column: "OrganizationUnitId",
                principalTable: "AbpOrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserOrganizationUnits_AbpUsers_UserId",
                table: "AbpUserOrganizationUnits",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserRoles_AbpRoles_RoleId",
                table: "AbpUserRoles",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserRoles_AbpUsers_UserId",
                table: "AbpUserRoles",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
