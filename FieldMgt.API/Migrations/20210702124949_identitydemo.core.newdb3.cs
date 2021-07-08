using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FieldMgt.API.Migrations
{
    public partial class identitydemocorenewdb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reference",
                columns: table => new
                {
                    ReferenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceName = table.Column<string>(type: "varchar(20)", nullable: true),
                    ReferenceCategory = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reference", x => x.ReferenceId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(20)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(20)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(14)", nullable: true),
                    Email = table.Column<string>(type: "varchar(250)", nullable: true),
                    Address = table.Column<string>(type: "varchar(80)", nullable: true),
                    City = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true),
                    Designation = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "City_FK",
                        column: x => x.City,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "Country_FK",
                        column: x => x.Country,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "Created_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Deleted_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Designation_FK",
                        column: x => x.Designation,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "Modified_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "UserId_FK",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lead",
                columns: table => new
                {
                    LeadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadName = table.Column<string>(type: "varchar(20)", nullable: false),
                    LeadContact = table.Column<string>(type: "varchar(15)", nullable: true),
                    LeadDescription = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    LeadSource = table.Column<int>(type: "int", nullable: false),
                    LeadStatus = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    PermaAddress1 = table.Column<string>(type: "varchar(100)", nullable: true),
                    PermaAddress2 = table.Column<string>(type: "varchar(80)", nullable: true),
                    PermaCity = table.Column<int>(type: "int", nullable: false),
                    PermaCountry = table.Column<int>(type: "int", nullable: false),
                    CoresAddress1 = table.Column<string>(type: "varchar(100)", nullable: true),
                    CoresAddress2 = table.Column<string>(type: "varchar(80)", nullable: true),
                    CoresCity = table.Column<int>(type: "int", nullable: false),
                    CoresCountry = table.Column<int>(type: "int", nullable: false),
                    Zip = table.Column<string>(type: "char(5)", nullable: true),
                    Email = table.Column<string>(type: "varchar(250)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lead", x => x.LeadId);
                    table.ForeignKey(
                        name: "LCoresCity_FK",
                        column: x => x.CoresCity,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LCoresCountry_FK",
                        column: x => x.CoresCountry,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LeadSource_FK",
                        column: x => x.LeadSource,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LeadStatus_FK",
                        column: x => x.LeadStatus,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LGender_FK",
                        column: x => x.Gender,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LPermaCity_FK",
                        column: x => x.PermaCity,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LPermaCountry_FK",
                        column: x => x.PermaCountry,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LeadContact",
                columns: table => new
                {
                    LeadContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(20)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(20)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(14)", nullable: true),
                    Email = table.Column<string>(type: "varchar(250)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    PermaAddress1 = table.Column<string>(type: "varchar(80)", nullable: true),
                    PermaAddress2 = table.Column<string>(type: "varchar(100)", nullable: true),
                    PermaCity = table.Column<int>(type: "int", nullable: false),
                    PermaCountry = table.Column<int>(type: "int", nullable: false),
                    CoresAddress1 = table.Column<string>(type: "varchar(100)", nullable: true),
                    CoresAddress2 = table.Column<string>(type: "varchar(80)", nullable: true),
                    CoresCity = table.Column<int>(type: "int", nullable: false),
                    CoresCountry = table.Column<int>(type: "int", nullable: false),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadContact", x => x.LeadContactID);
                    table.ForeignKey(
                        name: "FK_LeadContact_Lead_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Lead",
                        principalColumn: "LeadId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LCCoresCity_FK",
                        column: x => x.CoresCity,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LCCoresCountry_FK",
                        column: x => x.CoresCountry,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LCCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LCDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LCGender_FK",
                        column: x => x.Gender,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LCModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LCPermaCity_FK",
                        column: x => x.PermaCity,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LCPermaCountry_FK",
                        column: x => x.PermaCountry,
                        principalTable: "Reference",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_City",
                table: "Employee",
                column: "City");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Country",
                table: "Employee",
                column: "Country");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CreatedBy",
                table: "Employee",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DeletedBy",
                table: "Employee",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Designation",
                table: "Employee",
                column: "Designation");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ModifiedBy",
                table: "Employee",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserId",
                table: "Employee",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_CoresCity",
                table: "Lead",
                column: "CoresCity");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_CoresCountry",
                table: "Lead",
                column: "CoresCountry");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_CreatedBy",
                table: "Lead",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_DeletedBy",
                table: "Lead",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_Gender",
                table: "Lead",
                column: "Gender");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_LeadSource",
                table: "Lead",
                column: "LeadSource");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_LeadStatus",
                table: "Lead",
                column: "LeadStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_ModifiedBy",
                table: "Lead",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_PermaCity",
                table: "Lead",
                column: "PermaCity");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_PermaCountry",
                table: "Lead",
                column: "PermaCountry");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContact_CoresCity",
                table: "LeadContact",
                column: "CoresCity");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContact_CoresCountry",
                table: "LeadContact",
                column: "CoresCountry");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContact_CreatedBy",
                table: "LeadContact",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContact_DeletedBy",
                table: "LeadContact",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContact_Gender",
                table: "LeadContact",
                column: "Gender");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContact_LeadId",
                table: "LeadContact",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContact_ModifiedBy",
                table: "LeadContact",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContact_PermaCity",
                table: "LeadContact",
                column: "PermaCity");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContact_PermaCountry",
                table: "LeadContact",
                column: "PermaCountry");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "LeadContact");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Lead");

            migrationBuilder.DropTable(
                name: "Reference");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
