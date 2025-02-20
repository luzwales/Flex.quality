using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flex.Quality.Migrations
{
    /// <inheritdoc />
    public partial class updateTableSchema6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_LanguageTexts",
                table: "Abp_LanguageTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_Languages",
                table: "Abp_Languages");

            migrationBuilder.RenameTable(
                name: "Abp_LanguageTexts",
                newName: "QA.Abp_LanguageTexts");

            migrationBuilder.RenameTable(
                name: "Abp_Languages",
                newName: "QA.Abp_Languages");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_LanguageTexts_TenantId_ResourceName_CultureName",
                table: "QA.Abp_LanguageTexts",
                newName: "IX_QA.Abp_LanguageTexts_TenantId_ResourceName_CultureName");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_Languages_CultureName",
                table: "QA.Abp_Languages",
                newName: "IX_QA.Abp_Languages_CultureName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QA.Abp_LanguageTexts",
                table: "QA.Abp_LanguageTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QA.Abp_Languages",
                table: "QA.Abp_Languages",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QA.Abp_LanguageTexts",
                table: "QA.Abp_LanguageTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QA.Abp_Languages",
                table: "QA.Abp_Languages");

            migrationBuilder.RenameTable(
                name: "QA.Abp_LanguageTexts",
                newName: "Abp_LanguageTexts");

            migrationBuilder.RenameTable(
                name: "QA.Abp_Languages",
                newName: "Abp_Languages");

            migrationBuilder.RenameIndex(
                name: "IX_QA.Abp_LanguageTexts_TenantId_ResourceName_CultureName",
                table: "Abp_LanguageTexts",
                newName: "IX_Abp_LanguageTexts_TenantId_ResourceName_CultureName");

            migrationBuilder.RenameIndex(
                name: "IX_QA.Abp_Languages_CultureName",
                table: "Abp_Languages",
                newName: "IX_Abp_Languages_CultureName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_LanguageTexts",
                table: "Abp_LanguageTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_Languages",
                table: "Abp_Languages",
                column: "Id");
        }
    }
}
