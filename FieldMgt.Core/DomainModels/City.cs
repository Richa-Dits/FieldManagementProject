using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }
		[Column(TypeName = "nvarchar(40)")]
        public string CityName { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
