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
        [Column(TypeName = "varchar(50)")]
        public string VendorEmail { get; set; }
        [Column(TypeName = "varchar(14)")]
        [Phone]
        public string Phone { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Address { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string Zip { get; set; }
    }
}
