using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FieldMgt.Core.Migrations
{
    public partial class fieldmgtcoreohefwe123 : Migration
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.ForeignKey(
                        name: "UserCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "UserDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    ContactDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimaryPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternatePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryEmail = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    AlternateEmail = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.ContactDetailId);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    ReferenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ReferenceCategory = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.ReferenceId);
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
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                    table.ForeignKey(
                        name: "CountryCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "CountryDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "CountryModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GlobalCodeCategories",
                columns: table => new
                {
                    GlobalCodeCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    GlobalCodeCategoryName = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    AllowAddDelete = table.Column<bool>(type: "bit", nullable: true),
                    AllowCodeNameEdit = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalCodeCategories", x => x.GlobalCodeCategoryId);
                    table.ForeignKey(
                        name: "GlobalCodeCategoryCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "GlobalCodeCategoryDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "GlobalCodeCategoryModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotesTypeId = table.Column<int>(type: "int", nullable: false),
                    NoteDescription = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    NoteTypeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NoteId);
                    table.ForeignKey(
                        name: "NotesCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "NotesDeletedTo_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "NotesModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Procurements",
                columns: table => new
                {
                    ProcurementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procurements", x => x.ProcurementId);
                    table.ForeignKey(
                        name: "ProcurementCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ProcurementDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ProcurementModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsMaster",
                columns: table => new
                {
                    ProductMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false),
                    ReferenceId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsMaster", x => x.ProductMasterId);
                    table.ForeignKey(
                        name: "FK_ProductsMaster_References_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "References",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PMCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PMDeleted_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PMModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_State_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "StateCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "StateDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "StateModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GlobalCodes",
                columns: table => new
                {
                    GlobalCodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CodeName = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GlobalCodeCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalCodes", x => x.GlobalCodeId);
                    table.ForeignKey(
                        name: "FK_GlobalCodes_GlobalCodeCategories_GlobalCodeCategoryId",
                        column: x => x.GlobalCodeCategoryId,
                        principalTable: "GlobalCodeCategories",
                        principalColumn: "GlobalCodeCategoryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "GlobalCodeCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "GlobalCodeDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "GlobalCodeModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThresholdLimit = table.Column<int>(type: "int", nullable: false),
                    QuantityinStock = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    QuantityonOrder = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    NotesId = table.Column<int>(type: "int", nullable: false),
                    ProductMasterId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Products_ProductsMaster_ProductMasterId",
                        column: x => x.ProductMasterId,
                        principalTable: "ProductsMaster",
                        principalColumn: "ProductMasterId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "ProductCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ProductDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ProductModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "CityCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "CityDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "CityModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_City_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AddressDetails",
                columns: table => new
                {
                    AddressDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    ReferenceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressDetails", x => x.AddressDetailId);
                    table.ForeignKey(
                        name: "FK_AddressDetails_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddressDetails_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddressDetails_References_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "References",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddressDetails_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ContactDetailId = table.Column<int>(type: "int", nullable: false),
                    PermanentAddressId = table.Column<int>(type: "int", nullable: false),
                    BillingAddressId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefStatusReferenceId = table.Column<int>(type: "int", nullable: true),
                    RefGenderReferenceId = table.Column<int>(type: "int", nullable: true),
                    ClientAddressAddressDetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                    table.ForeignKey(
                        name: "ClientCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ClientDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ClientModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_AddressDetails_ClientAddressAddressDetailId",
                        column: x => x.ClientAddressAddressDetailId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_ContactDetails_ContactDetailId",
                        column: x => x.ContactDetailId,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Client_References_RefGenderReferenceId",
                        column: x => x.RefGenderReferenceId,
                        principalTable: "References",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_References_RefStatusReferenceId",
                        column: x => x.RefStatusReferenceId,
                        principalTable: "References",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    LeadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadCompanyName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    LeadDescription = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    LeadSource = table.Column<int>(type: "int", nullable: false),
                    LeadStatus = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LeadStage = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    Proposal = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    NotesId = table.Column<int>(type: "int", nullable: false),
                    ContactDetailId = table.Column<int>(type: "int", nullable: false),
                    PermanentAddressId = table.Column<int>(type: "int", nullable: false),
                    BillingAddressId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefGenderReferenceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.LeadId);
                    table.ForeignKey(
                        name: "FK_Leads_ContactDetails_ContactDetailId",
                        column: x => x.ContactDetailId,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Leads_Notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Leads_References_RefGenderReferenceId",
                        column: x => x.RefGenderReferenceId,
                        principalTable: "References",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LBillingAddress_FK",
                        column: x => x.BillingAddressId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
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
                        principalTable: "References",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LeadStage_FK",
                        column: x => x.LeadStage,
                        principalTable: "References",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LeadStatus_FK",
                        column: x => x.LeadStatus,
                        principalTable: "References",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LPermaAddress_FK",
                        column: x => x.PermanentAddressId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    OrderDescription = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    ContactDetailId = table.Column<int>(type: "int", nullable: false),
                    PermanentAddressId = table.Column<int>(type: "int", nullable: false),
                    BillingAddressId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsComplete = table.Column<bool>(type: "bit", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualCompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignedTo = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    OrderAmount = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    AmountPaid = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    BalanceAmount = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    CompletionCertifcate = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    NotesId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_ContactDetails_ContactDetailId",
                        column: x => x.ContactDetailId,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Orders_Notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "OrderAssignedTo_FK",
                        column: x => x.AssignedTo,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "OrderBillingAddress_FK",
                        column: x => x.BillingAddressId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "OrderCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "OrderDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "OrderModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "OrderPaymentStatus_FK",
                        column: x => x.PaymentStatus,
                        principalTable: "References",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "OrderPermaAddress_FK",
                        column: x => x.PermanentAddressId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ServiceProviders",
                columns: table => new
                {
                    ServiceProviderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceProviderName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ServiceProviderIncharge = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NotesId = table.Column<int>(type: "int", nullable: false),
                    ContactDetailId = table.Column<int>(type: "int", nullable: false),
                    PermanentAddressId = table.Column<int>(type: "int", nullable: false),
                    BillingAddressId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SPCreatedById = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    SPModifiedById = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    SPDeletedById = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceProviders", x => x.ServiceProviderId);
                    table.ForeignKey(
                        name: "FK_ServiceProviders_AspNetUsers_SPCreatedById",
                        column: x => x.SPCreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceProviders_AspNetUsers_SPDeletedById",
                        column: x => x.SPDeletedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceProviders_AspNetUsers_SPModifiedById",
                        column: x => x.SPModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceProviders_ContactDetails_ContactDetailId",
                        column: x => x.ContactDetailId,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ServiceProviders_Notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "SPBillingAddress_FK",
                        column: x => x.BillingAddressId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "SPPermaAddress_FK",
                        column: x => x.PermanentAddressId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Designation = table.Column<int>(type: "int", nullable: false),
                    PermanentAddressId = table.Column<int>(type: "int", nullable: false),
                    CorrespondenceAddressId = table.Column<int>(type: "int", nullable: false),
                    ContactDetailId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffId);
                    table.ForeignKey(
                        name: "CorrespondenceAddress_FK",
                        column: x => x.CorrespondenceAddressId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
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
                        principalTable: "References",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Staffs_ContactDetails_ContactDetailId",
                        column: x => x.ContactDetailId,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "Modified_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PermanentAddress_FK",
                        column: x => x.PermanentAddressId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "UserId_FK",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorCompanyName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    VendorOwnerorMD = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    VendorContactPersonName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    VendorGSTNumber = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    VendorAccountNumber = table.Column<string>(type: "nvarchar(12)", nullable: true),
                    VendorIFSCCode = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    VendorBankName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    VendorBankBranch = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PermanentAddressId = table.Column<int>(type: "int", nullable: false),
                    BillingAddressId = table.Column<int>(type: "int", nullable: false),
                    ContactDetailId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NotesId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                    table.ForeignKey(
                        name: "FK_Vendors_ContactDetails_ContactDetailId",
                        column: x => x.ContactDetailId,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Vendors_Notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "VendorBillingAddress_FK",
                        column: x => x.BillingAddressId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "VendorCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "VendorDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "VendorModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "VendorPermaAddress_FK",
                        column: x => x.PermanentAddressId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "JobOrder",
                columns: table => new
                {
                    JobOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobOrderDescription = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    LeadId = table.Column<int>(type: "int", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOrder", x => x.JobOrderId);
                    table.ForeignKey(
                        name: "FK_JobOrder_Leads_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "LeadId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeadCalls",
                columns: table => new
                {
                    LeadCallId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    CalledBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CalledOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadCalls", x => x.LeadCallId);
                    table.ForeignKey(
                        name: "LCCalledBy_FK",
                        column: x => x.CalledBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "LCLeadId_FK",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "LeadId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LCStatus_FK",
                        column: x => x.Status,
                        principalTable: "References",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LeadContacts",
                columns: table => new
                {
                    LeadContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    AddressDetailId = table.Column<int>(type: "int", nullable: false),
                    ContactDetailId = table.Column<int>(type: "int", nullable: false),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadContacts", x => x.LeadContactId);
                    table.ForeignKey(
                        name: "FK_LeadContacts_AddressDetails_AddressDetailId",
                        column: x => x.AddressDetailId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_LeadContacts_ContactDetails_ContactDetailId",
                        column: x => x.ContactDetailId,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_LeadContacts_Leads_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "LeadId",
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
                        principalTable: "References",
                        principalColumn: "ReferenceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "LCModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ActionTaken = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    NoteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FeedbackCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FeedbackDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FeedbackModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feedback_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Feedback_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Maintenance",
                columns: table => new
                {
                    MaintenanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    MaintenanceType = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    TotalCost = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenance", x => x.MaintenanceId);
                    table.ForeignKey(
                        name: "FK_Maintenance_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "MaintenanceCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "MaintenanceDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "MaintenanceModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderTransactions",
                columns: table => new
                {
                    OrderTransactiontId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTransactions", x => x.OrderTransactiontId);
                    table.ForeignKey(
                        name: "FK_OrderTransactions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "OrderTransactionCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "OrderTransactionDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "OrderTransactionModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsIssued",
                columns: table => new
                {
                    ProductIssuedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantityIssued = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    IssuedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IssuedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NotesId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsIssued", x => x.ProductIssuedId);
                    table.ForeignKey(
                        name: "FK_ProductsIssued_Notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductsIssued_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "PIdeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PIModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ProductIssuedBy_FK",
                        column: x => x.IssuedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceProviderLocations",
                columns: table => new
                {
                    ServiceProviderLocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceProviderLocationName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ServiceProviderLocationIncharge = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ContactDetailId = table.Column<int>(type: "int", nullable: false),
                    PermanentAddressId = table.Column<int>(type: "int", nullable: false),
                    BillingAddressId = table.Column<int>(type: "int", nullable: false),
                    NotesId = table.Column<int>(type: "int", nullable: false),
                    ServiceProviderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceProviderLocations", x => x.ServiceProviderLocationId);
                    table.ForeignKey(
                        name: "FK_ServiceProviderLocations_ContactDetails_ContactDetailId",
                        column: x => x.ContactDetailId,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ServiceProviderLocations_Notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ServiceProviderLocations_ServiceProviders_ServiceProviderId",
                        column: x => x.ServiceProviderId,
                        principalTable: "ServiceProviders",
                        principalColumn: "ServiceProviderId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "SPLCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SPLDeleted_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SPLModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SPLocationBillingAddress_FK",
                        column: x => x.BillingAddressId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "SPLocationPermaAddress_FK",
                        column: x => x.PermanentAddressId,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProcurementItems",
                columns: table => new
                {
                    ProcurementItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductMasterId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcurementItems", x => x.ProcurementItemId);
                    table.ForeignKey(
                        name: "FK_ProcurementItems_ProductsMaster_ProductMasterId",
                        column: x => x.ProductMasterId,
                        principalTable: "ProductsMaster",
                        principalColumn: "ProductMasterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProcurementItems_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Estimations",
                columns: table => new
                {
                    EstimationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstimationAmount = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JobOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estimations", x => x.EstimationId);
                    table.ForeignKey(
                        name: "EstimationCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "EstimationDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "EstimationModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estimations_JobOrder_JobOrderID",
                        column: x => x.JobOrderID,
                        principalTable: "JobOrder",
                        principalColumn: "JobOrderId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LeadRequirements",
                columns: table => new
                {
                    JobOrderRequirementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequirementDescription = table.Column<string>(type: "nvarchar(455)", nullable: true),
                    NotesId = table.Column<int>(type: "int", nullable: false),
                    RequirementGatheredOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JobOrderId = table.Column<int>(type: "int", nullable: false),
                    RequirementGatheredBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadRequirements", x => x.JobOrderRequirementId);
                    table.ForeignKey(
                        name: "FK_LeadRequirements_JobOrder_JobOrderId",
                        column: x => x.JobOrderId,
                        principalTable: "JobOrder",
                        principalColumn: "JobOrderId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_LeadRequirements_Notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "RequirementCreatedBy_FK",
                        column: x => x.RequirementGatheredBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "RequirementDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "RequirementModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductMasterId = table.Column<int>(type: "int", nullable: false),
                    QuantityRequired = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    JobOrderId = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderProductId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_JobOrder_JobOrderId",
                        column: x => x.JobOrderId,
                        principalTable: "JobOrder",
                        principalColumn: "JobOrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ProductsMaster_ProductMasterId",
                        column: x => x.ProductMasterId,
                        principalTable: "ProductsMaster",
                        principalColumn: "ProductMasterId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "OPCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "OPDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "OPModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quotations",
                columns: table => new
                {
                    QuotationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerDesiredPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    InitialQuotedPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    LastQuotedPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    MinPossiblePrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    JobOrderId = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotations", x => x.QuotationId);
                    table.ForeignKey(
                        name: "FK_Quotations_JobOrder_JobOrderId",
                        column: x => x.JobOrderId,
                        principalTable: "JobOrder",
                        principalColumn: "JobOrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quotations_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "QuotationCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "QuotationDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "QuotationModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstimationDetails",
                columns: table => new
                {
                    EstimationDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductMasterId = table.Column<int>(type: "int", nullable: false),
                    ProductUnitPrice = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    QuantityRequired = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstimationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstimationDetails", x => x.EstimationDetailId);
                    table.ForeignKey(
                        name: "EstimationDetailCreatedBy_FK",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "EstimationDetailDeletedBy_FK",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "EstimationDetailModifiedBy_FK",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EstimationDetails_Estimations_EstimationId",
                        column: x => x.EstimationId,
                        principalTable: "Estimations",
                        principalColumn: "EstimationId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EstimationDetails_ProductsMaster_ProductMasterId",
                        column: x => x.ProductMasterId,
                        principalTable: "ProductsMaster",
                        principalColumn: "ProductMasterId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressDetails_CityId",
                table: "AddressDetails",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressDetails_CountryId",
                table: "AddressDetails",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressDetails_ReferenceId",
                table: "AddressDetails",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressDetails_StateId",
                table: "AddressDetails",
                column: "StateId");

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
                name: "IX_AspNetUsers_CreatedBy",
                table: "AspNetUsers",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DeletedBy",
                table: "AspNetUsers",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_City_CreatedBy",
                table: "City",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_City_DeletedBy",
                table: "City",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_City_ModifiedBy",
                table: "City",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId",
                table: "City",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ClientAddressAddressDetailId",
                table: "Client",
                column: "ClientAddressAddressDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ContactDetailId",
                table: "Client",
                column: "ContactDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_CreatedBy",
                table: "Client",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Client_DeletedBy",
                table: "Client",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ModifiedBy",
                table: "Client",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Client_RefGenderReferenceId",
                table: "Client",
                column: "RefGenderReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_RefStatusReferenceId",
                table: "Client",
                column: "RefStatusReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_CreatedBy",
                table: "Country",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Country_DeletedBy",
                table: "Country",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Country_ModifiedBy",
                table: "Country",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EstimationDetails_CreatedBy",
                table: "EstimationDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EstimationDetails_DeletedBy",
                table: "EstimationDetails",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EstimationDetails_EstimationId",
                table: "EstimationDetails",
                column: "EstimationId");

            migrationBuilder.CreateIndex(
                name: "IX_EstimationDetails_ModifiedBy",
                table: "EstimationDetails",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EstimationDetails_ProductMasterId",
                table: "EstimationDetails",
                column: "ProductMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Estimations_CreatedBy",
                table: "Estimations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Estimations_DeletedBy",
                table: "Estimations",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Estimations_JobOrderID",
                table: "Estimations",
                column: "JobOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Estimations_ModifiedBy",
                table: "Estimations",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_CreatedBy",
                table: "Feedback",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_DeletedBy",
                table: "Feedback",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_ModifiedBy",
                table: "Feedback",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_NoteId",
                table: "Feedback",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_OrderId",
                table: "Feedback",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCodeCategories_CreatedBy",
                table: "GlobalCodeCategories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCodeCategories_DeletedBy",
                table: "GlobalCodeCategories",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCodeCategories_ModifiedBy",
                table: "GlobalCodeCategories",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCodes_CreatedBy",
                table: "GlobalCodes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCodes_DeletedBy",
                table: "GlobalCodes",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCodes_GlobalCodeCategoryId",
                table: "GlobalCodes",
                column: "GlobalCodeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCodes_ModifiedBy",
                table: "GlobalCodes",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_JobOrder_LeadId",
                table: "JobOrder",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCalls_CalledBy",
                table: "LeadCalls",
                column: "CalledBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCalls_LeadId",
                table: "LeadCalls",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCalls_Status",
                table: "LeadCalls",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContacts_AddressDetailId",
                table: "LeadContacts",
                column: "AddressDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContacts_ContactDetailId",
                table: "LeadContacts",
                column: "ContactDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContacts_CreatedBy",
                table: "LeadContacts",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContacts_DeletedBy",
                table: "LeadContacts",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContacts_Gender",
                table: "LeadContacts",
                column: "Gender");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContacts_LeadId",
                table: "LeadContacts",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadContacts_ModifiedBy",
                table: "LeadContacts",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadRequirements_DeletedBy",
                table: "LeadRequirements",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadRequirements_JobOrderId",
                table: "LeadRequirements",
                column: "JobOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadRequirements_ModifiedBy",
                table: "LeadRequirements",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadRequirements_NotesId",
                table: "LeadRequirements",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadRequirements_RequirementGatheredBy",
                table: "LeadRequirements",
                column: "RequirementGatheredBy");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_BillingAddressId",
                table: "Leads",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_ContactDetailId",
                table: "Leads",
                column: "ContactDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_CreatedBy",
                table: "Leads",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_DeletedBy",
                table: "Leads",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_LeadSource",
                table: "Leads",
                column: "LeadSource");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_LeadStage",
                table: "Leads",
                column: "LeadStage");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_LeadStatus",
                table: "Leads",
                column: "LeadStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_ModifiedBy",
                table: "Leads",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_NotesId",
                table: "Leads",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_PermanentAddressId",
                table: "Leads",
                column: "PermanentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_RefGenderReferenceId",
                table: "Leads",
                column: "RefGenderReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_CreatedBy",
                table: "Maintenance",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_DeletedBy",
                table: "Maintenance",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_ModifiedBy",
                table: "Maintenance",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_OrderId",
                table: "Maintenance",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_CreatedBy",
                table: "Notes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_DeletedBy",
                table: "Notes",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_ModifiedBy",
                table: "Notes",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CreatedBy",
                table: "OrderDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_DeletedBy",
                table: "OrderDetails",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_JobOrderId",
                table: "OrderDetails",
                column: "JobOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ModifiedBy",
                table: "OrderDetails",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductMasterId",
                table: "OrderDetails",
                column: "ProductMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AssignedTo",
                table: "Orders",
                column: "AssignedTo");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillingAddressId",
                table: "Orders",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ContactDetailId",
                table: "Orders",
                column: "ContactDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CreatedBy",
                table: "Orders",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeletedBy",
                table: "Orders",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ModifiedBy",
                table: "Orders",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_NotesId",
                table: "Orders",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentStatus",
                table: "Orders",
                column: "PaymentStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PermanentAddressId",
                table: "Orders",
                column: "PermanentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTransactions_CreatedBy",
                table: "OrderTransactions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTransactions_DeletedBy",
                table: "OrderTransactions",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTransactions_ModifiedBy",
                table: "OrderTransactions",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTransactions_OrderId",
                table: "OrderTransactions",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementItems_ProductMasterId",
                table: "ProcurementItems",
                column: "ProductMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementItems_VendorId",
                table: "ProcurementItems",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Procurements_CreatedBy",
                table: "Procurements",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Procurements_DeletedBy",
                table: "Procurements",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Procurements_ModifiedBy",
                table: "Procurements",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CreatedBy",
                table: "Products",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DeletedBy",
                table: "Products",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ModifiedBy",
                table: "Products",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products_NotesId",
                table: "Products",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductMasterId",
                table: "Products",
                column: "ProductMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsIssued_DeletedBy",
                table: "ProductsIssued",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsIssued_IssuedBy",
                table: "ProductsIssued",
                column: "IssuedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsIssued_ModifiedBy",
                table: "ProductsIssued",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsIssued_NotesId",
                table: "ProductsIssued",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsIssued_OrderId",
                table: "ProductsIssued",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsMaster_CreatedBy",
                table: "ProductsMaster",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsMaster_DeletedBy",
                table: "ProductsMaster",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsMaster_ModifiedBy",
                table: "ProductsMaster",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsMaster_ReferenceId",
                table: "ProductsMaster",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_CreatedBy",
                table: "Quotations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_DeletedBy",
                table: "Quotations",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_JobOrderId",
                table: "Quotations",
                column: "JobOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_ModifiedBy",
                table: "Quotations",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_OrderId",
                table: "Quotations",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviderLocations_BillingAddressId",
                table: "ServiceProviderLocations",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviderLocations_ContactDetailId",
                table: "ServiceProviderLocations",
                column: "ContactDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviderLocations_CreatedBy",
                table: "ServiceProviderLocations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviderLocations_DeletedBy",
                table: "ServiceProviderLocations",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviderLocations_ModifiedBy",
                table: "ServiceProviderLocations",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviderLocations_NotesId",
                table: "ServiceProviderLocations",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviderLocations_PermanentAddressId",
                table: "ServiceProviderLocations",
                column: "PermanentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviderLocations_ServiceProviderId",
                table: "ServiceProviderLocations",
                column: "ServiceProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviders_BillingAddressId",
                table: "ServiceProviders",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviders_ContactDetailId",
                table: "ServiceProviders",
                column: "ContactDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviders_NotesId",
                table: "ServiceProviders",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviders_PermanentAddressId",
                table: "ServiceProviders",
                column: "PermanentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviders_SPCreatedById",
                table: "ServiceProviders",
                column: "SPCreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviders_SPDeletedById",
                table: "ServiceProviders",
                column: "SPDeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviders_SPModifiedById",
                table: "ServiceProviders",
                column: "SPModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_ContactDetailId",
                table: "Staffs",
                column: "ContactDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_CorrespondenceAddressId",
                table: "Staffs",
                column: "CorrespondenceAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_CreatedBy",
                table: "Staffs",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_DeletedBy",
                table: "Staffs",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_Designation",
                table: "Staffs",
                column: "Designation");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_ModifiedBy",
                table: "Staffs",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_PermanentAddressId",
                table: "Staffs",
                column: "PermanentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_UserId",
                table: "Staffs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryId",
                table: "State",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_State_CreatedBy",
                table: "State",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_State_DeletedBy",
                table: "State",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_State_ModifiedBy",
                table: "State",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_BillingAddressId",
                table: "Vendors",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_ContactDetailId",
                table: "Vendors",
                column: "ContactDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_CreatedBy",
                table: "Vendors",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_DeletedBy",
                table: "Vendors",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_ModifiedBy",
                table: "Vendors",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_NotesId",
                table: "Vendors",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_PermanentAddressId",
                table: "Vendors",
                column: "PermanentAddressId");
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
                name: "Client");

            migrationBuilder.DropTable(
                name: "EstimationDetails");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "GlobalCodes");

            migrationBuilder.DropTable(
                name: "LeadCalls");

            migrationBuilder.DropTable(
                name: "LeadContacts");

            migrationBuilder.DropTable(
                name: "LeadRequirements");

            migrationBuilder.DropTable(
                name: "Maintenance");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderTransactions");

            migrationBuilder.DropTable(
                name: "ProcurementItems");

            migrationBuilder.DropTable(
                name: "Procurements");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductsIssued");

            migrationBuilder.DropTable(
                name: "Quotations");

            migrationBuilder.DropTable(
                name: "ServiceProviderLocations");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Estimations");

            migrationBuilder.DropTable(
                name: "GlobalCodeCategories");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "ProductsMaster");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ServiceProviders");

            migrationBuilder.DropTable(
                name: "JobOrder");

            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "AddressDetails");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
