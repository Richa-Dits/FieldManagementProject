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
        [Required]
        public float BuyerDesiredPrice { get; set; }
        public float InitialQuotedPrice { get; set; }
        public float LastQuotedPrice { get; set; }
        public float MinPossiblePrice { get; set; }
        public int LeadID { get; set; }
        public Lead Lead { get; set; }
        public bool? IsActive { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public ApplicationUser NegotitationCreatedBy { get; set; }
        public ApplicationUser NegotitationModifiedBy { get; set; }
    }
}
