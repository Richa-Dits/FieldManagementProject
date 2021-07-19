using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FieldMgt.Core.DTOs.Request
{
<<<<<<< HEAD
    public class CreateAddressDTO:BaseAddressModel
=======
    public class CreateAddressDTO:BaseCreateAddressModel
>>>>>>> ef4520a6e7dfe0f38542af7a7fb72274d25103b1
    {
        [StringLength(100, MinimumLength = 5)]
        public string Address { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
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
    public class BaseCreateAddressModel
    {        public int AddressDetailId { get; set; }
    }
}
