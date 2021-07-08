using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityID { get; set; }
		[Column(TypeName = "varchar(40)")]
        public string CityName { get; set; }
        //[ForeignKey("StateId")]
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
