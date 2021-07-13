using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class GlobalCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GlobalCodeId { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Description { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string CodeName { get; set; }
        [DefaultValue(true)]
        public bool? IsActive { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string DeletedBy { get; set; }
        [DefaultValue(false)]
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int GlobalCodeCategoryId { get; set; }
        [ForeignKey("GlobalCodeCategoryId")]
        public GlobalCodeCategory GlobalCodeCategory { get; set; }
        public ApplicationUser GlobalCodeCreatedBy { get; set; }
        public ApplicationUser GlobalCodeModifiedBy { get; set; }
        public ApplicationUser GlobalCodeDeletedBy { get; set; }
    }
}
