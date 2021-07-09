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
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Lead> Lead { get; set; }
        public DbSet<LeadContact> LeadContact { get; set; }
        public DbSet<Reference> Reference { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<LeadActivity> LeadActivity { get; set; }
        public DbSet<LeadCall> LeadCall { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ServiceProvider> ServiceProvider { get; set; }
        public DbSet<SPLocation> SPLocation { get; set; }
        public DbSet<StockIssue> StockIssue { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<UserAddress> UserAddress { get; set; }
        public DbSet<UserContact> UserContact { get; set; }
        public DbSet<ProductMaster> ProductMaster { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Procurement> Procurement { get; set; }
        public DbSet<ProcurementItems> ProcurementItems { get; set; }
        protected virtual void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            OnModelCreating(modelBuilder);
           
            modelBuilder.Entity<ApplicationUser>().HasKey(m => m.Id);
            modelBuilder.Entity<Lead>().Property(s => s.LeadId).HasDatabaseGeneratedOption
(DatabaseGeneratedOption.Identity); ;
            modelBuilder.Entity<Staff>().Property(s => s.StaffID).HasDatabaseGeneratedOption
(DatabaseGeneratedOption.Identity); ;
            modelBuilder.Entity<LeadContact>().Property(s =>  s.LeadContactID ).HasDatabaseGeneratedOption
                (DatabaseGeneratedOption.Identity); ;
            modelBuilder.Entity<Reference>().Property(s => s.ReferenceId).HasDatabaseGeneratedOption
                (DatabaseGeneratedOption.Identity); ;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>(act =>
            {
                act.HasOne(field => field.StaffDesignation)
               .WithMany(fk => fk.Ref1Navigation)
               .HasForeignKey(fk => fk.Designation)
               .HasConstraintName("Designation_FK");

                act.HasOne(field => field.StaffUserID)
                .WithMany(fk => fk.Ref2Navigation)
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
            modelBuilder.Entity<LeadActivity>(act =>
            {
                act.HasOne(field => field.RefLeadActivityStatus)
                .WithMany(fk => fk.LeadActivity1Navigation)
                .HasForeignKey(fk => fk.Status)
                .HasConstraintName("LAStatus_FK");

                act.HasOne(field => field.LeadActivityCreatedBy)
                .WithMany(fk => fk.Ref11Navigation)
                .HasForeignKey(fk => fk.CreatedBy)
                .HasConstraintName("LACreatedBy_FK");

                act.HasOne(field => field.LeadActivityModifiedBy)
               .WithMany(fk => fk.Ref12Navigation)
               .HasForeignKey(fk => fk.ModifiedBy)
               .HasConstraintName("LAModifiedBy_FK");

                act.HasOne(field => field.LeadActivityAssignedTo)
                .WithMany(fk => fk.Ref13Navigation)
                .HasForeignKey(fk => fk.AssignedTo)
                .HasConstraintName("LAAssignedTo_FK");

                act.HasOne(field => field.RefLeadId)
                .WithMany(fk => fk.Ref1LeadId)
                .HasForeignKey(fk => fk.LeadId)
                .HasConstraintName("LALeadId_FK");
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
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}

