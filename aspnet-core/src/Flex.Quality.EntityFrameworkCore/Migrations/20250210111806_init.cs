using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flex.Quality.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abp_EntityModelProperties_Abp_EntityModels_EntityModelId",
                table: "Abp_EntityModelProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_EnumTypeProperty_Abp_EnumType_EnumTypeId",
                table: "Abp_EnumTypeProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_TemplateDetails_Abp_Templates_TemplateId",
                table: "Abp_TemplateDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_Templates",
                table: "Abp_Templates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_TemplateDetails",
                table: "Abp_TemplateDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_Projects",
                table: "Abp_Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_EnumTypeProperty",
                table: "Abp_EnumTypeProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_EnumType",
                table: "Abp_EnumType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_EntityModels",
                table: "Abp_EntityModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_EntityModelProperties",
                table: "Abp_EntityModelProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_DataType",
                table: "Abp_DataType");

            migrationBuilder.RenameTable(
                name: "Abp_Templates",
                newName: "Qa.Abp_Templates");

            migrationBuilder.RenameTable(
                name: "Abp_TemplateDetails",
                newName: "Qa.Abp_TemplateDetails");

            migrationBuilder.RenameTable(
                name: "Abp_Projects",
                newName: "Qa.Abp_Projects");

            migrationBuilder.RenameTable(
                name: "Abp_EnumTypeProperty",
                newName: "Qa.Abp_EnumTypeProperty");

            migrationBuilder.RenameTable(
                name: "Abp_EnumType",
                newName: "Qa.Abp_EnumType");

            migrationBuilder.RenameTable(
                name: "Abp_EntityModels",
                newName: "Qa.Abp_EntityModels");

            migrationBuilder.RenameTable(
                name: "Abp_EntityModelProperties",
                newName: "Qa.Abp_EntityModelProperties");

            migrationBuilder.RenameTable(
                name: "Abp_DataType",
                newName: "Qa.Abp_DataType");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_TemplateDetails_TemplateId",
                table: "Qa.Abp_TemplateDetails",
                newName: "IX_Qa.Abp_TemplateDetails_TemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EnumTypeProperty_EnumTypeId",
                table: "Qa.Abp_EnumTypeProperty",
                newName: "IX_Qa.Abp_EnumTypeProperty_EnumTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EnumTypeProperty_Code",
                table: "Qa.Abp_EnumTypeProperty",
                newName: "IX_Qa.Abp_EnumTypeProperty_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EnumType_Code",
                table: "Qa.Abp_EnumType",
                newName: "IX_Qa.Abp_EnumType_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EntityModels_Code",
                table: "Qa.Abp_EntityModels",
                newName: "IX_Qa.Abp_EntityModels_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EntityModelProperties_EntityModelId",
                table: "Qa.Abp_EntityModelProperties",
                newName: "IX_Qa.Abp_EntityModelProperties_EntityModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qa.Abp_Templates",
                table: "Qa.Abp_Templates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qa.Abp_TemplateDetails",
                table: "Qa.Abp_TemplateDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qa.Abp_Projects",
                table: "Qa.Abp_Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qa.Abp_EnumTypeProperty",
                table: "Qa.Abp_EnumTypeProperty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qa.Abp_EnumType",
                table: "Qa.Abp_EnumType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qa.Abp_EntityModels",
                table: "Qa.Abp_EntityModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qa.Abp_EntityModelProperties",
                table: "Qa.Abp_EntityModelProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qa.Abp_DataType",
                table: "Qa.Abp_DataType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Qa.Abp_EntityModelProperties_Qa.Abp_EntityModels_EntityModelId",
                table: "Qa.Abp_EntityModelProperties",
                column: "EntityModelId",
                principalTable: "Qa.Abp_EntityModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Qa.Abp_EnumTypeProperty_Qa.Abp_EnumType_EnumTypeId",
                table: "Qa.Abp_EnumTypeProperty",
                column: "EnumTypeId",
                principalTable: "Qa.Abp_EnumType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Qa.Abp_TemplateDetails_Qa.Abp_Templates_TemplateId",
                table: "Qa.Abp_TemplateDetails",
                column: "TemplateId",
                principalTable: "Qa.Abp_Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Qa.Abp_EntityModelProperties_Qa.Abp_EntityModels_EntityModelId",
                table: "Qa.Abp_EntityModelProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_Qa.Abp_EnumTypeProperty_Qa.Abp_EnumType_EnumTypeId",
                table: "Qa.Abp_EnumTypeProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_Qa.Abp_TemplateDetails_Qa.Abp_Templates_TemplateId",
                table: "Qa.Abp_TemplateDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qa.Abp_Templates",
                table: "Qa.Abp_Templates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qa.Abp_TemplateDetails",
                table: "Qa.Abp_TemplateDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qa.Abp_Projects",
                table: "Qa.Abp_Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qa.Abp_EnumTypeProperty",
                table: "Qa.Abp_EnumTypeProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qa.Abp_EnumType",
                table: "Qa.Abp_EnumType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qa.Abp_EntityModels",
                table: "Qa.Abp_EntityModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qa.Abp_EntityModelProperties",
                table: "Qa.Abp_EntityModelProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qa.Abp_DataType",
                table: "Qa.Abp_DataType");

            migrationBuilder.RenameTable(
                name: "Qa.Abp_Templates",
                newName: "Abp_Templates");

            migrationBuilder.RenameTable(
                name: "Qa.Abp_TemplateDetails",
                newName: "Abp_TemplateDetails");

            migrationBuilder.RenameTable(
                name: "Qa.Abp_Projects",
                newName: "Abp_Projects");

            migrationBuilder.RenameTable(
                name: "Qa.Abp_EnumTypeProperty",
                newName: "Abp_EnumTypeProperty");

            migrationBuilder.RenameTable(
                name: "Qa.Abp_EnumType",
                newName: "Abp_EnumType");

            migrationBuilder.RenameTable(
                name: "Qa.Abp_EntityModels",
                newName: "Abp_EntityModels");

            migrationBuilder.RenameTable(
                name: "Qa.Abp_EntityModelProperties",
                newName: "Abp_EntityModelProperties");

            migrationBuilder.RenameTable(
                name: "Qa.Abp_DataType",
                newName: "Abp_DataType");

            migrationBuilder.RenameIndex(
                name: "IX_Qa.Abp_TemplateDetails_TemplateId",
                table: "Abp_TemplateDetails",
                newName: "IX_Abp_TemplateDetails_TemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_Qa.Abp_EnumTypeProperty_EnumTypeId",
                table: "Abp_EnumTypeProperty",
                newName: "IX_Abp_EnumTypeProperty_EnumTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Qa.Abp_EnumTypeProperty_Code",
                table: "Abp_EnumTypeProperty",
                newName: "IX_Abp_EnumTypeProperty_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Qa.Abp_EnumType_Code",
                table: "Abp_EnumType",
                newName: "IX_Abp_EnumType_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Qa.Abp_EntityModels_Code",
                table: "Abp_EntityModels",
                newName: "IX_Abp_EntityModels_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Qa.Abp_EntityModelProperties_EntityModelId",
                table: "Abp_EntityModelProperties",
                newName: "IX_Abp_EntityModelProperties_EntityModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_Templates",
                table: "Abp_Templates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_TemplateDetails",
                table: "Abp_TemplateDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_Projects",
                table: "Abp_Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_EnumTypeProperty",
                table: "Abp_EnumTypeProperty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_EnumType",
                table: "Abp_EnumType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_EntityModels",
                table: "Abp_EntityModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_EntityModelProperties",
                table: "Abp_EntityModelProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_DataType",
                table: "Abp_DataType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_EntityModelProperties_Abp_EntityModels_EntityModelId",
                table: "Abp_EntityModelProperties",
                column: "EntityModelId",
                principalTable: "Abp_EntityModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_EnumTypeProperty_Abp_EnumType_EnumTypeId",
                table: "Abp_EnumTypeProperty",
                column: "EnumTypeId",
                principalTable: "Abp_EnumType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_TemplateDetails_Abp_Templates_TemplateId",
                table: "Abp_TemplateDetails",
                column: "TemplateId",
                principalTable: "Abp_Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
