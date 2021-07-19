using FieldMgt.Core.DomainModels;
using FieldMgt.Core.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FieldMgt.Core.Interfaces
{
    public interface IAddressDetailRepository
    {
        Task<int> SaveAddress(AddressDetail model);
        AddressDetail DeleteAddress(int addressId, string deletedBy);        
    }
}
