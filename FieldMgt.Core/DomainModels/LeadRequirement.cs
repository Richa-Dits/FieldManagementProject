using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class LeadRequirement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeadRequirementId { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string RequirementDescription { get; set; }
        public DateTime? RequirementGatheredOn { get; set; }
        public int LeadId { get; set; }
        public Lead Lead { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string RequirementGatheredBy { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public ApplicationUser RequirementCreatedBy { get; set; }
        public ApplicationUser RequirementModifiedBy { get; set; }
    }
}
