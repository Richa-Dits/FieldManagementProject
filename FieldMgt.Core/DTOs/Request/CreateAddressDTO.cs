using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FieldMgt.Core.DTOs.Request
{
    public class CreateAddressDTO:BaseAddressModel
    {
        [StringLength(100, MinimumLength = 5)]
        public string Address { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int Country { get; set; }
        public string ZipCode { get; set; }
        public int? AddressType { get; set; }
        [DefaultValue(true)]
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class BaseAddressModel
    {
        public int? AddressDetailId { get; set; }
    }
}
