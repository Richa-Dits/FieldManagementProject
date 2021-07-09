using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FieldMgt.Core.DomainModels
{
    public class SPLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SPLocationId { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string SPLocationName { get; set; }
        [Column(TypeName = "varchar(30)")]
        [MaxLength(15)]
        public string SPLocationIncharge { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(14)")]
        [Phone]
        public string Phone { get; set; }        
        public int ServiceProviderId { get; set; }
        public ServiceProvider ServicePRovider { get; set; }
    }
}
