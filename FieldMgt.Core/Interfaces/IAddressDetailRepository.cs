using FieldMgt.Core.DomainModels;
using FieldMgt.Core.DTOs.Request;
using FieldMgt.Core.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FieldMgt.Core.Interfaces
{
    public interface IAddressDetailRepository
    {
        Task<AddressDetail> SaveAddress(CreateAddressDTO model);
        AddressDetail DeleteAddress(int addressId, string deletedBy);        
    }
}
