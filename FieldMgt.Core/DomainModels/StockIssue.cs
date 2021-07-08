using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FieldMgt.Core.DomainModels
{
    public class StockIssue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StockIssueId { get; set; }
        public float QuantityIssued { get; set; }
        //[ForeignKey("UserId")]
        public string IssuedBy { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime? IssuedOn { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
