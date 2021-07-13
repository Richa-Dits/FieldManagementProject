using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class Quotation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuotationId { get; set; }        
        [Column(TypeName = "decimal(8,2)")]
        public decimal BuyerDesiredPrice { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal InitialQuotedPrice { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal LastQuotedPrice { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal MinPossiblePrice { get; set; }
        public int LeadId { get; set; }
        public Lead Lead { get; set; }
        public bool? IsActive { get; set; }
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
        public ApplicationUser NegotitationCreatedBy { get; set; }
        public ApplicationUser NegotitationModifiedBy { get; set; }
        public ApplicationUser NegotitationDeletedBy { get; set; }
    }
}
