using FluentValidation.WebApi;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<LeadContact> LeadContacts { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<LeadCall> LeadCalls { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ServiceProvider> ServiceProviders { get; set; }
        public DbSet<ServiceProviderLocation> SPLocations { get; set; }
        public DbSet<ProductsIssued> ProductsIssued { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<AddressDetail> AddressDetails { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<ProductMaster> ProductsMaster { get; set; }
        public DbSet<Maintenance> Maintenance { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Procurement> Procurements { get; set; }
        public DbSet<ProcurementItems> ProcurementItems { get; set; }
        public DbSet<Estimation> Estimations { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<LeadRequirement> LeadRequirements { get; set; }
        public DbSet<EstimationProduct> EstimationProducts { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<OrderTransaction> OrderTransactions { get; set; }

        protected virtual void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            OnModelCreating(modelBuilder);
           
            modelBuilder.Entity<ApplicationUser>().HasKey(m => m.Id);
            modelBuilder.Entity<Lead>().Property(s => s.LeadId).HasDatabaseGeneratedOption
(DatabaseGeneratedOption.Identity); ;
            modelBuilder.Entity<Staff>().Property(s => s.StaffId).HasDatabaseGeneratedOption
(DatabaseGeneratedOption.Identity); ;
            modelBuilder.Entity<LeadContact>().Property(s =>  s.LeadContactId ).HasDatabaseGeneratedOption
                (DatabaseGeneratedOption.Identity); ;
            modelBuilder.Entity<Reference>().Property(s => s.ReferenceId).HasDatabaseGeneratedOption
                (DatabaseGeneratedOption.Identity); ;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>(act =>
            {
                act.HasOne(field => field.StaffDesignation)
               .WithMany(fk => fk.Staff1Navigation)
               .HasForeignKey(fk => fk.Designation)
               .HasConstraintName("Designation_FK");

                act.HasOne(field => field.StaffUserId)
                .WithMany(fk => fk.Ref1Navigation)
                .HasForeignKey(fk => fk.UserId)
                .HasConstraintName("UserId_FK");

                act.HasOne(field => field.StaffCreatedBy)
               .WithMany(fk => fk.Ref2Navigation)
               .HasForeignKey(fk => fk.CreatedBy)
               .HasConstraintName("Created_FK");

                act.HasOne(field => field.StaffModifiedBy)
                .WithMany(fk => fk.Ref3Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("Modified_FK");

                act.HasOne(field => field.StaffDeletedBy)
                .WithMany(fk => fk.Ref4Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("Deleted_FK");


                act.HasOne(field => field.StaffPermaAddress)
                .WithMany(fk => fk.StaffAddress1Id)
                .HasForeignKey(fk => fk.PermanentAddressId)
                .HasConstraintName("PermanentAddress_FK");

                act.HasOne(field => field.StaffCorresAddress)
                .WithMany(fk => fk.StaffAddress2Id)
                .HasForeignKey(fk => fk.CorrespondenceAddressId)
                .HasConstraintName("CorrespondenceAddress_FK");
            });
            modelBuilder.Entity<Lead>(act =>
            {
                act.HasOne(field => field.RefStage)
                .WithMany(fk => fk.Lead1Navigation)
                .HasForeignKey(fk => fk.LeadStatus)
                .HasConstraintName("LeadStatus_FK");

                act.HasOne(field => field.RefSource)
               .WithMany(fk => fk.Lead2Navigation)
               .HasForeignKey(fk => fk.LeadSource)
               .HasConstraintName("LeadSource_FK");

                act.HasOne(field => field.RefGender)
                .WithMany(fk => fk.Lead3Navigation)
                .HasForeignKey(fk => fk.Gender)
                .HasConstraintName("LGender_FK");

                act.HasOne(field => field.RefStatus)
               .WithMany(fk => fk.Lead8Navigation)
               .HasForeignKey(fk => fk.LeadStage)
               .HasConstraintName("LeadStage_FK");

                act.HasOne(field => field.LeadCreatedBy)
               .WithMany(fk => fk.Ref5Navigation)
               .HasForeignKey(fk => fk.CreatedBy)
               .HasConstraintName("LCreatedBy_FK");

                act.HasOne(field => field.LeadModifiedBy)
                .WithMany(fk => fk.Ref6Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("LModifiedBy_FK");

                act.HasOne(field => field.LeadDeletedBy)
                .WithMany(fk => fk.Ref7Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("LDeletedBy_FK");


                act.HasOne(field => field.LeadAddress)
                .WithMany(fk => fk.LeadAddress1Id)
                .HasForeignKey(fk => fk.PermanentAddressId)
                .HasConstraintName("LPermaAddress_FK");

                act.HasOne(field => field.LeadBillingAddress)
                .WithMany(fk => fk.LeadAddress2Id)
                .HasForeignKey(fk => fk.BillingAddressId)
                .HasConstraintName("LBillingAddress_FK");
            });
            modelBuilder.Entity<LeadContact>(act =>
            {                
                act.HasOne(field => field.RefGender)
                .WithMany(fk => fk.LeadContact1Navigation)
                .HasForeignKey(fk => fk.Gender)
                .HasConstraintName("LCGender_FK");

                act.HasOne(field => field.LeadContactCreatedBy)
               .WithMany(fk => fk.Ref8Navigation)
               .HasForeignKey(fk => fk.CreatedBy)
               .HasConstraintName("LCCreatedBy_FK");

                act.HasOne(field => field.LeadContactModifiedBy)
                .WithMany(fk => fk.Ref9Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("LCModifiedBy_FK");

                act.HasOne(field => field.LeadContactDeletedBy)
                .WithMany(fk => fk.Ref10Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("LCDeletedBy_FK");
            });
            modelBuilder.Entity<Notes>(act =>
            {
                act.HasOne(field => field.NotesCreatedBy)
                .WithMany(fk => fk.Ref11Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("NotesCreatedBy_FK");

                act.HasOne(field => field.NotesModifiedBy)
               .WithMany(fk => fk.Ref12Navigation)
               .HasForeignKey(fk => fk.ModifiedBy)
               .HasConstraintName("NotesModifiedBy_FK");

                act.HasOne(field => field.NotesDeletedBy)
                .WithMany(fk => fk.Ref13Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("NotesDeletedTo_FK");
            });
            modelBuilder.Entity<LeadCall>(act =>
            {
                act.HasOne(field => field.LeadCalledBy)
                .WithMany(fk => fk.Ref14Navigation)
                .HasForeignKey(fk => fk.CalledBy)
                .HasConstraintName("LCCalledBy_FK");

                act.HasOne(field => field.RefLeadCallStatus)
               .WithMany(fk => fk.LeadCall1Navigation)
               .HasForeignKey(fk => fk.Status)
               .HasConstraintName("LCStatus_FK");

                act.HasOne(field => field.RefCallLeadId)
                .WithMany(fk => fk.Ref2LeadId)
                .HasForeignKey(fk => fk.LeadId)
                .HasConstraintName("LCLeadId_FK");
            });
            modelBuilder.Entity<ApplicationUser>(act =>
            {
                act.HasOne(field => field.RefDeletedBy)
                .WithMany(fk => fk.Ref15Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("UserDeletedBy_FK");

                act.HasOne(field => field.RefCreatedBy)
                .WithMany(fk => fk.Ref16Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("UserCreatedBy_FK");
            });
            modelBuilder.Entity<Order>(act =>
            {
                act.HasOne(field => field.OrderCreatedBy)
                .WithMany(fk => fk.Ref17Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("OrderCreatedBy_FK");

                act.HasOne(field => field.OrderModifiedBy)
                .WithMany(fk => fk.Ref18Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("OrderModifiedBy_FK");

                act.HasOne(field => field.OrderDeletedBy)
                .WithMany(fk => fk.Ref19Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("OrderDeletedBy_FK");

                act.HasOne(field => field.OrderAssignedTo)
                .WithMany(fk => fk.Ref20Navigation)
                .HasForeignKey(fk => fk.AssignedTo)
                .HasConstraintName("OrderAssignedTo_FK");

                act.HasOne(field => field.OrderPaymentStatus)
                .WithMany(fk => fk.OPStatus)
                .HasForeignKey(fk => fk.PaymentStatus)
                .HasConstraintName("OrderPaymentStatus_FK");


                act.HasOne(field => field.OrderAddress)
                .WithMany(fk => fk.OrderAddress1Id)
                .HasForeignKey(fk => fk.PermanentAddressId)
                .HasConstraintName("OrderPermaAddress_FK");

                act.HasOne(field => field.OrderBillingAddress)
                .WithMany(fk => fk.OrderAddress2Id)
                .HasForeignKey(fk => fk.BillingAddressId)
                .HasConstraintName("OrderBillingAddress_FK");
            });
            modelBuilder.Entity<Quotation>(act =>
            {
                act.HasOne(field => field.NegotitationCreatedBy)
                .WithMany(fk => fk.Ref21Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("QuotationCreatedBy_FK");

                act.HasOne(field => field.NegotitationModifiedBy)
                .WithMany(fk => fk.Ref22Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("QuotationModifiedBy_FK");


                act.HasOne(field => field.NegotitationDeletedBy)
                .WithMany(fk => fk.Ref46Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("QuotationDeletedBy_FK");
            });
            modelBuilder.Entity<LeadRequirement>(act =>
            {
                act.HasOne(field => field.RequirementCreatedBy)
                .WithMany(fk => fk.Ref23Navigation)
                .HasForeignKey(fk => fk.RequirementGatheredBy)
                .HasConstraintName("RequirementCreatedBy_FK");

                act.HasOne(field => field.RequirementModifiedBy)
                .WithMany(fk => fk.Ref24Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("RequirementModifiedBy_FK");

                act.HasOne(field => field.RequirementDeletedBy)
                .WithMany(fk => fk.Ref47Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("RequirementDeletedBy_FK");
            });
            modelBuilder.Entity<Estimation>(act =>
            {
                act.HasOne(field => field.EstimationCreatedBy)
                .WithMany(fk => fk.Ref25Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("EstimationCreatedBy_FK");

                act.HasOne(field => field.EstimationModifiedBy)
                .WithMany(fk => fk.Ref26Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("EstimationModifiedBy_FK");


                act.HasOne(field => field.EstimationDeletedBy)
                .WithMany(fk => fk.Ref36Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("EstimationDeletedBy_FK");
            });
            modelBuilder.Entity<EstimationProduct>(act =>
            {
                act.HasOne(field => field.EstimationProductCreatedBy)
                .WithMany(fk => fk.Ref37Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("EstimationProductCreatedBy_FK");

                act.HasOne(field => field.EstimationProductModifiedBy)
                .WithMany(fk => fk.Ref38Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("EstimationProductModifiedBy_FK");


                act.HasOne(field => field.EstimationProductDeletedBy)
                .WithMany(fk => fk.Ref39Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("EstimationProductDeletedBy_FK");
            });
            modelBuilder.Entity<Maintenance>(act =>
            {
                act.HasOne(field => field.MaintenanceCreatedBy)
                .WithMany(fk => fk.Ref43Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("MaintenanceCreatedBy_FK");

                act.HasOne(field => field.MaintenanceModifiedBy)
                .WithMany(fk => fk.Ref44Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("MaintenanceModifiedBy_FK");


                act.HasOne(field => field.MaintenanceDeletedBy)
                .WithMany(fk => fk.Ref45Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("MaintenanceDeletedBy_FK");
            });
            modelBuilder.Entity<Feedback>(act =>
            {
                act.HasOne(field => field.FeedBackCreatedBy)
                .WithMany(fk => fk.Ref40Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("FeedbackCreatedBy_FK");

                act.HasOne(field => field.FeedBackModifiedBy)
                .WithMany(fk => fk.Ref41Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("FeedbackModifiedBy_FK");


                act.HasOne(field => field.FeedBackDeletedBy)
                .WithMany(fk => fk.Ref42Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("FeedbackDeletedBy_FK");
            });
            modelBuilder.Entity<OrderProduct>(act =>
            {
                act.HasOne(field => field.OrderProductCreatedBy)
                .WithMany(fk => fk.Ref48Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("OPCreatedBy_FK");

                act.HasOne(field => field.OrderProductModifiedBy)
                .WithMany(fk => fk.Ref49Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("OPModifiedBy_FK");


                act.HasOne(field => field.OrderProductDeletedBy)
                .WithMany(fk => fk.Ref50Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("OPDeletedBy_FK");
            });
            modelBuilder.Entity<Procurement>(act =>
            {
                act.HasOne(field => field.ProcurementCreatedBy)
                .WithMany(fk => fk.Ref51Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("ProcurementCreatedBy_FK");

                act.HasOne(field => field.ProcurementModifiedBy)
                .WithMany(fk => fk.Ref52Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("ProcurementModifiedBy_FK");


                act.HasOne(field => field.ProcurementDeletedBy)
                .WithMany(fk => fk.Ref53Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("ProcurementDeletedBy_FK");
            });
            modelBuilder.Entity<OrderTransaction>(act =>
            {
                act.HasOne(field => field.OrderTransactionCreatedBy)
                .WithMany(fk => fk.Ref27Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("OrderTransactionCreatedBy_FK");

                act.HasOne(field => field.OrderTransactionModifiedBy)
                .WithMany(fk => fk.Ref28Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("OrderTransactionModifiedBy_FK");

                act.HasOne(field => field.OrderTransactionDeletedBy)
                .WithMany(fk => fk.Ref29Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("OrderTransactionDeletedBy_FK");
            });
            modelBuilder.Entity<Vendor>(act =>
            {
                act.HasOne(field => field.VendorCreatedBy)
                .WithMany(fk => fk.Ref30Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("VendorCreatedBy_FK");

                act.HasOne(field => field.VendorModifiedBy)
                .WithMany(fk => fk.Ref31Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("VendorModifiedBy_FK");

                act.HasOne(field => field.VendorDeletedBy)
                .WithMany(fk => fk.Ref32Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("VendorDeletedBy_FK");

                act.HasOne(field => field.VendorAddress)
                .WithMany(fk => fk.VendorAddress1Id)
                .HasForeignKey(fk => fk.PermanentAddressId)
                .HasConstraintName("VendorPermaAddress_FK");

                act.HasOne(field => field.VendorBillingAddress)
                .WithMany(fk => fk.VendorAddress2Id)
                .HasForeignKey(fk => fk.BillingAddressId)
                .HasConstraintName("VendorBillingAddress_FK");
            });
            modelBuilder.Entity<ProductsIssued>(act =>
            {
                act.HasOne(field => field.ProductIssuedBy)
                .WithMany(fk => fk.Ref33Navigation)
                .HasForeignKey(fk => fk.IssuedBy)
                .HasConstraintName("ProductIssuedBy_FK");

                act.HasOne(field => field.PIModifiedBy)
                .WithMany(fk => fk.Ref34Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("PIModifiedBy_FK");

                act.HasOne(field => field.PIDeletedBy)
                .WithMany(fk => fk.Ref35Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("PIdeletedBy_FK");
            });
            modelBuilder.Entity<ServiceProvider>(act =>
            {
                act.HasOne(field => field.ServiceProviderAddress)
                .WithMany(fk => fk.ServiceProviderAddress1Id)
                .HasForeignKey(fk => fk.PermanentAddressId)
                .HasConstraintName("SPPermaAddress_FK");

                act.HasOne(field => field.ServiceProviderBillingAddress)
                .WithMany(fk => fk.ServiceProviderAddress2Id)
                .HasForeignKey(fk => fk.BillingAddressId)
                .HasConstraintName("SPBillingAddress_FK");
            });
            modelBuilder.Entity<ServiceProviderLocation>(act =>
            {
                act.HasOne(field => field.ServiceProviderLocationAddress)
                .WithMany(fk => fk.ServiceProviderLocationAddress1Id)
                .HasForeignKey(fk => fk.PermanentAddressId)
                .HasConstraintName("SPLocationPermaAddress_FK");

                act.HasOne(field => field.ServiceProviderLocationBillingAddress)
                .WithMany(fk => fk.ServiceProviderLocationAddress2Id)
                .HasForeignKey(fk => fk.BillingAddressId)
                .HasConstraintName("SPLocationBillingAddress_FK");

                act.HasOne(field => field.SPLCreatedBy)
                .WithMany(fk => fk.Ref60Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("SPLCreatedBy_FK");

                act.HasOne(field => field.SPLModifiedBy)
                .WithMany(fk => fk.Ref61Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("SPLModifiedBy_FK");

                act.HasOne(field => field.SPLDeletedBy)
                .WithMany(fk => fk.Ref62Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("SPLDeleted_FK");            
        });
            modelBuilder.Entity<Product>(act =>
            {
                act.HasOne(field => field.ProductCreatedBy)
                .WithMany(fk => fk.Ref54Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("ProductCreatedBy_FK");

                act.HasOne(field => field.ProductModifiedBy)
                .WithMany(fk => fk.Ref55Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("ProductModifiedBy_FK");


                act.HasOne(field => field.ProductDeletedBy)
                .WithMany(fk => fk.Ref56Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("ProductDeletedBy_FK");
            });
            modelBuilder.Entity<ProductMaster>(act =>
            {
                act.HasOne(field => field.ProductMasterCreatedBy)
                .WithMany(fk => fk.Ref57Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("PMCreatedBy_FK");

                act.HasOne(field => field.ProductMasterModifiedBy)
                .WithMany(fk => fk.Ref58Navigation)
                .HasForeignKey(fk => fk.ModifiedBy)
                .HasConstraintName("PMModifiedBy_FK");

                act.HasOne(field => field.ProductMasterDeletedBy)
                .WithMany(fk => fk.Ref59Navigation)
                .HasForeignKey(fk => fk.DeletedBy)
                .HasConstraintName("PMDeleted_FK");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}

