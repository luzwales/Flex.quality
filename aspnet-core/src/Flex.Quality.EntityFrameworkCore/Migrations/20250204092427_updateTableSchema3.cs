using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flex.Quality.Migrations
{
    /// <inheritdoc />
    public partial class updateTableSchema3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpNotificationSubscriptions",
                table: "AbpNotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpNotifications",
                table: "AbpNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpLanguageTexts",
                table: "AbpLanguageTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpLanguages",
                table: "AbpLanguages");

            migrationBuilder.RenameTable(
                name: "AbpNotificationSubscriptions",
                newName: "Abp_NotificationSubscriptions",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpNotifications",
                newName: "Abp_Notifications",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpLanguageTexts",
                newName: "Abp_LanguageTexts");

            migrationBuilder.RenameTable(
                name: "AbpLanguages",
                newName: "Abp_Languages");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_ReceiveUserId",
                schema: "Qa",
                table: "Abp_NotificationSubscriptions",
                newName: "IX_Abp_NotificationSubscriptions_ReceiveUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_NotificationId",
                schema: "Qa",
                table: "Abp_NotificationSubscriptions",
                newName: "IX_Abp_NotificationSubscriptions_NotificationId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpLanguageTexts_TenantId_ResourceName_CultureName",
                table: "Abp_LanguageTexts",
                newName: "IX_Abp_LanguageTexts_TenantId_ResourceName_CultureName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpLanguages_CultureName",
                table: "Abp_Languages",
                newName: "IX_Abp_Languages_CultureName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_NotificationSubscriptions",
                schema: "Qa",
                table: "Abp_NotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_Notifications",
                schema: "Qa",
                table: "Abp_Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_LanguageTexts",
                table: "Abp_LanguageTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_Languages",
                table: "Abp_Languages",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_NotificationSubscriptions",
                schema: "Qa",
                table: "Abp_NotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_Notifications",
                schema: "Qa",
                table: "Abp_Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_LanguageTexts",
                table: "Abp_LanguageTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_Languages",
                table: "Abp_Languages");

            migrationBuilder.RenameTable(
                name: "Abp_NotificationSubscriptions",
                schema: "Qa",
                newName: "AbpNotificationSubscriptions");

            migrationBuilder.RenameTable(
                name: "Abp_Notifications",
                schema: "Qa",
                newName: "AbpNotifications");

            migrationBuilder.RenameTable(
                name: "Abp_LanguageTexts",
                newName: "AbpLanguageTexts");

            migrationBuilder.RenameTable(
                name: "Abp_Languages",
                newName: "AbpLanguages");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_NotificationSubscriptions_ReceiveUserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_ReceiveUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_NotificationSubscriptions_NotificationId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_NotificationId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_LanguageTexts_TenantId_ResourceName_CultureName",
                table: "AbpLanguageTexts",
                newName: "IX_AbpLanguageTexts_TenantId_ResourceName_CultureName");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Languages_CultureName",
                table: "AbpLanguages",
                newName: "IX_AbpLanguages_CultureName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpNotificationSubscriptions",
                table: "AbpNotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpNotifications",
                table: "AbpNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpLanguageTexts",
                table: "AbpLanguageTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpLanguages",
                table: "AbpLanguages",
                column: "Id");
        }
    }
}
