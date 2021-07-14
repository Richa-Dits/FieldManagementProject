using Microsoft.EntityFrameworkCore.Migrations;

namespace FieldMgt.Core.Migrations
{
    public partial class FIELDMGTCOREDYDY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressDetails_City_CityId",
                table: "AddressDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressDetails_Country_CountryId",
                table: "AddressDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressDetails_References_ReferenceId",
                table: "AddressDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressDetails_State_StateId",
                table: "AddressDetails");

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
                name: "FK_City_State_StateId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_ContactDetails_ContactDetailId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_References_RefGenderReferenceId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_References_RefStatusReferenceId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_EstimationDetails_Estimations_EstimationId",
                table: "EstimationDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_EstimationDetails_ProductsMaster_ProductMasterId",
                table: "EstimationDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Estimations_JobOrder_JobOrderID",
                table: "Estimations");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Notes_NoteId",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Orders_OrderId",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalCodes_GlobalCodeCategories_GlobalCodeCategoryId",
                table: "GlobalCodes");

            migrationBuilder.DropForeignKey(
                name: "LCLeadId_FK",
                table: "LeadCalls");

            migrationBuilder.DropForeignKey(
                name: "LCStatus_FK",
                table: "LeadCalls");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadContacts_AddressDetails_AddressDetailId",
                table: "LeadContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadContacts_ContactDetails_ContactDetailId",
                table: "LeadContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadContacts_Leads_LeadId",
                table: "LeadContacts");

            migrationBuilder.DropForeignKey(
                name: "LCGender_FK",
                table: "LeadContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadRequirements_JobOrder_JobOrderId",
                table: "LeadRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadRequirements_Notes_NotesId",
                table: "LeadRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_ContactDetails_ContactDetailId",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Notes_NotesId",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_References_RefGenderReferenceId",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "LBillingAddress_FK",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "LeadSource_FK",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "LeadStage_FK",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "LeadStatus_FK",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "LPermaAddress_FK",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_Orders_OrderId",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ProductsMaster_ProductMasterId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ContactDetails_ContactDetailId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Notes_NotesId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "OrderBillingAddress_FK",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "OrderPaymentStatus_FK",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "OrderPermaAddress_FK",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderTransactions_Orders_OrderId",
                table: "OrderTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcurementItems_Vendors_VendorId",
                table: "ProcurementItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Notes_NotesId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsMaster_ProductMasterId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsIssued_Notes_NotesId",
                table: "ProductsIssued");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsIssued_Orders_OrderId",
                table: "ProductsIssued");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsMaster_References_ReferenceId",
                table: "ProductsMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProviderLocations_ContactDetails_ContactDetailId",
                table: "ServiceProviderLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProviderLocations_Notes_NotesId",
                table: "ServiceProviderLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProviderLocations_ServiceProviders_ServiceProviderId",
                table: "ServiceProviderLocations");

            migrationBuilder.DropForeignKey(
                name: "SPLocationBillingAddress_FK",
                table: "ServiceProviderLocations");

            migrationBuilder.DropForeignKey(
                name: "SPLocationPermaAddress_FK",
                table: "ServiceProviderLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProviders_ContactDetails_ContactDetailId",
                table: "ServiceProviders");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProviders_Notes_NotesId",
                table: "ServiceProviders");

            migrationBuilder.DropForeignKey(
                name: "SPBillingAddress_FK",
                table: "ServiceProviders");

            migrationBuilder.DropForeignKey(
                name: "SPPermaAddress_FK",
                table: "ServiceProviders");

            migrationBuilder.DropForeignKey(
                name: "CorrespondenceAddress_FK",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "Designation_FK",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_ContactDetails_ContactDetailId",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "PermanentAddress_FK",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_State_Country_CountryId",
                table: "State");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_ContactDetails_ContactDetailId",
                table: "Vendors");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_Notes_NotesId",
                table: "Vendors");

            migrationBuilder.DropForeignKey(
                name: "VendorBillingAddress_FK",
                table: "Vendors");

            migrationBuilder.DropForeignKey(
                name: "VendorPermaAddress_FK",
                table: "Vendors");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropIndex(
                name: "IX_ProductsMaster_ReferenceId",
                table: "ProductsMaster");

            migrationBuilder.DropIndex(
                name: "IX_Leads_RefGenderReferenceId",
                table: "Leads");

            migrationBuilder.DropIndex(
                name: "IX_Client_RefGenderReferenceId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_RefStatusReferenceId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_AddressDetails_ReferenceId",
                table: "AddressDetails");

            migrationBuilder.DropColumn(
                name: "ReferenceId",
                table: "ProductsMaster");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Proposal",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "RefGenderReferenceId",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "RefGenderReferenceId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "RefStatusReferenceId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ReferenceId",
                table: "AddressDetails");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "ProductsMaster",
                newName: "ProductCategory");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "LeadCalls",
                newName: "CallStatus");

            migrationBuilder.RenameIndex(
                name: "IX_LeadCalls_Status",
                table: "LeadCalls",
                newName: "IX_LeadCalls_CallStatus");

            migrationBuilder.RenameColumn(
                name: "CodeName",
                table: "GlobalCodes",
                newName: "GlobalCodeName");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Client",
                newName: "ClientSource");

            migrationBuilder.AlterColumn<string>(
                name: "SPModifiedById",
                table: "ServiceProviders",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SPDeletedById",
                table: "ServiceProviders",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SPCreatedById",
                table: "ServiceProviders",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "OrderTransactions",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientDescription",
                table: "Client",
                type: "nvarchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClienyCompanyName",
                table: "Client",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserTokens",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetUserRoles",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserRoles",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserLogins",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserClaims",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AspNetRoles",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetRoleClaims",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsMaster_ProductCategory",
                table: "ProductsMaster",
                column: "ProductCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatus",
                table: "Orders",
                column: "OrderStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ClientSource",
                table: "Client",
                column: "ClientSource");

            migrationBuilder.CreateIndex(
                name: "IX_AddressDetails_AddressType",
                table: "AddressDetails",
                column: "AddressType");

            migrationBuilder.AddForeignKey(
                name: "AddressTypeRef_FK",
                table: "AddressDetails",
                column: "AddressType",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDetails_City_CityId",
                table: "AddressDetails",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDetails_Country_CountryId",
                table: "AddressDetails",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDetails_State_StateId",
                table: "AddressDetails",
                column: "StateId",
                principalTable: "State",
                principalColumn: "StateId",
                onDelete: ReferentialAction.NoAction);

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
                name: "FK_City_State_StateId",
                table: "City",
                column: "StateId",
                principalTable: "State",
                principalColumn: "StateId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "ClientSource_FK",
                table: "Client",
                column: "ClientSource",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_ContactDetails_ContactDetailId",
                table: "Client",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EstimationDetails_Estimations_EstimationId",
                table: "EstimationDetails",
                column: "EstimationId",
                principalTable: "Estimations",
                principalColumn: "EstimationId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EstimationDetails_ProductsMaster_ProductMasterId",
                table: "EstimationDetails",
                column: "ProductMasterId",
                principalTable: "ProductsMaster",
                principalColumn: "ProductMasterId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Estimations_JobOrder_JobOrderID",
                table: "Estimations",
                column: "JobOrderID",
                principalTable: "JobOrder",
                principalColumn: "JobOrderId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Notes_NoteId",
                table: "Feedback",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Orders_OrderId",
                table: "Feedback",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalCodes_GlobalCodeCategories_GlobalCodeCategoryId",
                table: "GlobalCodes",
                column: "GlobalCodeCategoryId",
                principalTable: "GlobalCodeCategories",
                principalColumn: "GlobalCodeCategoryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LCLeadId_FK",
                table: "LeadCalls",
                column: "LeadId",
                principalTable: "Leads",
                principalColumn: "LeadId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LCStatus_FK",
                table: "LeadCalls",
                column: "CallStatus",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadContacts_AddressDetails_AddressDetailId",
                table: "LeadContacts",
                column: "AddressDetailId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadContacts_ContactDetails_ContactDetailId",
                table: "LeadContacts",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadContacts_Leads_LeadId",
                table: "LeadContacts",
                column: "LeadId",
                principalTable: "Leads",
                principalColumn: "LeadId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LCGender_FK",
                table: "LeadContacts",
                column: "Gender",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadRequirements_JobOrder_JobOrderId",
                table: "LeadRequirements",
                column: "JobOrderId",
                principalTable: "JobOrder",
                principalColumn: "JobOrderId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadRequirements_Notes_NotesId",
                table: "LeadRequirements",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_ContactDetails_ContactDetailId",
                table: "Leads",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Notes_NotesId",
                table: "Leads",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LBillingAddress_FK",
                table: "Leads",
                column: "BillingAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LeadSource_FK",
                table: "Leads",
                column: "LeadSource",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LeadStage_FK",
                table: "Leads",
                column: "LeadStage",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "LeadStatus_FK",
                table: "Leads",
                column: "LeadStatus",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "LPermaAddress_FK",
                table: "Leads",
                column: "PermanentAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_Orders_OrderId",
                table: "Maintenance",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_ProductsMaster_ProductMasterId",
                table: "OrderDetails",
                column: "ProductMasterId",
                principalTable: "ProductsMaster",
                principalColumn: "ProductMasterId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Client_ClientId",
                table: "Orders",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ContactDetails_ContactDetailId",
                table: "Orders",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Notes_NotesId",
                table: "Orders",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "OrderBillingAddress_FK",
                table: "Orders",
                column: "BillingAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "OrderPaymentStatus_FK",
                table: "Orders",
                column: "PaymentStatus",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "OrderPermaAddress_FK",
                table: "Orders",
                column: "PermanentAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "OrderStatus_FK",
                table: "Orders",
                column: "OrderStatus",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTransactions_Orders_OrderId",
                table: "OrderTransactions",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ProcurementItems_Vendors_VendorId",
                table: "ProcurementItems",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "VendorId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Notes_NotesId",
                table: "Products",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsMaster_ProductMasterId",
                table: "Products",
                column: "ProductMasterId",
                principalTable: "ProductsMaster",
                principalColumn: "ProductMasterId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsIssued_Notes_NotesId",
                table: "ProductsIssued",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsIssued_Orders_OrderId",
                table: "ProductsIssued",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "PMCategory_FK",
                table: "ProductsMaster",
                column: "ProductCategory",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProviderLocations_ContactDetails_ContactDetailId",
                table: "ServiceProviderLocations",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProviderLocations_Notes_NotesId",
                table: "ServiceProviderLocations",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProviderLocations_ServiceProviders_ServiceProviderId",
                table: "ServiceProviderLocations",
                column: "ServiceProviderId",
                principalTable: "ServiceProviders",
                principalColumn: "ServiceProviderId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "SPLocationBillingAddress_FK",
                table: "ServiceProviderLocations",
                column: "BillingAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "SPLocationPermaAddress_FK",
                table: "ServiceProviderLocations",
                column: "PermanentAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProviders_ContactDetails_ContactDetailId",
                table: "ServiceProviders",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProviders_Notes_NotesId",
                table: "ServiceProviders",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "SPBillingAddress_FK",
                table: "ServiceProviders",
                column: "BillingAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "SPPermaAddress_FK",
                table: "ServiceProviders",
                column: "PermanentAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "CorrespondenceAddress_FK",
                table: "Staffs",
                column: "CorrespondenceAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "Designation_FK",
                table: "Staffs",
                column: "Designation",
                principalTable: "GlobalCodes",
                principalColumn: "GlobalCodeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_ContactDetails_ContactDetailId",
                table: "Staffs",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "PermanentAddress_FK",
                table: "Staffs",
                column: "PermanentAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_State_Country_CountryId",
                table: "State",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_ContactDetails_ContactDetailId",
                table: "Vendors",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_Notes_NotesId",
                table: "Vendors",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "VendorBillingAddress_FK",
                table: "Vendors",
                column: "BillingAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "VendorPermaAddress_FK",
                table: "Vendors",
                column: "PermanentAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "AddressTypeRef_FK",
                table: "AddressDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressDetails_City_CityId",
                table: "AddressDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressDetails_Country_CountryId",
                table: "AddressDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressDetails_State_StateId",
                table: "AddressDetails");

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
                name: "FK_City_State_StateId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "ClientSource_FK",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_ContactDetails_ContactDetailId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_EstimationDetails_Estimations_EstimationId",
                table: "EstimationDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_EstimationDetails_ProductsMaster_ProductMasterId",
                table: "EstimationDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Estimations_JobOrder_JobOrderID",
                table: "Estimations");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Notes_NoteId",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Orders_OrderId",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalCodes_GlobalCodeCategories_GlobalCodeCategoryId",
                table: "GlobalCodes");

            migrationBuilder.DropForeignKey(
                name: "LCLeadId_FK",
                table: "LeadCalls");

            migrationBuilder.DropForeignKey(
                name: "LCStatus_FK",
                table: "LeadCalls");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadContacts_AddressDetails_AddressDetailId",
                table: "LeadContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadContacts_ContactDetails_ContactDetailId",
                table: "LeadContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadContacts_Leads_LeadId",
                table: "LeadContacts");

            migrationBuilder.DropForeignKey(
                name: "LCGender_FK",
                table: "LeadContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadRequirements_JobOrder_JobOrderId",
                table: "LeadRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadRequirements_Notes_NotesId",
                table: "LeadRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_ContactDetails_ContactDetailId",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Notes_NotesId",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "LBillingAddress_FK",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "LeadSource_FK",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "LeadStage_FK",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "LeadStatus_FK",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "LPermaAddress_FK",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_Orders_OrderId",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ProductsMaster_ProductMasterId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Client_ClientId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ContactDetails_ContactDetailId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Notes_NotesId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "OrderBillingAddress_FK",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "OrderPaymentStatus_FK",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "OrderPermaAddress_FK",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "OrderStatus_FK",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderTransactions_Orders_OrderId",
                table: "OrderTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcurementItems_Vendors_VendorId",
                table: "ProcurementItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Notes_NotesId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsMaster_ProductMasterId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsIssued_Notes_NotesId",
                table: "ProductsIssued");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsIssued_Orders_OrderId",
                table: "ProductsIssued");

            migrationBuilder.DropForeignKey(
                name: "PMCategory_FK",
                table: "ProductsMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProviderLocations_ContactDetails_ContactDetailId",
                table: "ServiceProviderLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProviderLocations_Notes_NotesId",
                table: "ServiceProviderLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProviderLocations_ServiceProviders_ServiceProviderId",
                table: "ServiceProviderLocations");

            migrationBuilder.DropForeignKey(
                name: "SPLocationBillingAddress_FK",
                table: "ServiceProviderLocations");

            migrationBuilder.DropForeignKey(
                name: "SPLocationPermaAddress_FK",
                table: "ServiceProviderLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProviders_ContactDetails_ContactDetailId",
                table: "ServiceProviders");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProviders_Notes_NotesId",
                table: "ServiceProviders");

            migrationBuilder.DropForeignKey(
                name: "SPBillingAddress_FK",
                table: "ServiceProviders");

            migrationBuilder.DropForeignKey(
                name: "SPPermaAddress_FK",
                table: "ServiceProviders");

            migrationBuilder.DropForeignKey(
                name: "CorrespondenceAddress_FK",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "Designation_FK",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_ContactDetails_ContactDetailId",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "PermanentAddress_FK",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_State_Country_CountryId",
                table: "State");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_ContactDetails_ContactDetailId",
                table: "Vendors");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_Notes_NotesId",
                table: "Vendors");

            migrationBuilder.DropForeignKey(
                name: "VendorBillingAddress_FK",
                table: "Vendors");

            migrationBuilder.DropForeignKey(
                name: "VendorPermaAddress_FK",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_ProductsMaster_ProductCategory",
                table: "ProductsMaster");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ClientId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderStatus",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Client_ClientSource",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_AddressDetails_AddressType",
                table: "AddressDetails");

            migrationBuilder.DropColumn(
                name: "ClientDescription",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ClienyCompanyName",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "ProductCategory",
                table: "ProductsMaster",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "CallStatus",
                table: "LeadCalls",
                newName: "Status");

            migrationBuilder.RenameIndex(
                name: "IX_LeadCalls_CallStatus",
                table: "LeadCalls",
                newName: "IX_LeadCalls_Status");

            migrationBuilder.RenameColumn(
                name: "GlobalCodeName",
                table: "GlobalCodes",
                newName: "CodeName");

            migrationBuilder.RenameColumn(
                name: "ClientSource",
                table: "Client",
                newName: "Gender");

            migrationBuilder.AlterColumn<string>(
                name: "SPModifiedById",
                table: "ServiceProviders",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SPDeletedById",
                table: "ServiceProviders",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SPCreatedById",
                table: "ServiceProviders",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReferenceId",
                table: "ProductsMaster",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "OrderTransactions",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Leads",
                type: "nvarchar(15)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Leads",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Leads",
                type: "nvarchar(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Leads",
                type: "nvarchar(30)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Proposal",
                table: "Leads",
                type: "nvarchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RefGenderReferenceId",
                table: "Leads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Client",
                type: "nvarchar(15)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Client",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "nvarchar(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Client",
                type: "nvarchar(30)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RefGenderReferenceId",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RefStatusReferenceId",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserTokens",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetUserRoles",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserRoles",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserLogins",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserClaims",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AspNetRoles",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetRoleClaims",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AddColumn<int>(
                name: "ReferenceId",
                table: "AddressDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    ReferenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceCategory = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ReferenceName = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.ReferenceId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsMaster_ReferenceId",
                table: "ProductsMaster",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_RefGenderReferenceId",
                table: "Leads",
                column: "RefGenderReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_RefGenderReferenceId",
                table: "Client",
                column: "RefGenderReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_RefStatusReferenceId",
                table: "Client",
                column: "RefStatusReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressDetails_ReferenceId",
                table: "AddressDetails",
                column: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDetails_City_CityId",
                table: "AddressDetails",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDetails_Country_CountryId",
                table: "AddressDetails",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDetails_References_ReferenceId",
                table: "AddressDetails",
                column: "ReferenceId",
                principalTable: "References",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDetails_State_StateId",
                table: "AddressDetails",
                column: "StateId",
                principalTable: "State",
                principalColumn: "StateId");

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
                name: "FK_City_State_StateId",
                table: "City",
                column: "StateId",
                principalTable: "State",
                principalColumn: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_ContactDetails_ContactDetailId",
                table: "Client",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_References_RefGenderReferenceId",
                table: "Client",
                column: "RefGenderReferenceId",
                principalTable: "References",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_References_RefStatusReferenceId",
                table: "Client",
                column: "RefStatusReferenceId",
                principalTable: "References",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EstimationDetails_Estimations_EstimationId",
                table: "EstimationDetails",
                column: "EstimationId",
                principalTable: "Estimations",
                principalColumn: "EstimationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstimationDetails_ProductsMaster_ProductMasterId",
                table: "EstimationDetails",
                column: "ProductMasterId",
                principalTable: "ProductsMaster",
                principalColumn: "ProductMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estimations_JobOrder_JobOrderID",
                table: "Estimations",
                column: "JobOrderID",
                principalTable: "JobOrder",
                principalColumn: "JobOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Notes_NoteId",
                table: "Feedback",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Orders_OrderId",
                table: "Feedback",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalCodes_GlobalCodeCategories_GlobalCodeCategoryId",
                table: "GlobalCodes",
                column: "GlobalCodeCategoryId",
                principalTable: "GlobalCodeCategories",
                principalColumn: "GlobalCodeCategoryId");

            migrationBuilder.AddForeignKey(
                name: "LCLeadId_FK",
                table: "LeadCalls",
                column: "LeadId",
                principalTable: "Leads",
                principalColumn: "LeadId");

            migrationBuilder.AddForeignKey(
                name: "LCStatus_FK",
                table: "LeadCalls",
                column: "Status",
                principalTable: "References",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadContacts_AddressDetails_AddressDetailId",
                table: "LeadContacts",
                column: "AddressDetailId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadContacts_ContactDetails_ContactDetailId",
                table: "LeadContacts",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadContacts_Leads_LeadId",
                table: "LeadContacts",
                column: "LeadId",
                principalTable: "Leads",
                principalColumn: "LeadId");

            migrationBuilder.AddForeignKey(
                name: "LCGender_FK",
                table: "LeadContacts",
                column: "Gender",
                principalTable: "References",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadRequirements_JobOrder_JobOrderId",
                table: "LeadRequirements",
                column: "JobOrderId",
                principalTable: "JobOrder",
                principalColumn: "JobOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadRequirements_Notes_NotesId",
                table: "LeadRequirements",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_ContactDetails_ContactDetailId",
                table: "Leads",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Notes_NotesId",
                table: "Leads",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_References_RefGenderReferenceId",
                table: "Leads",
                column: "RefGenderReferenceId",
                principalTable: "References",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "LBillingAddress_FK",
                table: "Leads",
                column: "BillingAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");

            migrationBuilder.AddForeignKey(
                name: "LeadSource_FK",
                table: "Leads",
                column: "LeadSource",
                principalTable: "References",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LeadStage_FK",
                table: "Leads",
                column: "LeadStage",
                principalTable: "References",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "LeadStatus_FK",
                table: "Leads",
                column: "LeadStatus",
                principalTable: "References",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "LPermaAddress_FK",
                table: "Leads",
                column: "PermanentAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_Orders_OrderId",
                table: "Maintenance",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_ProductsMaster_ProductMasterId",
                table: "OrderDetails",
                column: "ProductMasterId",
                principalTable: "ProductsMaster",
                principalColumn: "ProductMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ContactDetails_ContactDetailId",
                table: "Orders",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Notes_NotesId",
                table: "Orders",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "OrderBillingAddress_FK",
                table: "Orders",
                column: "BillingAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");

            migrationBuilder.AddForeignKey(
                name: "OrderPaymentStatus_FK",
                table: "Orders",
                column: "PaymentStatus",
                principalTable: "References",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "OrderPermaAddress_FK",
                table: "Orders",
                column: "PermanentAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTransactions_Orders_OrderId",
                table: "OrderTransactions",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcurementItems_Vendors_VendorId",
                table: "ProcurementItems",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Notes_NotesId",
                table: "Products",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsMaster_ProductMasterId",
                table: "Products",
                column: "ProductMasterId",
                principalTable: "ProductsMaster",
                principalColumn: "ProductMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsIssued_Notes_NotesId",
                table: "ProductsIssued",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsIssued_Orders_OrderId",
                table: "ProductsIssued",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsMaster_References_ReferenceId",
                table: "ProductsMaster",
                column: "ReferenceId",
                principalTable: "References",
                principalColumn: "ReferenceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProviderLocations_ContactDetails_ContactDetailId",
                table: "ServiceProviderLocations",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProviderLocations_Notes_NotesId",
                table: "ServiceProviderLocations",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProviderLocations_ServiceProviders_ServiceProviderId",
                table: "ServiceProviderLocations",
                column: "ServiceProviderId",
                principalTable: "ServiceProviders",
                principalColumn: "ServiceProviderId");

            migrationBuilder.AddForeignKey(
                name: "SPLocationBillingAddress_FK",
                table: "ServiceProviderLocations",
                column: "BillingAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");

            migrationBuilder.AddForeignKey(
                name: "SPLocationPermaAddress_FK",
                table: "ServiceProviderLocations",
                column: "PermanentAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProviders_ContactDetails_ContactDetailId",
                table: "ServiceProviders",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProviders_Notes_NotesId",
                table: "ServiceProviders",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "SPBillingAddress_FK",
                table: "ServiceProviders",
                column: "BillingAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");

            migrationBuilder.AddForeignKey(
                name: "SPPermaAddress_FK",
                table: "ServiceProviders",
                column: "PermanentAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");

            migrationBuilder.AddForeignKey(
                name: "CorrespondenceAddress_FK",
                table: "Staffs",
                column: "CorrespondenceAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");

            migrationBuilder.AddForeignKey(
                name: "Designation_FK",
                table: "Staffs",
                column: "Designation",
                principalTable: "References",
                principalColumn: "ReferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_ContactDetails_ContactDetailId",
                table: "Staffs",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId");

            migrationBuilder.AddForeignKey(
                name: "PermanentAddress_FK",
                table: "Staffs",
                column: "PermanentAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_State_Country_CountryId",
                table: "State",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_ContactDetails_ContactDetailId",
                table: "Vendors",
                column: "ContactDetailId",
                principalTable: "ContactDetails",
                principalColumn: "ContactDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_Notes_NotesId",
                table: "Vendors",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "VendorBillingAddress_FK",
                table: "Vendors",
                column: "BillingAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");

            migrationBuilder.AddForeignKey(
                name: "VendorPermaAddress_FK",
                table: "Vendors",
                column: "PermanentAddressId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailId");
        }
    }
}
