using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FieldMgt.Core.DTOs.Request
{
    public class CreateAddressDTO:BaseCreateAddressModel
    {
        [StringLength(100, MinimumLength = 5)]
        public string Address { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string ZipCode { get; set; }
        public int AddressType { get; set; }
    }
    public class BaseCreateAddressModel
    {        public int AddressDetailId { get; set; }
    }
}
