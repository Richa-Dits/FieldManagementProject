using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class RoleModel
    {
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Role { get; set; }
    }
}
