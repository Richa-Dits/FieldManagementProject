using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class OrderProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderProductId { get; set; }
        public int ProductMasterId { get; set; }
        public ProductMaster ProductMaster { get; set; }
        public float QuantityRequired { get; set; }
        
    }
}
