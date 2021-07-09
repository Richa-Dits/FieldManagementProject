using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class UserContact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        [Phone]
        public string PrimaryPhone { get; set; }
        [Phone]
        public string AlternatePhone { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string PrimaryEmail { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string AlternateEmail { get; set; }        
        public int? EmployeeId { get; set; }
        public Staff Employee { get; set; }
        public int? ServiceProviderId { get; set; }
        public ServiceProvider ServiceProvider { get; set; }
        public int? VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public int? LeadId { get; set; }
        public Lead Lead { get; set; }
        public int? SPLocationId { get; set; }
        public SPLocation SPLocation { get; set; }
    }
}
