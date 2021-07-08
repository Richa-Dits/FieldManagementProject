using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class ServiceProvider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceProviderId { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string ServiceProviderName { get; set; }
        [Column(TypeName = "varchar(30)")]
        [MaxLength(15)]
        public string ServiceProviderIncharge { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(14)")]
        [Phone]
        public string Phone { get; set; }
        //[Column(TypeName = "varchar(150)")]
        //public string Address { get; set; }
        //public int CityId { get; set; }
        //public City City { get; set; }
        //public int StateId { get; set; }
        //public State State { get; set; }
        //public int CountryId { get; set; }
        //public Country Country { get; set; }
        //[MaxLength(10)]
        //[Column(TypeName = "char(10)")]
        //public string Zip { get; set; }        
    }
}
