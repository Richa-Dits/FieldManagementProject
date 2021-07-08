﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FieldMgt.API.Migrations
{
    public partial class identitydemocorehello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "City_FK",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "Country_FK",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "Designation_FK",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "LCoresCity_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LCoresCountry_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LeadSource_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LeadStage_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LeadStatus_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LGender_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LPermaCity_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LPermaCountry_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LALeadId_FK",
                table: "LeadActivity");

            migrationBuilder.DropForeignKey(
                name: "LAStatus_FK",
                table: "LeadActivity");

            migrationBuilder.DropForeignKey(
                name: "LCLeadId_FK",
                table: "LeadCall");

            migrationBuilder.DropForeignKey(
                name: "LCStatus_FK",
                table: "LeadCall");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadContact_Lead_LeadId",
                table: "LeadContact");

            migrationBuilder.DropForeignKey(
                name: "LCCoresCity_FK",
                table: "LeadContact");

            migrationBuilder.DropForeignKey(
                name: "LCCoresCountry_FK",
                table: "LeadContact");

            migrationBuilder.DropForeignKey(
                name: "LCGender_FK",
                table: "LeadContact");

            migrationBuilder.DropForeignKey(
                name: "LCPermaCity_FK",
                table: "LeadContact");

            migrationBuilder.DropForeignKey(
                name: "LCPermaCountry_FK",
                table: "LeadContact");

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "Lead",
                type: "char(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LeadStage",
                table: "Lead",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Lead",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Lead",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "City_FK",
                table: "Employee",
                column: "City",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "Country_FK",
                table: "Employee",
                column: "Country",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "Designation_FK",
                table: "Employee",
                column: "Designation",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LCoresCity_FK",
                table: "Lead",
                column: "CoresCity",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LCoresCountry_FK",
                table: "Lead",
                column: "CoresCountry",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LeadSource_FK",
                table: "Lead",
                column: "LeadSource",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LeadStage_FK",
                table: "Lead",
                column: "LeadStage",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "LeadStatus_FK",
                table: "Lead",
                column: "LeadStatus",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LGender_FK",
                table: "Lead",
                column: "Gender",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LPermaCity_FK",
                table: "Lead",
                column: "PermaCity",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LPermaCountry_FK",
                table: "Lead",
                column: "PermaCountry",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LALeadId_FK",
                table: "LeadActivity",
                column: "LeadId",
                principalTable: "Lead",
                principalColumn: "LeadId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LAStatus_FK",
                table: "LeadActivity",
                column: "Status",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LCLeadId_FK",
                table: "LeadCall",
                column: "LeadId",
                principalTable: "Lead",
                principalColumn: "LeadId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LCStatus_FK",
                table: "LeadCall",
                column: "Status",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadContact_Lead_LeadId",
                table: "LeadContact",
                column: "LeadId",
                principalTable: "Lead",
                principalColumn: "LeadId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LCCoresCity_FK",
                table: "LeadContact",
                column: "CoresCity",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LCCoresCountry_FK",
                table: "LeadContact",
                column: "CoresCountry",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LCGender_FK",
                table: "LeadContact",
                column: "Gender",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LCPermaCity_FK",
                table: "LeadContact",
                column: "PermaCity",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LCPermaCountry_FK",
                table: "LeadContact",
                column: "PermaCountry",
                principalTable: "Reference",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "City_FK",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "Country_FK",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "Designation_FK",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "LCoresCity_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LCoresCountry_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LeadSource_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LeadStage_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LeadStatus_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LGender_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LPermaCity_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LPermaCountry_FK",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "LALeadId_FK",
                table: "LeadActivity");

            migrationBuilder.DropForeignKey(
                name: "LAStatus_FK",
                table: "LeadActivity");

            migrationBuilder.DropForeignKey(
                name: "LCLeadId_FK",
                table: "LeadCall");

            migrationBuilder.DropForeignKey(
                name: "LCStatus_FK",
                table: "LeadCall");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadContact_Lead_LeadId",
                table: "LeadContact");

            migrationBuilder.DropForeignKey(
                name: "LCCoresCity_FK",
                table: "LeadContact");

            migrationBuilder.DropForeignKey(
                name: "LCCoresCountry_FK",
                table: "LeadContact");

            migrationBuilder.DropForeignKey(
                name: "LCGender_FK",
                table: "LeadContact");

            migrationBuilder.DropForeignKey(
                name: "LCPermaCity_FK",
                table: "LeadContact");

            migrationBuilder.DropForeignKey(
                name: "LCPermaCountry_FK",
                table: "LeadContact");

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "Lead",
                type: "char(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LeadStage",
                table: "Lead",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Lead",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Lead",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "City_FK",
                table: "Employee",
                column: "City",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "Country_FK",
                table: "Employee",
                column: "Country",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "Designation_FK",
                table: "Employee",
                column: "Designation",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LCoresCity_FK",
                table: "Lead",
                column: "CoresCity",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LCoresCountry_FK",
                table: "Lead",
                column: "CoresCountry",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LeadSource_FK",
                table: "Lead",
                column: "LeadSource",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LeadStage_FK",
                table: "Lead",
                column: "LeadStage",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LeadStatus_FK",
                table: "Lead",
                column: "LeadStatus",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LGender_FK",
                table: "Lead",
                column: "Gender",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LPermaCity_FK",
                table: "Lead",
                column: "PermaCity",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LPermaCountry_FK",
                table: "Lead",
                column: "PermaCountry",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LALeadId_FK",
                table: "LeadActivity",
                column: "LeadId",
                principalTable: "Lead",
                principalColumn: "LeadId");

            migrationBuilder.AddForeignKey(
                name: "LAStatus_FK",
                table: "LeadActivity",
                column: "Status",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LCLeadId_FK",
                table: "LeadCall",
                column: "LeadId",
                principalTable: "Lead",
                principalColumn: "LeadId");

            migrationBuilder.AddForeignKey(
                name: "LCStatus_FK",
                table: "LeadCall",
                column: "Status",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadContact_Lead_LeadId",
                table: "LeadContact",
                column: "LeadId",
                principalTable: "Lead",
                principalColumn: "LeadId");

            migrationBuilder.AddForeignKey(
                name: "LCCoresCity_FK",
                table: "LeadContact",
                column: "CoresCity",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LCCoresCountry_FK",
                table: "LeadContact",
                column: "CoresCountry",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LCGender_FK",
                table: "LeadContact",
                column: "Gender",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LCPermaCity_FK",
                table: "LeadContact",
                column: "PermaCity",
                principalTable: "Reference",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LCPermaCountry_FK",
                table: "LeadContact",
                column: "PermaCountry",
                principalTable: "Reference",
                principalColumn: "ReferenceId");
        }
    }
}
