using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class ProductMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductMasterId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string ProductName { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string ProductDescription { get; set; }
        public int Category { get; set; }
        public Reference Reference{get;set;}
        
        [Column(TypeName = "nvarchar(255)")]
        public string ProductCreatedBy { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        
    }
}
