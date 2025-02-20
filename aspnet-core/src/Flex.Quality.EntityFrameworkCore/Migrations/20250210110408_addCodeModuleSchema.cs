using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flex.Quality.Migrations
{
    /// <inheritdoc />
    public partial class addCodeModuleSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpProEntityModelProperties_AbpProEntityModels_EntityModelId",
                table: "AbpProEntityModelProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpProEnumTypeProperty_AbpProEnumType_EnumTypeId",
                table: "AbpProEnumTypeProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpProTemplateDetails_AbpProTemplates_TemplateId",
                table: "AbpProTemplateDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpProTemplates",
                table: "AbpProTemplates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpProTemplateDetails",
                table: "AbpProTemplateDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpProProjects",
                table: "AbpProProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpProEnumTypeProperty",
                table: "AbpProEnumTypeProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpProEnumType",
                table: "AbpProEnumType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpProEntityModels",
                table: "AbpProEntityModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpProEntityModelProperties",
                table: "AbpProEntityModelProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpProDataType",
                table: "AbpProDataType");

            migrationBuilder.RenameTable(
                name: "AbpProTemplates",
                newName: "Abp_Templates");

            migrationBuilder.RenameTable(
                name: "AbpProTemplateDetails",
                newName: "Abp_TemplateDetails");

            migrationBuilder.RenameTable(
                name: "AbpProProjects",
                newName: "Abp_Projects");

            migrationBuilder.RenameTable(
                name: "AbpProEnumTypeProperty",
                newName: "Abp_EnumTypeProperty");

            migrationBuilder.RenameTable(
                name: "AbpProEnumType",
                newName: "Abp_EnumType");

            migrationBuilder.RenameTable(
                name: "AbpProEntityModels",
                newName: "Abp_EntityModels");

            migrationBuilder.RenameTable(
                name: "AbpProEntityModelProperties",
                newName: "Abp_EntityModelProperties");

            migrationBuilder.RenameTable(
                name: "AbpProDataType",
                newName: "Abp_DataType");

            migrationBuilder.RenameIndex(
                name: "IX_AbpProTemplateDetails_TemplateId",
                table: "Abp_TemplateDetails",
                newName: "IX_Abp_TemplateDetails_TemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpProEnumTypeProperty_EnumTypeId",
                table: "Abp_EnumTypeProperty",
                newName: "IX_Abp_EnumTypeProperty_EnumTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpProEnumTypeProperty_Code",
                table: "Abp_EnumTypeProperty",
                newName: "IX_Abp_EnumTypeProperty_Code");

            migrationBuilder.RenameIndex(
                name: "IX_AbpProEnumType_Code",
                table: "Abp_EnumType",
                newName: "IX_Abp_EnumType_Code");

            migrationBuilder.RenameIndex(
                name: "IX_AbpProEntityModels_Code",
                table: "Abp_EntityModels",
                newName: "IX_Abp_EntityModels_Code");

            migrationBuilder.RenameIndex(
                name: "IX_AbpProEntityModelProperties_EntityModelId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "AbpProTemplates");

            migrationBuilder.RenameTable(
                name: "Abp_TemplateDetails",
                newName: "AbpProTemplateDetails");

            migrationBuilder.RenameTable(
                name: "Abp_Projects",
                newName: "AbpProProjects");

            migrationBuilder.RenameTable(
                name: "Abp_EnumTypeProperty",
                newName: "AbpProEnumTypeProperty");

            migrationBuilder.RenameTable(
                name: "Abp_EnumType",
                newName: "AbpProEnumType");

            migrationBuilder.RenameTable(
                name: "Abp_EntityModels",
                newName: "AbpProEntityModels");

            migrationBuilder.RenameTable(
                name: "Abp_EntityModelProperties",
                newName: "AbpProEntityModelProperties");

            migrationBuilder.RenameTable(
                name: "Abp_DataType",
                newName: "AbpProDataType");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_TemplateDetails_TemplateId",
                table: "AbpProTemplateDetails",
                newName: "IX_AbpProTemplateDetails_TemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EnumTypeProperty_EnumTypeId",
                table: "AbpProEnumTypeProperty",
                newName: "IX_AbpProEnumTypeProperty_EnumTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EnumTypeProperty_Code",
                table: "AbpProEnumTypeProperty",
                newName: "IX_AbpProEnumTypeProperty_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EnumType_Code",
                table: "AbpProEnumType",
                newName: "IX_AbpProEnumType_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EntityModels_Code",
                table: "AbpProEntityModels",
                newName: "IX_AbpProEntityModels_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EntityModelProperties_EntityModelId",
                table: "AbpProEntityModelProperties",
                newName: "IX_AbpProEntityModelProperties_EntityModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpProTemplates",
                table: "AbpProTemplates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpProTemplateDetails",
                table: "AbpProTemplateDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpProProjects",
                table: "AbpProProjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpProEnumTypeProperty",
                table: "AbpProEnumTypeProperty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpProEnumType",
                table: "AbpProEnumType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpProEntityModels",
                table: "AbpProEntityModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpProEntityModelProperties",
                table: "AbpProEntityModelProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpProDataType",
                table: "AbpProDataType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpProEntityModelProperties_AbpProEntityModels_EntityModelId",
                table: "AbpProEntityModelProperties",
                column: "EntityModelId",
                principalTable: "AbpProEntityModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpProEnumTypeProperty_AbpProEnumType_EnumTypeId",
                table: "AbpProEnumTypeProperty",
                column: "EnumTypeId",
                principalTable: "AbpProEnumType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpProTemplateDetails_AbpProTemplates_TemplateId",
                table: "AbpProTemplateDetails",
                column: "TemplateId",
                principalTable: "AbpProTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
