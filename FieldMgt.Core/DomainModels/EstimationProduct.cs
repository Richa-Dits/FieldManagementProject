using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class EstimationProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstimationProductId { get; set; }
        public int ProductMasterId { get; set; }
        public ProductMaster ProductMaster { get; set; }
        public float PRoductUnitPrice { get; set; }
        public float QuantityRequired { get; set; }
        public int EstimationId { get; set; }
        public Estimation Estimation { get; set; }
    }
}
