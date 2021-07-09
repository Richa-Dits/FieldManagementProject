using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class Order
    {        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Required]
        //[ForeignKey("LeadID")]
        public int LeadId { get; set; }
        public Lead Lead { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string OrderDescription { get; set; }
        //[ForeignKey("RefId")]
        public int OrderStatus { get; set; }
        public Reference Reference { get; set; }
        public bool? IsActive { get; set; }
        //[ForeignKey("ServiceProviderId")]
        public int SPLocationId { get; set; }
        public SPLocation SPLocation { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PocName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string TeamLead { get; set; }
        public string PocContact { get; set; }
        public DateTime? DueDate { get; set; }
        public float OrderAmount { get; set; }
        public DateTime? ActualCompletionDate { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string AssignedTo { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string CompletionCertifcate { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string DeletedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public ApplicationUser OrderAssignedTo { get; set; }
        public ApplicationUser OrderCreatedBy { get; set; }
        public ApplicationUser OrderModifiedBy { get; set; }
        public ApplicationUser OrderDeletedBy { get; set; }
    }
}
