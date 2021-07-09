
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FieldMgt.Core.DomainModels
{
    public class UserAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Address { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        [Column(TypeName = "varchar(10)")]
        [MaxLength(10)]
        public string ZipCode { get; set; }
        public int AddressType { get; set; }
        public Reference Reference { get; set; }
        public int? EmployeeId { get; set; }
        public Staff Staff { get; set; }
        public int? VendorID { get; set; }
        public Vendor Vendor { get; set; }
        public int? ServiceProviderID { get; set; }
        public ServiceProvider ServiceProvider { get; set; }
        public int? LeadId { get; set; }
        public Lead Lead { get; set; }
        public int? SPLocationId { get; set; }
        public SPLocation SPLocation { get; set; }
    }
}
