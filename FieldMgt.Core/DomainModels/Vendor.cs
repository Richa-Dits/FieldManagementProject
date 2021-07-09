using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class Vendor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VendorId { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string VendorName { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public ApplicationUser VendorCreatedBy { get; set; }
        public ApplicationUser VendorModifiedBy { get; set; }
        public ApplicationUser VendorDeletedBy { get; set; }
    }
}
