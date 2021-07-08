using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class LeadCall
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeadCallId { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Description { get; set; }
        public int Status { get; set; }
        public int LeadId { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string CalledBy { get; set; }
        public DateTime? CalledOn { get; set; }
        public ApplicationUser LeadCalledBy { get; set; }
        public Reference RefLeadCallStatus { get; set; }
        public Lead RefCallLeadId { get; set; }        
    }
}
