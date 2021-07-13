using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }
		[Column(TypeName = "nvarchar(40)")]
        public string Name { get; set; }
		[Column(TypeName = "nvarchar(10)")]
        public int CountryCode { get; set; }
    }
}
