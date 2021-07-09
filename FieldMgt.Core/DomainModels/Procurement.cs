using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class Procurement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProcurementId { get; set; }        
        [Column(TypeName = "nvarchar(255)")]
        public string CreatedBy { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
