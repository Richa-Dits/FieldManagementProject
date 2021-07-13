using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class ContactDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactDetailId { get; set; }
        [Phone]
        public string PrimaryPhone { get; set; }
        [Phone]
        public string AlternatePhone { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PrimaryEmail { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string AlternateEmail { get; set; }    
    }
}
