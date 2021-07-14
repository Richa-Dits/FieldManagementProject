using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class JobOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobOrderId { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string JobOrderDescription { get; set; }
        public int? LeadId { get; set; }
        public Lead Lead { get; set; }
        public int? ClientId { get; set; }
        public Client Client { get; set; }
    }
}
