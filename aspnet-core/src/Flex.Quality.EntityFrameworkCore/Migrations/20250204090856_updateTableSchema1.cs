using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flex.Quality.Migrations
{
    /// <inheritdoc />
    public partial class updateTableSchema1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpAuditLogActions_AbpAuditLogs_AuditLogId",
                table: "AbpAuditLogActions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpEntityChanges_AbpAuditLogs_AuditLogId",
                table: "AbpEntityChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityPropertyChanges",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityChanges",
                table: "AbpEntityChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpAuditLogs",
                table: "AbpAuditLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpAuditLogActions",
                table: "AbpAuditLogActions");

            migrationBuilder.RenameTable(
                name: "AbpEntityPropertyChanges",
                newName: "Abp_EntityPropertyChanges",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpEntityChanges",
                newName: "Abp_EntityChanges",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpAuditLogs",
                newName: "Abp_AuditLogs",
                newSchema: "Qa");

            migrationBuilder.RenameTable(
                name: "AbpAuditLogActions",
                newName: "Abp_AuditLogActions",
                newSchema: "Qa");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityPropertyChanges_EntityChangeId",
                schema: "Qa",
                table: "Abp_EntityPropertyChanges",
                newName: "IX_Abp_EntityPropertyChanges_EntityChangeId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChanges_TenantId_EntityTypeFullName_EntityId",
                schema: "Qa",
                table: "Abp_EntityChanges",
                newName: "IX_Abp_EntityChanges_TenantId_EntityTypeFullName_EntityId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChanges_AuditLogId",
                schema: "Qa",
                table: "Abp_EntityChanges",
                newName: "IX_Abp_EntityChanges_AuditLogId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_UserId_ExecutionTime",
                schema: "Qa",
                table: "Abp_AuditLogs",
                newName: "IX_Abp_AuditLogs_TenantId_UserId_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
                schema: "Qa",
                table: "Abp_AuditLogs",
                newName: "IX_Abp_AuditLogs_TenantId_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogActions_TenantId_ServiceName_MethodName_ExecutionTime",
                schema: "Qa",
                table: "Abp_AuditLogActions",
                newName: "IX_Abp_AuditLogActions_TenantId_ServiceName_MethodName_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogActions_AuditLogId",
                schema: "Qa",
                table: "Abp_AuditLogActions",
                newName: "IX_Abp_AuditLogActions_AuditLogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_EntityPropertyChanges",
                schema: "Qa",
                table: "Abp_EntityPropertyChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_EntityChanges",
                schema: "Qa",
                table: "Abp_EntityChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_AuditLogs",
                schema: "Qa",
                table: "Abp_AuditLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abp_AuditLogActions",
                schema: "Qa",
                table: "Abp_AuditLogActions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_AuditLogActions_Abp_AuditLogs_AuditLogId",
                schema: "Qa",
                table: "Abp_AuditLogActions",
                column: "AuditLogId",
                principalSchema: "Qa",
                principalTable: "Abp_AuditLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_EntityChanges_Abp_AuditLogs_AuditLogId",
                schema: "Qa",
                table: "Abp_EntityChanges",
                column: "AuditLogId",
                principalSchema: "Qa",
                principalTable: "Abp_AuditLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abp_EntityPropertyChanges_Abp_EntityChanges_EntityChangeId",
                schema: "Qa",
                table: "Abp_EntityPropertyChanges",
                column: "EntityChangeId",
                principalSchema: "Qa",
                principalTable: "Abp_EntityChanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abp_AuditLogActions_Abp_AuditLogs_AuditLogId",
                schema: "Qa",
                table: "Abp_AuditLogActions");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_EntityChanges_Abp_AuditLogs_AuditLogId",
                schema: "Qa",
                table: "Abp_EntityChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_Abp_EntityPropertyChanges_Abp_EntityChanges_EntityChangeId",
                schema: "Qa",
                table: "Abp_EntityPropertyChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_EntityPropertyChanges",
                schema: "Qa",
                table: "Abp_EntityPropertyChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_EntityChanges",
                schema: "Qa",
                table: "Abp_EntityChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_AuditLogs",
                schema: "Qa",
                table: "Abp_AuditLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abp_AuditLogActions",
                schema: "Qa",
                table: "Abp_AuditLogActions");

            migrationBuilder.RenameTable(
                name: "Abp_EntityPropertyChanges",
                schema: "Qa",
                newName: "AbpEntityPropertyChanges");

            migrationBuilder.RenameTable(
                name: "Abp_EntityChanges",
                schema: "Qa",
                newName: "AbpEntityChanges");

            migrationBuilder.RenameTable(
                name: "Abp_AuditLogs",
                schema: "Qa",
                newName: "AbpAuditLogs");

            migrationBuilder.RenameTable(
                name: "Abp_AuditLogActions",
                schema: "Qa",
                newName: "AbpAuditLogActions");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EntityPropertyChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                newName: "IX_AbpEntityPropertyChanges_EntityChangeId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EntityChanges_TenantId_EntityTypeFullName_EntityId",
                table: "AbpEntityChanges",
                newName: "IX_AbpEntityChanges_TenantId_EntityTypeFullName_EntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_EntityChanges_AuditLogId",
                table: "AbpEntityChanges",
                newName: "IX_AbpEntityChanges_AuditLogId");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_AuditLogs_TenantId_UserId_ExecutionTime",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_UserId_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_AuditLogs_TenantId_ExecutionTime",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_AuditLogActions_TenantId_ServiceName_MethodName_ExecutionTime",
                table: "AbpAuditLogActions",
                newName: "IX_AbpAuditLogActions_TenantId_ServiceName_MethodName_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_Abp_AuditLogActions_AuditLogId",
                table: "AbpAuditLogActions",
                newName: "IX_AbpAuditLogActions_AuditLogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityPropertyChanges",
                table: "AbpEntityPropertyChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityChanges",
                table: "AbpEntityChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpAuditLogs",
                table: "AbpAuditLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpAuditLogActions",
                table: "AbpAuditLogActions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpAuditLogActions_AbpAuditLogs_AuditLogId",
                table: "AbpAuditLogActions",
                column: "AuditLogId",
                principalTable: "AbpAuditLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpEntityChanges_AbpAuditLogs_AuditLogId",
                table: "AbpEntityChanges",
                column: "AuditLogId",
                principalTable: "AbpAuditLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                column: "EntityChangeId",
                principalTable: "AbpEntityChanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
