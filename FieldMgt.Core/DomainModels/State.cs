using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StateID { get; set; }
		[Column(TypeName = "varchar(40)")]
        public string StateName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }        
    }
}