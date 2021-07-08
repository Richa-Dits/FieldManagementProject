using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FieldMgt.API.Migrations
{
    public partial class IdentityDemocoreactivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeadStage",
                table: "Lead",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LeadActivity",
                columns: table => new
                {
                    LeadActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(255)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    AssignedTo = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadActivity", x => x.LeadActivityId);
                    table.ForeignKey(
                        name: "LAAssignedTo_FK",
                        column: x => x.AssignedTo,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LACreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LALeadId_FK",
                        column: x => x.LeadId,
                        principalTable: "Lead",
                        principalColumn: "LeadId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LAModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LAStatus_FK",
                        column: x => x.Status,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LeadCall",
                columns: table => new
                {
                    LeadCallId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(255)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    CalledBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CalledOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadCall", x => x.LeadCallId);
                    table.ForeignKey(
                        name: "LCCalledBy_FK",
                        column: x => x.CalledBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LCLeadId_FK",
                        column: x => x.LeadId,
                        principalTable: "Lead",
                        principalColumn: "LeadId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LCStatus_FK",
                        column: x => x.Status,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lead_LeadStage",
                table: "Lead",
                column: "LeadStage");

            migrationBuilder.CreateIndex(
                name: "IX_LeadActivity_AssignedTo",
                table: "LeadActivity",
                column: "AssignedTo");

            migrationBuilder.CreateIndex(
                name: "IX_LeadActivity_CreatedBy",
                table: "LeadActivity",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadActivity_LeadId",
                table: "LeadActivity",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadActivity_ModifiedBy",
                table: "LeadActivity",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadActivity_Status",
                table: "LeadActivity",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCall_CalledBy",
                table: "LeadCall",
                column: "CalledBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCall_LeadId",
                table: "LeadCall",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCall_Status",
                table: "LeadCall",
                column: "Status");

            migrationBuilder.AddForeignKey(
                name: "LeadStage_FK",
                table: "Lead",
                column: "LeadStage",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "LeadStage_FK",
                table: "Lead");

            migrationBuilder.DropTable(
                name: "LeadActivity");

            migrationBuilder.DropTable(
                name: "LeadCall");

            migrationBuilder.DropIndex(
                name: "IX_Lead_LeadStage",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "LeadStage",
                table: "Lead");
        }
    }
}
