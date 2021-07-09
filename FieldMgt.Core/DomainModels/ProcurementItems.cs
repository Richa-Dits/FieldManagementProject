using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class ProcurementItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProcurementItemId { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public int ProductId { get; set; }
        public ProductMaster ProductMaster { get; set; }
        public float Quantity { get; set; }
    }
}
