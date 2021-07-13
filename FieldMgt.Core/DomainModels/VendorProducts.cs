using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FieldMgt.Core.DomainModels
{
    public class VendorProducts
    {
        public int VendorProductId { get; set; }
        public int ProductId { get; set; }
        public ProductMaster ProductMaster { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal ProductPrice { get; set; }
    }
}
