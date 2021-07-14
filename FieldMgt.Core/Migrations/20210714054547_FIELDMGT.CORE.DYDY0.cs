using Microsoft.EntityFrameworkCore.Migrations;

namespace FieldMgt.Core.Migrations
{
    public partial class FIELDMGTCOREDYDY0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "ClientSource_FK",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_ContactDetails_ContactDetailId",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "PermanentAddressId",
                table: "Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ContactDetailId",
                table: "Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientSource",
                table: "Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BillingAddressId",
                table: "Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "ClientSource_FK",
                table: "Client",
                column: "ClientSource",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_ContactDetails_ContactDetailId",
                table: "Client",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "ClientSource_FK",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_ContactDetails_ContactDetailId",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "PermanentAddressId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactDetailId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientSource",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BillingAddressId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "ClientSource_FK",
                table: "Client",
                column: "ClientSource",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_ContactDetails_ContactDetailId",
                table: "Client",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
