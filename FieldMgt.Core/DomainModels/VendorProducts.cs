using System;
using System.Collections.Generic;
using System.Text;

namespace FieldMgt.Core.DomainModels
{
    public class VendorProducts
    {
        public int VendorProductsId { get; set; }
        public int ProductId { get; set; }
        public ProductMaster ProductMaster { get; set; }
        public float ProductPrice { get; set; }
    }
}
