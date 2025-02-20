using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flex.Quality.Migrations
{
    /// <inheritdoc />
    public partial class updateTableSchema2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpDataDictionaryDetails_AbpDataDictionaries_DataDictionaryId",
                table: "AbpDataDictionaryDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpDataDictionaryDetails",
                table: "AbpDataDictionaryDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpDataDictionaries",
                table: "AbpDataDictionaries");

            migrationBuilder.RenameTable(
                name: "AbpDataDictionaryDetails",
                newName: "Abp_DataDictionaryDetails",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpDataDictionaries",
                newName: "Abp_DataDictionaries",
                newSchema: "Qa");

            migrationBuilder.RenameIndex(
                name: "IX_AbpDataDictionaryDetails_DataDictionaryId",
                schema: "Qa",
                table: "Abp_DataDictionaryDetails",
                newName: "IX_Abp_DataDictionaryDetails_DataDictionaryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_DataDictionaryDetails",
                schema: "Qa",
                table: "Abp_DataDictionaryDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_DataDictionaries",
                schema: "Qa",
                table: "Abp_DataDictionaries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_DataDictionaryDetails_Abp_DataDictionaries_DataDictionaryId",
                schema: "Qa",
                table: "Abp_DataDictionaryDetails",
                column: "DataDictionaryId",
                principalSchema: "Qa",
                principalTable: "Abp_DataDictionaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abp_DataDictionaryDetails_Abp_DataDictionaries_DataDictionaryId",
                schema: "Qa",
                table: "Abp_DataDictionaryDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_DataDictionaryDetails",
                schema: "Qa",
                table: "Abp_DataDictionaryDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_DataDictionaries",
                schema: "Qa",
                table: "Abp_DataDictionaries");

            migrationBuilder.RenameTable(
                name: "Abp_DataDictionaryDetails",
                schema: "Qa",
                newName: "AbpDataDictionaryDetails");

            migrationBuilder.RenameTable(
                name: "Abp_DataDictionaries",
                schema: "Qa",
                newName: "AbpDataDictionaries");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_DataDictionaryDetails_DataDictionaryId",
                table: "AbpDataDictionaryDetails",
                newName: "IX_AbpDataDictionaryDetails_DataDictionaryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpDataDictionaryDetails",
                table: "AbpDataDictionaryDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpDataDictionaries",
                table: "AbpDataDictionaries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpDataDictionaryDetails_AbpDataDictionaries_DataDictionaryId",
                table: "AbpDataDictionaryDetails",
                column: "DataDictionaryId",
                principalTable: "AbpDataDictionaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
